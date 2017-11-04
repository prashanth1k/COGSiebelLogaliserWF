
Imports System
Imports System.IO
Imports System.Data
Imports System.Globalization

Public Class clsProcessFile
    Public dsSQLSet As DataSet
    Public dtSQL As DataTable, dtLog As DataTable, dtLogErr As DataTable

    Private trReader As TextReader
    Private slStopThread As New Object

    Public bStopThread As Boolean = False

    Function ProcessFile(ByVal sFileName As String, Optional ByVal iSQLExecDiff As Integer = 0, Optional ByVal iLogExecDiff As Integer = 0) As String
        ' Main function that loops through all lines, collects required information in three datatables of a single dataset
        Dim bLog As Boolean

        Try
            Dim dtPrevDateTime, dtCurDateTime As DateTime
            Dim sLine As String
            Dim sSQLId As String = "", sSQLTime As String = "", sSQL As String = "", sBindVars As String = ""
            Dim lLineNo As Long = 0, lSQLStartLineNo As Long = 0, lLineCount As Long = 0
            Dim lPrevLineNo As Long
            Dim iTempPos, iErrCodePos As Integer
            Dim dTimeDiff As Double, dSQLTime As Double
            Dim bRecording As Boolean = False, bLineProcessed As Boolean = False

            Dim sStartLine As String = My.Settings.SQLStartLine     'Select SQL start
            Dim sStartLineUpd As String = My.Settings.SQLStartLineUpd 'Update SQL start
            Dim sExecLine As String = My.Settings.SQLExecLine       'SQL Exec line, signifies statement end
            Dim sInsExecLine As String = My.Settings.SQLInsertExecLine
            Dim sBindLine As String = My.Settings.SQLBindLine       'Line with bind variable

            ' Read line by line
            ' to-do: find out if reading in blocks gets better performance
            Using srRead As New StreamReader(sFileName)
                sLine = srRead.ReadLine()

                ' the following line signifies log. This is useful to fill in log performance and log error tables
                If sLine.IndexOf(".log") > 0 Then bLog = True 'First line with with a ".log" signifies log file

                ' initialize data tables
                CreateDataTable(bLog)

                Do Until (sLine Is Nothing Or bStopThread)
                    bLineProcessed = True
                    lLineNo += 1

                    Select Case True
                        Case sLine.IndexOf(sStartLine) >= 0
                            ' This line is start of Select SQL, start SQL recording
                            bRecording = True
                            dtPrevDateTime = Nothing
                            sSQLId = sLine.Substring(sLine.LastIndexOf(":") + 1).Trim
                            lSQLStartLineNo = lLineNo

                        Case sLine.IndexOf(sStartLineUpd) >= 0
                            ' This line is start of Update SQL, start SQL recording
                            bRecording = True
                            dtPrevDateTime = Nothing
                            sSQLId = sLine.Substring(sLine.LastIndexOf(":") + 1).Trim
                            lSQLStartLineNo = lLineNo

                        Case sLine.IndexOf(sBindLine) >= 0
                            ' Collect bind variables if recording is already on (b/w SQL start & end statements)
                            If bRecording Then
                                If (bLog And sLine.IndexOf("SQLParseAndExecute") >= 0) Or bLog = False Then
                                    sBindVars += sLine + Environment.NewLine
                                End If
                            End If

                        Case sLine.IndexOf(sExecLine) >= 0 Or sLine.IndexOf(sInsExecLine) >= 0
                            ' End of SQL - select or update. Stop recording
                            bRecording = False
                            iTempPos = sLine.LastIndexOf(":")
                            sSQLTime = sLine.Substring(iTempPos + 1, sLine.IndexOf(".") + 4 - iTempPos)
                            ' Collect data elements only if exec time >= user specified time
                            Try
                                dSQLTime = CDbl(sSQLTime)
                            Catch
                                dSQLTime = -1
                            End Try

                            If (dSQLTime > iSQLExecDiff) Then
                                iTempPos = sSQL.IndexOf(Environment.NewLine + Environment.NewLine)    'first blank line in this string represents the position where SQL has ended
                                dtSQL.Rows.Add(sSQLId, sSQLTime, "1", sSQLTime, sSQL.Substring(0, iTempPos), sBindVars.Substring(0), lSQLStartLineNo)
                            End If
                            sBindVars = ""
                            sSQL = ""

                        Case Else
                            ' if recording is on, SQL is being recorded. Else, there is no use of the line
                            If bRecording Then
                                sSQL = sSQL + sLine.TrimEnd + Environment.NewLine
                            Else
                                bLineProcessed = False
                            End If
                    End Select

                    If bLog And Not bLineProcessed Then
                        ' Collect log information as well (for Siebel logs - just stating the obvious)
                        ' Date in log appears after the fourth tab
                        iTempPos = mdlGeneric.IndexOfN(sLine, vbTab, 4) + 1

                        If iTempPos > 0 Then
                            If DateTime.TryParseExact(sLine.Substring(iTempPos, 19), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, dtCurDateTime) Then
                                If Not (dtPrevDateTime = Nothing) Then
                                    dTimeDiff = dtCurDateTime.Second - dtPrevDateTime.Second
                                    ' Collect info only if transaction time >= user specified time
                                    If (dTimeDiff > iLogExecDiff) Then
                                        dtLog.Rows.Add(dtPrevDateTime.ToString("dd-MMM-yy HH:mm:ss"), dtCurDateTime.ToString("dd-MMM-yy HH:mm:ss"), dTimeDiff, lPrevLineNo)
                                    End If
                                End If
                                lPrevLineNo = lLineNo
                                dtPrevDateTime = dtCurDateTime
                            End If
                        End If

                    End If

                    ' Record errors if "Error" appears after the first tab
                    iTempPos = sLine.IndexOf(vbTab)
                    If iTempPos > 0 Then
                        If sLine.Substring(iTempPos + 1).StartsWith("Error") Then
                            iErrCodePos = sLine.IndexOf("SBL")
                            dtLogErr.Rows.Add(dtCurDateTime.ToString("dd-MMM-yy HH:mm:ss"), sLine.Substring(iErrCodePos, 13), sLine.Substring(iErrCodePos + 13 + 1).Trim, lLineNo)
                        End If
                    End If

                    ' read next line
                    sLine = srRead.ReadLine()

                    ' check whether process needs to be stopped. This happens when user hits 'Cancel' button
                    SyncLock slStopThread
                        If bStopThread Then bStopThread = True
                    End SyncLock

                Loop
            End Using

            ' Remove duplicates and aggregate
            If dsSQLSet.Tables("SQL").Rows.Count > 0 Then ScrubDataTable(dsSQLSet, "SQL", "SQL")

            AddDummyRow(dsSQLSet)
            ProcessFile = ""

        Catch ex As Exception
            ProcessFile = ex.ToString
            Err.Raise(Err.Number, "ProcessFile" & Err.Source, Err.Description)

        Finally
            slStopThread = Nothing

        End Try
    End Function

    Function ProcessFile(ByVal sFileName As String, ByVal MultiThread As Boolean) As String
        ' this is supposed to be a multi-threaded way of achieving things, not in use
        ' to-do: complete this section
        Dim fs As FileStream
        Try
            If MultiThread = False Then
                Me.ProcessFile(sFileName)
            Else
                fs = New FileStream(sFileName, FileMode.Open, FileAccess.Read, FileShare.Read)
                trReader = TextReader.Synchronized(New StreamReader(fs))
                dsSQLSet = New DataSet
            End If 'If MultiThread = False Then
        Catch ex As Exception
            Err.Raise(Err.Number, "ProcessFileMT" & Err.Source, Err.Description)
        Finally
            ProcessFile = ""
        End Try
    End Function

    Private Sub CreateDataTable(ByVal CreateLogSpecificInfo As Boolean)
        ' initialize all datatables. The name specified here should be the same as name specified in individual columns in datagridview
        Try
            Dim dCol As DataColumn

            Me.dsSQLSet = Nothing
            Me.dsSQLSet = New DataSet()
            Me.dtSQL = New DataTable("SQL")

            Me.dsSQLSet.Tables.Add(Me.dtSQL)
            dCol = Me.dtSQL.Columns.Add("SQLId")
            dCol.Caption = "SQL Id"
            dCol = Me.dtSQL.Columns.Add("ExecTime")
            dCol.Caption = "Exec Id"
            dCol = Me.dtSQL.Columns.Add("ExecNo")
            dCol.Caption = "#"
            dCol = Me.dtSQL.Columns.Add("TotalExecTime")
            dCol.Caption = "Total"
            dCol = Me.dtSQL.Columns.Add("SQL")
            dCol.Caption = "SQL"
            dCol = Me.dtSQL.Columns.Add("BindVar")
            dCol.Caption = "Bind Var"
            dCol = Me.dtSQL.Columns.Add("Line")
            dCol.Caption = "Line"

            ' Following lines dont play a role in case of spool. However they are executed so that a table is available for validation
            Me.dtLog = New DataTable("Log")
            Me.dsSQLSet.Tables.Add(Me.dtLog)
            dCol = Me.dtLog.Columns.Add("LogStart")
            dCol.Caption = "Start"
            dCol = Me.dtLog.Columns.Add("LogEnd")
            dCol.Caption = "End"
            dCol = Me.dtLog.Columns.Add("LogTimeTaken")
            dCol.Caption = "Exec Time"
            dCol = Me.dtLog.Columns.Add("LogLine")
            dCol.Caption = "Line"

            Me.dtLogErr = New DataTable("Error")
            Me.dsSQLSet.Tables.Add(Me.dtLogErr)
            dCol = Me.dtLogErr.Columns.Add("LogErrStart")
            dCol.Caption = "Start"
            dCol = Me.dtLogErr.Columns.Add("LogErrCode")
            dCol.Caption = "Error Code"
            dCol = Me.dtLogErr.Columns.Add("LogErrError")
            dCol.Caption = "Error"
            dCol = Me.dtLogErr.Columns.Add("LogErrLine")
            dCol.Caption = "Line"

        Catch Ex As Exception
            Err.Raise(Err.Number, "CreateDataTable:" & Err.Source, Err.Description)

        End Try
    End Sub

    Private Sub ScrubDataTable(ByRef dsData As DataSet, ByVal TableName As String, ByVal GroupColumn As String)
        ' Remove duplicates and do aggregation
        ' to-do: Evaluate using linq for this, or find a better way
        Dim dtTemp As DataTable, dtData As DataTable
        Dim drCur, drPrev As DataRow
        Dim lCtr As Long = 0

        Try
            dtData = dsData.Tables(TableName)
            dtData.DefaultView.Sort = GroupColumn
            dtTemp = dtData.Clone
            drPrev = dtData.Rows(0)

            ' to-do: This is specific to processing SQL, generalise
            For lCtr = 1 To dtData.Rows.Count - 1
                drCur = dtData.Rows(lCtr)
                If drCur.Item(GroupColumn) = drPrev.Item(GroupColumn) Then
                    If CDbl(drCur.Item("ExecTime")) > CDbl(drPrev.Item("ExecTime")) Then
                        drPrev.Item("SQLId") = drCur.Item("SQLId")
                        drPrev.Item("ExecTime") = drCur.Item("ExecTime")
                        drPrev.Item("BindVar") = drCur.Item("BindVar")
                        drPrev.Item("Line") = drCur.Item("Line")
                    End If
                    drPrev.Item("ExecNo") = CInt(drPrev.Item("ExecNo")) + 1
                    drPrev.Item("TotalExecTime") = CDbl(drPrev.Item("TotalExecTime")) + CDbl(drCur.Item("ExecTime"))
                Else
                    dtTemp.ImportRow(drPrev)
                    drPrev = drCur
                End If

            Next
            dtTemp.ImportRow(drPrev)
            dtTemp.AcceptChanges()

            dsData.Tables.Remove(TableName)
            dsData.Tables.Add(dtTemp)

        Catch ex As Exception
            Err.Raise(Err.Number, "ScrubData:" & Err.Source, Err.Description)

        Finally
            drCur = Nothing
            drPrev = Nothing
            dtTemp = Nothing

        End Try
    End Sub

    Private Sub AddDummyRow(ByRef dsData As DataSet)
        ' create dummy rows to display in UI when there is no data
        If dsData.Tables("SQL").Rows.Count <= 0 Then dsData.Tables("SQL").Rows.Add("", "", "", "", "No data to display. Hurray!", "", "")
        If dsData.Tables("Log").Rows.Count <= 0 Then dsData.Tables("Log").Rows.Add("", "No data to display. Hurray!", "", "")
        If dsData.Tables("Error").Rows.Count <= 0 Then dsData.Tables("Error").Rows.Add("", "No errors. Something's wrong!", "", "")
    End Sub
End Class
