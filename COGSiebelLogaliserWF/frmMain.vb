Imports System.ComponentModel
Imports System.IO
Imports System.Linq

Public Class frmMain
    ' to-do: find a better editor
    Private Const VIEWER_APP As String = "metapad"
    Private clsInst As clsProcessFile
    Private swWatch As Stopwatch
    Private procViewer As Process
    Private lSQLRowCount, lLogRowCount, lLogErrRowCount As Long

    Declare Auto Function FindWindow Lib "USER32.DLL" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Declare Auto Function SetForegroundWindow Lib "USER32.DLL" (ByVal hWnd As IntPtr) As Boolean

    Private Sub txtFile_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFile.KeyUp
        ' Show file open dialog box either when the mouse button is clicked or if F2 key is hit
        If (e.KeyData = Keys.F2) Then OpenFile()
    End Sub

    Private Sub txtFile_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtFile.MouseClick
        OpenFile()
    End Sub

    Sub ProcessFile(Optional ByVal BackgroundProcess As Boolean = True)
        ' Main section that takes care of the processing of file through the class
        Try
            Dim sFileName As String = txtFile.Text


            If sFileName <> "" Then
                If Not My.Computer.FileSystem.FileExists(sFileName) Then
                    Err.Raise(1010, "", "File does not exist. Select valid file to proceed.")
                End If

                ' Prepare - all pre-processing tasks
                PreProcessor()

                clsInst = New clsProcessFile
                If BackgroundProcess Then
                    'Prepare async process
                    bwMain.WorkerReportsProgress = True
                    bwMain.WorkerSupportsCancellation = True
                    bwMain.RunWorkerAsync(sFileName)
                Else
                    ' This may never be used, and is retained for testing/debugging purposes only
                    Try
                        ' invoke class
                        clsInst.ProcessFile(sFileName)

                        ' merge whatever is returned into a local variable
                        dsData.Merge(clsInst.dsSQLSet)

                        ' populate table
                        PopulateGrid()
                        tsslblStatus.Text = "Done."
                    Catch ex As Exception
                        tsslblStatus.Text = "Error"
                        Err.Raise(Err.Number, "ProcessFile:" & Err.Source, Err.Description)
                    Finally
                        ' all post processing tasks
                        PostProcessor()
                    End Try
                End If
            End If

        Catch Ex As Exception
            Err.Raise(Err.Number, "ProcessFile:" & Err.Source, Err.Description)

        End Try

    End Sub

    Private Sub PreProcessor()
        swWatch = New Stopwatch ' this is to get the elapsed time
        swWatch.Start()
        Timer1.Enabled = True   ' this is dummy timer to force progress bar to work
        btnExport.Enabled = False
        btnExpandContract.Enabled = False
        LogFileToolStripMenuItem.Enabled = False
        tsslblStatus.Text = "Processing.. "
        tsspbProgress.Visible = True

        ' reset the data source and clear datagridview
        dsData.Clear()

        clsInst = Nothing

    End Sub

    Private Sub PopulateGrid()
        ' Populate all datagridviews on the form with the dataset obtained from clsProcess
        Try
            ' Show SQL performance
            lSQLRowCount = dsData.Tables("SQL").Rows.Count
            dsData.Tables("SQL").DefaultView.Sort = "ExecTime DESC"
            dgSQL.DataSource = dsData.Tables("SQL").DefaultView

            ' Show Log performance
            lLogRowCount = dsData.Tables("Log").Rows.Count
            dsData.Tables("Log").DefaultView.Sort = "LogTimeTaken DESC"
            dgLog.DataSource = dsData.Tables("Log").DefaultView

            ' Show all "errors" in the log
            lLogErrRowCount = dsData.Tables("Error").Rows.Count
            dgLogErr.DataSource = dsData.Tables("Error").DefaultView

            btnExport.Enabled = True
            btnExpandContract.Enabled = True
            LogFileToolStripMenuItem.Enabled = True

        Catch ex As Exception
            Err.Raise(Err.Number, "PopulateGrid:" & Err.Source, Err.Description)

        End Try
    End Sub

    Private Sub PostProcessor()
        Try
            ' Reset everything back to beginning of universe and wait for the next big bang
            tsspbProgress.Visible = False
            btnGo.Text = "Go"
            swWatch.Stop()
            Timer1.Enabled = False
            tsslblExecTime.Text = CStr(swWatch.Elapsed.Seconds) + "." + CStr(swWatch.ElapsedMilliseconds).Substring(0, 2) + "s"

        Catch ex As Exception
            Err.Raise(Err.Number, "PostProcessor:" & Err.Source, Err.Description)

        Finally
            clsInst = Nothing
        End Try
    End Sub

    Private Sub frmMain_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        ' Enable drag & drop of files into the form. If a file has been dropped, process it similar to Go button click
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim arrFilePath As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            txtFile.Text = arrFilePath(0)
            HandleProcessRequest()
        End If
    End Sub

    Private Sub frmMain_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        ' Enable drag & drop of files into the form. This event will enable drag effects
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        ' Go button transforms into Go or Cancel based on whether processing has already started
        Try
            If txtFile.Text <> "" Then HandleProcessRequest()

        Catch Ex As Exception
            MsgBox("Error occurred. " & Err.Source & " " & Err.Description, vbExclamation, "Error")
        End Try
    End Sub

    Private Sub bwMain_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bwMain.DoWork
        ' Handle background worker
        Try
            If bwMain.CancellationPending = True Then
                ' this will only cancel subsequent threads
                e.Cancel = True
            Else
                Dim sFileName As String = e.Argument.ToString

                Dim sError As String = clsInst.ProcessFile(sFileName, CInt(nudSQL.Value), CInt(nudLog.Value))
                ' bwMain.ReportProgress(10)     'to-do: future enhancement to report progress as the file is read
            End If

        Catch Ex As Exception
            Err.Raise(Err.Number, "ProcessFile:" & Err.Source, Err.Description)

        End Try
    End Sub

    Private Sub bwMain_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwMain.RunWorkerCompleted
        ' Background worker comes here to conclude
        Try
            Select Case True
                Case e.Cancelled
                    ' Cancel button is clicked
                    tsslblStatus.Text = "Cancelled."

                Case e.Error IsNot Nothing
                    tsslblStatus.Text = "Error."
                    Err.Raise(1050, , e.Error.Message)

                Case Else
                    ' merge whatever is returned into a local variable
                    dsData.Merge(clsInst.dsSQLSet)
                    PopulateGrid()
                    tsslblStatus.Text = "Done."
            End Select

        Catch ex As Exception
            MsgBox("Error occurred. " & Err.Source & " " & Err.Description, vbExclamation, "Error")

        Finally
            PostProcessor()
        End Try
    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' Save preferences and exit.
        ' to-do: find whether there is a better way. Both save and load preferences take time and CPU
        My.Settings.PrefLastUsedFile = txtFile.Text
        My.Settings.PrefLastMinTimeLog = CStr(nudLog.Value)
        My.Settings.PrefLastMinTimeSQL = CStr(nudSQL.Value)
        My.Settings.Save()
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Load preferences, this is from the previous successful closure of the program
        txtFile.Text = My.Settings.PrefLastUsedFile
        If My.Settings.PrefLastMinTimeLog <> "" Then nudLog.Value = CInt(My.Settings.PrefLastMinTimeLog)
        If My.Settings.PrefLastMinTimeSQL <> "" Then nudSQL.Value = CInt(My.Settings.PrefLastMinTimeSQL)
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        ' Enable export functionality from datagridview
        ' to-do: this uses system clipboard. Alternatives are complex, costly - find out whether there is any other way
        Dim dgActive As New DataGridView
        Try
            fdSaveFile.Title = "Export Table"
            fdSaveFile.DefaultExt = ".csv"
            'fdSaveFile.Filter = "CSV Files (.csv)|*.csv|HTML Files (.htm;.html)|*.htm;*.html"
            fdSaveFile.Filter = "CSV Files (.csv)|*.csv"
            fdSaveFile.InitialDirectory = "."
            fdSaveFile.ShowDialog()


            If fdSaveFile.FileName <> "" Then
                ' How I miss eval here. 
                ' TO-DO: find a better way to get active grid
                Select Case (tcMainDisplay.SelectedTab.Text.ToUpper)
                    Case "SQL"
                        dgActive = dgSQL
                    Case "LOG"
                        dgActive = dgLog
                    Case "ERROR"
                        dgActive = dgLogErr
                End Select

                mdlGeneric.ExportFile(fdSaveFile.FileName, fdSaveFile.FilterIndex, dgActive)
            End If

        Catch Ex As Exception
            Err.Raise(Err.Number, "Export:" & Err.Source, Err.Description)

        End Try
    End Sub

    Private Sub btnExpandContract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpandContract.Click
        ' Show log file when button is clicked
        Try
            If btnExpandContract.Text = ">>" Then
                ' button controls the checked option for "View Log" in menu, and vice versa
                DisplayFileContent()
                btnExpandContract.Text = "<<"
                LogFileToolStripMenuItem.Checked = True
            Else
                btnExpandContract.Text = ">>"
                LogFileToolStripMenuItem.Checked = False
                If procViewer IsNot Nothing Then
                    If Not procViewer.HasExited Then
                        procViewer.CloseMainWindow()
                    End If
                End If
            End If

        Catch ex As Exception
            tsslblStatus.Text = "Error displaying content"
        End Try

    End Sub

    Private Sub DisplayFileContent(Optional ByVal LineNum As Long = 1)
        ' Open log through external viewer. If a line number is passed, go to the particular line
        Try
            ' Create a new instance of external viewer if not running
            If procViewer Is Nothing Then
                CreateViewerProcess(LineNum)
            ElseIf procViewer.HasExited Then
                CreateViewerProcess(LineNum)
            ElseIf procViewer.Id Then
                ' if external viewer is already running with the log file, bring it to foreground
                AppActivate(procViewer.Id)
                My.Computer.Keyboard.SendKeys("^{g}")
                My.Computer.Keyboard.SendKeys(LineNum)
                My.Computer.Keyboard.SendKeys("{ENTER}")
            End If
            btnExpandContract.Text = "<<"
            LogFileToolStripMenuItem.Checked = True

        Catch ex As Exception
            tsslblStatus.Text = "Error displaying content"

        End Try
    End Sub

    Private Sub CreateViewerProcess(ByVal LineNum)
        ' Open external viewer and pass on the shortcut required to go to a line
        Dim psiViewer As ProcessStartInfo
        Try
            procViewer = New Process
            Dim sFileName As String = txtFile.Text
            Dim sViewerExe As String = Application.StartupPath & "\" & VIEWER_APP & ".exe"
            If Not System.IO.File.Exists(sViewerExe) Then CreateViewerExe(sViewerExe)
            psiViewer = New ProcessStartInfo
            psiViewer.FileName = sViewerExe
            psiViewer.Arguments = "/g " & LineNum & ":1 " & txtFile.Text
            procViewer = System.Diagnostics.Process.Start(psiViewer)

        Catch ex As Exception
            Err.Raise(Err.Number, "CreateViewerProcess:" & Err.Source, Err.Description)
        End Try
    End Sub

    Private Sub CreateViewerExe(ByVal sViewerExe As String)
        ' External viewer is embedded for portability sake. Viewer license should be compatible
        Try
            System.IO.File.WriteAllBytes(sViewerExe, My.Resources.metapadexe)
            System.IO.File.WriteAllBytes(Application.StartupPath & "\" & VIEWER_APP.Substring(0, VIEWER_APP.LastIndexOf(".")) & ".txt", My.Resources.metapadtxt)

        Catch ex As Exception
            Err.Raise(Err.Number, "CreateViewerExe:" & Err.Source, Err.Description)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LogFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogFileToolStripMenuItem.Click
        ' Display or hide log file through the viewer. Just a novelty
        If (LogFileToolStripMenuItem.Checked) Then
            btnExpandContract.Text = ">>"
            If procViewer IsNot Nothing Then
                If Not procViewer.HasExited Then
                    procViewer.CloseMainWindow()
                End If
            End If
        Else
            btnExpandContract.Text = "<<"
            DisplayFileContent()
        End If
        LogFileToolStripMenuItem.Checked = Not LogFileToolStripMenuItem.Checked
    End Sub

    Private Sub dgSQL_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSQL.CellContentClick, dgSQL.CellClick
        ' Clicking on the hyperlink on line number opens external viewer and navigates to line
        If e.RowIndex >= 0 And e.ColumnIndex = dgSQL.Columns("Line").Index Then
            DisplayFileContent(CLng(dgSQL.Rows(e.RowIndex).Cells(e.ColumnIndex).Value))
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub dgSQL_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSQL.CellContentDoubleClick, dgSQL.CellDoubleClick
        ' Double clicking on a cell in datagridview shows a popup window with data in the cell
        frmPopup.txtPopup.Text = dgSQL.CurrentCell.Value
        frmPopup.Show()
    End Sub

    Private Sub HandleProcessRequest()
        ' Handle Go or Cancel on btnGo
        Try
            If btnGo.Text = "Go" Then
                ProcessFile()
                btnGo.Text = "Cancel"
            Else
                ' this is akin to clicking "Cancel" button
                If bwMain.WorkerSupportsCancellation Then
                    bwMain.CancelAsync()
                    If clsInst IsNot Nothing Then clsInst.bStopThread = True
                End If
                btnGo.Text = "Go"
            End If
        Catch ex As Exception
            btnGo.Text = "Go"
            Err.Raise(Err.Number, Err.Source, Err.Description)
        End Try
    End Sub

    Private Sub dgLog_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLog.CellContentClick
        ' Clicking on the hyperlink on line number opens external viewer and navigates to line
        If e.RowIndex >= 0 And e.ColumnIndex = dgLog.Columns("LogLine").Index Then
            DisplayFileContent(CLng(dgLog.Rows(e.RowIndex).Cells(e.ColumnIndex).Value))
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        ' Help is just a plain text file with some information
        Try
            Dim sHelpFile As String = Application.StartupPath & "\" & "COGSiebelLogaliser-help.txt"
            If Not System.IO.File.Exists(sHelpFile) Then
                System.IO.File.WriteAllBytes(sHelpFile, My.Resources.COGSiebelLogaliserWithLicense_helptxt)
            End If
            System.Diagnostics.Process.Start(sHelpFile)
        Catch
            tsslblStatus.Text = "Error opening help file"
        End Try
    End Sub

    Private Sub dgLogErr_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLogErr.CellContentClick
        ' Clicking on the hyperlink on line number opens external viewer and navigates to line
        If e.RowIndex >= 0 And e.ColumnIndex = dgLogErr.Columns("LogErrLine").Index Then
            DisplayFileContent(CLng(dgLogErr.Rows(e.RowIndex).Cells(e.ColumnIndex).Value))
        End If
    End Sub

    Private Sub dgLogErr_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLogErr.CellContentDoubleClick
        ' Double clicking on a cell in datagridview shows a popup window with data in the cell
        frmPopup.txtPopup.Text = dgLogErr.CurrentCell.Value
        frmPopup.Show()
    End Sub

    Private Sub dgLog_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLog.CellContentDoubleClick
        ' Double clicking on a cell in datagridview shows a popup window with data in the cell
        frmPopup.txtPopup.Text = dgLog.CurrentCell.Value
        frmPopup.Show()
    End Sub

    Private Sub OpenFile()
        fdFileRead.DefaultExt = ".log"
        fdFileRead.Filter = "Log Files (.log)|*.log|Log Files (.txt)|*.txt|All Files|*.*"
        Dim sDir As String = txtFile.Text.LastIndexOf("\") - 1
        If txtFile.Text <> "" Then
            If txtFile.Text <> "" And My.Computer.FileSystem.DirectoryExists(txtFile.Text.Substring(0, sDir)) Then fdFileRead.InitialDirectory = sDir
        Else
            fdFileRead.InitialDirectory = "."
        End If

        Dim bResult As Boolean = CBool(fdFileRead.ShowDialog())
        txtFile.Text = fdFileRead.FileName
        If txtFile.Text <> "" Then HandleProcessRequest()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' to do - get Marquee to work, this is kinda stupid
        If tsspbProgress.Value < 100 Then
            tsspbProgress.Value += 10
        Else
            tsspbProgress.Value = 0
        End If
    End Sub

    Private Sub dgSQL_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSQL.SelectionChanged
        If dgSQL.Rows.Count > 0 Then
            tsslblStatus.Text = "Row: " & dgSQL.CurrentRow.Index + 1 & " of " & lSQLRowCount
        Else
            tsslblStatus.Text = ""
        End If
    End Sub

    Private Sub dgLog_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLog.SelectionChanged
        If dgLog.Rows.Count > 0 Then
            tsslblStatus.Text = "Row: " & dgLog.CurrentRow.Index + 1 & " of " & lLogRowCount
        Else
            tsslblStatus.Text = ""
        End If
    End Sub

    Private Sub dgLogErr_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLogErr.SelectionChanged
        If dgLogErr.Rows.Count > 0 Then
            tsslblStatus.Text = "Row: " & dgLogErr.CurrentRow.Index + 1 & " of " & lLogErrRowCount
        Else
            tsslblStatus.Text = ""
        End If
    End Sub

    Private Sub tcMainDisplay_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles tcMainDisplay.Selected
        tsslblStatus.Text = ""
    End Sub
End Class
