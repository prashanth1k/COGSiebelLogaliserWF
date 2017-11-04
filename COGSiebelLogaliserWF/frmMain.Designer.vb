<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssStatus = New System.Windows.Forms.StatusStrip()
        Me.tsslblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsspbProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.tsslblStatusAdd = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblExecTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bwMain = New System.ComponentModel.BackgroundWorker()
        Me.fdSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.fdFileRead = New System.Windows.Forms.OpenFileDialog()
        Me.btnExpandContract = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.nudSQL = New System.Windows.Forms.NumericUpDown()
        Me.nudLog = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.tcMainDisplay = New System.Windows.Forms.TabControl()
        Me.tpSQL = New System.Windows.Forms.TabPage()
        Me.dgSQL = New System.Windows.Forms.DataGridView()
        Me.SQLId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExecTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExecNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalExecTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SQL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindVar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Line = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.tpLog = New System.Windows.Forms.TabPage()
        Me.dgLog = New System.Windows.Forms.DataGridView()
        Me.LogStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogTimeTaken = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogLine = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.tpLogErr = New System.Windows.Forms.TabPage()
        Me.dgLogErr = New System.Windows.Forms.DataGridView()
        Me.LogErrStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogErrCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogErrError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogErrLine = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dsData = New System.Data.DataSet()
        Me.mnuMain.SuspendLayout()
        Me.ssStatus.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.nudSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.tcMainDisplay.SuspendLayout()
        Me.tpSQL.SuspendLayout()
        CType(Me.dgSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpLog.SuspendLayout()
        CType(Me.dgLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpLogErr.SuspendLayout()
        CType(Me.dgLogErr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(133, 24)
        Me.mnuMain.TabIndex = 20
        Me.mnuMain.Text = "msMenu"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem2.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogFileToolStripMenuItem, Me.ToolStripSeparator1, Me.OptionsToolStripMenuItem})
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem3.Text = "&View"
        '
        'LogFileToolStripMenuItem
        '
        Me.LogFileToolStripMenuItem.Enabled = False
        Me.LogFileToolStripMenuItem.Name = "LogFileToolStripMenuItem"
        Me.LogFileToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.LogFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogFileToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.LogFileToolStripMenuItem.Text = "Log File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        Me.OptionsToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem1.Text = "&Help"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(115, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ssStatus
        '
        Me.ssStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.ssStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslblStatus, Me.tsspbProgress, Me.tsslblStatusAdd, Me.tsslblExecTime})
        Me.ssStatus.Location = New System.Drawing.Point(0, 572)
        Me.ssStatus.Name = "ssStatus"
        Me.ssStatus.ShowItemToolTips = True
        Me.ssStatus.Size = New System.Drawing.Size(696, 22)
        Me.ssStatus.Stretch = False
        Me.ssStatus.TabIndex = 22
        Me.ssStatus.Text = "Status"
        '
        'tsslblStatus
        '
        Me.tsslblStatus.AutoToolTip = True
        Me.tsslblStatus.Name = "tsslblStatus"
        Me.tsslblStatus.Size = New System.Drawing.Size(42, 17)
        Me.tsslblStatus.Text = "Ready."
        '
        'tsspbProgress
        '
        Me.tsspbProgress.Name = "tsspbProgress"
        Me.tsspbProgress.Size = New System.Drawing.Size(100, 16)
        Me.tsspbProgress.Visible = False
        '
        'tsslblStatusAdd
        '
        Me.tsslblStatusAdd.Name = "tsslblStatusAdd"
        Me.tsslblStatusAdd.Size = New System.Drawing.Size(616, 17)
        Me.tsslblStatusAdd.Spring = True
        '
        'tsslblExecTime
        '
        Me.tsslblExecTime.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.tsslblExecTime.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsslblExecTime.Name = "tsslblExecTime"
        Me.tsslblExecTime.Size = New System.Drawing.Size(23, 17)
        Me.tsslblExecTime.Text = "0.00s"
        Me.tsslblExecTime.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'bwMain
        '
        '
        'fdFileRead
        '
        Me.fdFileRead.InitialDirectory = "."
        '
        'btnExpandContract
        '
        Me.btnExpandContract.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpandContract.Enabled = False
        Me.btnExpandContract.Font = New System.Drawing.Font("Cambria", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpandContract.Location = New System.Drawing.Point(284, 3)
        Me.btnExpandContract.MaximumSize = New System.Drawing.Size(15, 25)
        Me.btnExpandContract.MinimumSize = New System.Drawing.Size(15, 25)
        Me.btnExpandContract.Name = "btnExpandContract"
        Me.btnExpandContract.Size = New System.Drawing.Size(15, 25)
        Me.btnExpandContract.TabIndex = 31
        Me.btnExpandContract.Text = ">>"
        Me.ToolTip1.SetToolTip(Me.btnExpandContract, "Click to see the log file in a separate editor window.")
        Me.btnExpandContract.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtFile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFile.Location = New System.Drawing.Point(37, 3)
        Me.txtFile.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.txtFile.MaximumSize = New System.Drawing.Size(270, 20)
        Me.txtFile.MinimumSize = New System.Drawing.Size(270, 20)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(270, 20)
        Me.txtFile.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtFile, "Click to browse and select log/spool files")
        '
        'lblFile
        '
        Me.lblFile.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(9, 11)
        Me.lblFile.MaximumSize = New System.Drawing.Size(25, 12)
        Me.lblFile.MinimumSize = New System.Drawing.Size(25, 12)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(25, 12)
        Me.lblFile.TabIndex = 35
        Me.lblFile.Text = "File"
        '
        'btnGo
        '
        Me.btnGo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGo.Location = New System.Drawing.Point(309, 3)
        Me.btnGo.MaximumSize = New System.Drawing.Size(70, 25)
        Me.btnGo.MinimumSize = New System.Drawing.Size(70, 25)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(70, 25)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExport.Enabled = False
        Me.btnExport.Location = New System.Drawing.Point(522, 3)
        Me.btnExport.MaximumSize = New System.Drawing.Size(70, 25)
        Me.btnExport.MinimumSize = New System.Drawing.Size(70, 25)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(70, 25)
        Me.btnExport.TabIndex = 38
        Me.btnExport.Text = "Ex&port"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExit.Location = New System.Drawing.Point(598, 3)
        Me.btnExit.MaximumSize = New System.Drawing.Size(70, 25)
        Me.btnExit.MinimumSize = New System.Drawing.Size(70, 25)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 25)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(696, 594)
        Me.TableLayoutPanel1.TabIndex = 40
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtFile, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnGo, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblFile, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(690, 35)
        Me.TableLayoutPanel2.TabIndex = 34
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.btnExpandContract, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(385, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(302, 29)
        Me.TableLayoutPanel5.TabIndex = 37
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.98795!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.nudSQL, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.nudLog, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(275, 23)
        Me.TableLayoutPanel6.TabIndex = 32
        '
        'nudSQL
        '
        Me.nudSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudSQL.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSQL.Location = New System.Drawing.Point(175, 3)
        Me.nudSQL.Name = "nudSQL"
        Me.nudSQL.Size = New System.Drawing.Size(52, 18)
        Me.nudSQL.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.nudSQL, "Min. SQL execution time to be considered for displaying in the SQL table. Only li" &
        "nes in the spool/log file that represent SQL execution are considered.")
        '
        'nudLog
        '
        Me.nudLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLog.Location = New System.Drawing.Point(233, 3)
        Me.nudLog.Name = "nudLog"
        Me.nudLog.Size = New System.Drawing.Size(39, 18)
        Me.nudLog.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.nudLog, "Min. execution time for log transactions to be considered for Log table. Exec Tim" &
        "e is the diff. b/w two consecutive lines in log file. SQLs are not considered he" &
        "re.")
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 5)
        Me.Label1.MaximumSize = New System.Drawing.Size(55, 12)
        Me.Label1.MinimumSize = New System.Drawing.Size(55, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 12)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Min Time"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.7404!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2596!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnExit, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnExport, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 537)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(690, 54)
        Me.TableLayoutPanel3.TabIndex = 40
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.41446!))
        Me.TableLayoutPanel4.Controls.Add(Me.tcMainDisplay, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 74)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(690, 457)
        Me.TableLayoutPanel4.TabIndex = 41
        '
        'tcMainDisplay
        '
        Me.tcMainDisplay.Controls.Add(Me.tpSQL)
        Me.tcMainDisplay.Controls.Add(Me.tpLog)
        Me.tcMainDisplay.Controls.Add(Me.tpLogErr)
        Me.tcMainDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMainDisplay.Location = New System.Drawing.Point(3, 3)
        Me.tcMainDisplay.Name = "tcMainDisplay"
        Me.tcMainDisplay.SelectedIndex = 0
        Me.tcMainDisplay.Size = New System.Drawing.Size(684, 451)
        Me.tcMainDisplay.TabIndex = 5
        '
        'tpSQL
        '
        Me.tpSQL.AutoScroll = True
        Me.tpSQL.Controls.Add(Me.dgSQL)
        Me.tpSQL.Location = New System.Drawing.Point(4, 22)
        Me.tpSQL.Name = "tpSQL"
        Me.tpSQL.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSQL.Size = New System.Drawing.Size(676, 425)
        Me.tpSQL.TabIndex = 0
        Me.tpSQL.Text = "SQL"
        Me.tpSQL.UseVisualStyleBackColor = True
        '
        'dgSQL
        '
        Me.dgSQL.AllowUserToAddRows = False
        Me.dgSQL.AllowUserToDeleteRows = False
        Me.dgSQL.AllowUserToOrderColumns = True
        Me.dgSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSQL.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgSQL.ColumnHeadersHeight = 21
        Me.dgSQL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SQLId, Me.ExecTime, Me.ExecNo, Me.TotalExecTime, Me.SQL, Me.BindVar, Me.Line})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSQL.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSQL.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgSQL.Location = New System.Drawing.Point(3, 3)
        Me.dgSQL.Name = "dgSQL"
        Me.dgSQL.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSQL.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgSQL.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSQL.ShowEditingIcon = False
        Me.dgSQL.Size = New System.Drawing.Size(670, 419)
        Me.dgSQL.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.dgSQL, "All SQLs that exceed the minimum specified execution time.")
        '
        'SQLId
        '
        Me.SQLId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SQLId.DataPropertyName = "SQLId"
        Me.SQLId.HeaderText = "SQL Id"
        Me.SQLId.MinimumWidth = 50
        Me.SQLId.Name = "SQLId"
        Me.SQLId.ToolTipText = "SQL Id as recorded in spool/log. In case of repetitions, id for the longest runni" &
    "ng SQL is considered."
        Me.SQLId.Width = 50
        '
        'ExecTime
        '
        Me.ExecTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ExecTime.DataPropertyName = "ExecTime"
        Me.ExecTime.HeaderText = "Exec Time"
        Me.ExecTime.MinimumWidth = 60
        Me.ExecTime.Name = "ExecTime"
        Me.ExecTime.ToolTipText = "Displays SQL execution time. In case of repetitions, longest exec time is conside" &
    "red."
        Me.ExecTime.Width = 60
        '
        'ExecNo
        '
        Me.ExecNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ExecNo.DataPropertyName = "ExecNo"
        Me.ExecNo.HeaderText = "# Exec"
        Me.ExecNo.MinimumWidth = 40
        Me.ExecNo.Name = "ExecNo"
        Me.ExecNo.ToolTipText = "No. of executions of the SQL"
        Me.ExecNo.Width = 40
        '
        'TotalExecTime
        '
        Me.TotalExecTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TotalExecTime.DataPropertyName = "TotalExecTime"
        Me.TotalExecTime.HeaderText = "Total Time"
        Me.TotalExecTime.MinimumWidth = 60
        Me.TotalExecTime.Name = "TotalExecTime"
        Me.TotalExecTime.ToolTipText = "Total time taken by all executions of the SQL."
        Me.TotalExecTime.Width = 60
        '
        'SQL
        '
        Me.SQL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SQL.DataPropertyName = "SQL"
        Me.SQL.HeaderText = "SQL"
        Me.SQL.Name = "SQL"
        Me.SQL.ToolTipText = "SQL as recorded in the spool/log"
        '
        'BindVar
        '
        Me.BindVar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.BindVar.DataPropertyName = "BindVar"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BindVar.DefaultCellStyle = DataGridViewCellStyle1
        Me.BindVar.HeaderText = "Bind Var"
        Me.BindVar.MinimumWidth = 95
        Me.BindVar.Name = "BindVar"
        Me.BindVar.ToolTipText = "Bind variables for the SQL. In case of repetitions, variables for the longest run" &
    "ning SQL is considered."
        Me.BindVar.Width = 95
        '
        'Line
        '
        Me.Line.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Line.DataPropertyName = "Line"
        Me.Line.HeaderText = "Line"
        Me.Line.MinimumWidth = 40
        Me.Line.Name = "Line"
        Me.Line.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Line.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Line.Width = 40
        '
        'tpLog
        '
        Me.tpLog.Controls.Add(Me.dgLog)
        Me.tpLog.Location = New System.Drawing.Point(4, 22)
        Me.tpLog.Name = "tpLog"
        Me.tpLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLog.Size = New System.Drawing.Size(676, 425)
        Me.tpLog.TabIndex = 1
        Me.tpLog.Text = "Log"
        Me.tpLog.UseVisualStyleBackColor = True
        '
        'dgLog
        '
        Me.dgLog.AllowUserToAddRows = False
        Me.dgLog.AllowUserToDeleteRows = False
        Me.dgLog.AllowUserToOrderColumns = True
        Me.dgLog.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgLog.ColumnHeadersHeight = 21
        Me.dgLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LogStart, Me.LogEnd, Me.LogTimeTaken, Me.LogLine})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLog.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLog.GridColor = System.Drawing.SystemColors.InactiveBorder
        Me.dgLog.Location = New System.Drawing.Point(3, 3)
        Me.dgLog.Name = "dgLog"
        Me.dgLog.RowHeadersVisible = False
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLog.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgLog.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLog.ShowEditingIcon = False
        Me.dgLog.Size = New System.Drawing.Size(670, 419)
        Me.dgLog.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.dgLog, "All transactions recorded in the log that exceed the minimum specified time.")
        '
        'LogStart
        '
        Me.LogStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LogStart.DataPropertyName = "LogStart"
        Me.LogStart.HeaderText = "Start"
        Me.LogStart.Name = "LogStart"
        Me.LogStart.ToolTipText = "Start time of the transaction"
        Me.LogStart.Width = 110
        '
        'LogEnd
        '
        Me.LogEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LogEnd.DataPropertyName = "LogEnd"
        Me.LogEnd.HeaderText = "End"
        Me.LogEnd.Name = "LogEnd"
        Me.LogEnd.ToolTipText = "End time of the transaction"
        Me.LogEnd.Width = 110
        '
        'LogTimeTaken
        '
        Me.LogTimeTaken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LogTimeTaken.DataPropertyName = "LogTimeTaken"
        Me.LogTimeTaken.HeaderText = "Exec Time"
        Me.LogTimeTaken.Name = "LogTimeTaken"
        Me.LogTimeTaken.Width = 75
        '
        'LogLine
        '
        Me.LogLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LogLine.DataPropertyName = "LogLine"
        Me.LogLine.FillWeight = 130.8917!
        Me.LogLine.HeaderText = "Line"
        Me.LogLine.Name = "LogLine"
        Me.LogLine.Width = 75
        '
        'tpLogErr
        '
        Me.tpLogErr.Controls.Add(Me.dgLogErr)
        Me.tpLogErr.Location = New System.Drawing.Point(4, 22)
        Me.tpLogErr.Name = "tpLogErr"
        Me.tpLogErr.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLogErr.Size = New System.Drawing.Size(676, 425)
        Me.tpLogErr.TabIndex = 2
        Me.tpLogErr.Text = "Error"
        Me.tpLogErr.UseVisualStyleBackColor = True
        '
        'dgLogErr
        '
        Me.dgLogErr.AllowUserToAddRows = False
        Me.dgLogErr.AllowUserToDeleteRows = False
        Me.dgLogErr.AllowUserToOrderColumns = True
        Me.dgLogErr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgLogErr.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgLogErr.ColumnHeadersHeight = 21
        Me.dgLogErr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LogErrStart, Me.LogErrCode, Me.LogErrError, Me.LogErrLine})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLogErr.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgLogErr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLogErr.GridColor = System.Drawing.SystemColors.InactiveBorder
        Me.dgLogErr.Location = New System.Drawing.Point(3, 3)
        Me.dgLogErr.Name = "dgLogErr"
        Me.dgLogErr.RowHeadersVisible = False
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLogErr.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgLogErr.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLogErr.ShowEditingIcon = False
        Me.dgLogErr.Size = New System.Drawing.Size(670, 419)
        Me.dgLogErr.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.dgLogErr, "Displays all errors recorded in Siebel log file.")
        '
        'LogErrStart
        '
        Me.LogErrStart.DataPropertyName = "LogErrStart"
        Me.LogErrStart.HeaderText = "Start"
        Me.LogErrStart.MinimumWidth = 95
        Me.LogErrStart.Name = "LogErrStart"
        Me.LogErrStart.ToolTipText = "Start time of the transaction"
        Me.LogErrStart.Width = 110
        '
        'LogErrCode
        '
        Me.LogErrCode.DataPropertyName = "LogErrCode"
        Me.LogErrCode.HeaderText = "Error Code"
        Me.LogErrCode.Name = "LogErrCode"
        Me.LogErrCode.ToolTipText = "Siebel error code"
        '
        'LogErrError
        '
        Me.LogErrError.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LogErrError.DataPropertyName = "LogErrError"
        Me.LogErrError.HeaderText = "Error"
        Me.LogErrError.Name = "LogErrError"
        Me.LogErrError.ToolTipText = "Double click on cell to view details."
        '
        'LogErrLine
        '
        Me.LogErrLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LogErrLine.DataPropertyName = "LogErrLine"
        Me.LogErrLine.FillWeight = 130.8917!
        Me.LogErrLine.HeaderText = "Line"
        Me.LogErrLine.Name = "LogErrLine"
        Me.LogErrLine.Width = 75
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'dsData
        '
        Me.dsData.DataSetName = "dsSQL"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnGo
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(696, 594)
        Me.Controls.Add(Me.mnuMain)
        Me.Controls.Add(Me.ssStatus)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Siebel Log Analyser"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ssStatus.ResumeLayout(False)
        Me.ssStatus.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.nudSQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.tcMainDisplay.ResumeLayout(False)
        Me.tpSQL.ResumeLayout(False)
        CType(Me.dgSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpLog.ResumeLayout(False)
        CType(Me.dgLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpLogErr.ResumeLayout(False)
        CType(Me.dgLogErr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslblStatusAdd As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslblExecTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bwMain As System.ComponentModel.BackgroundWorker
    Friend WithEvents fdSaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents fdFileRead As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnExpandContract As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tcMainDisplay As System.Windows.Forms.TabControl
    Friend WithEvents tpSQL As System.Windows.Forms.TabPage
    Friend WithEvents dgSQL As System.Windows.Forms.DataGridView
    Friend WithEvents tpLog As System.Windows.Forms.TabPage
    Friend WithEvents tsspbProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgLog As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudSQL As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLog As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tpLogErr As System.Windows.Forms.TabPage
    Friend WithEvents dgLogErr As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dsData As System.Data.DataSet
    Friend WithEvents LogStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogEnd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogTimeTaken As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogLine As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents LogErrStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogErrCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogErrError As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogErrLine As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents SQLId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExecTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExecNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalExecTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SQL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindVar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Line As System.Windows.Forms.DataGridViewLinkColumn

End Class
