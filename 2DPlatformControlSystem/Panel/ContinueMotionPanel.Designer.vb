<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContinueMotionPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.dgvCfg = New System.Windows.Forms.DataGridView()
        Me.cLinearPosMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cRotatePosMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsDGV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.tm1 = New System.Windows.Forms.Timer(Me.components)
        Me.DaqCfg1 = New _2DPlatformControlSystem.DaqCfg()
        CType(Me.dgvCfg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDGV.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(64, 428)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(128, 47)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'dgvCfg
        '
        Me.dgvCfg.AllowUserToAddRows = False
        Me.dgvCfg.AllowUserToDeleteRows = False
        Me.dgvCfg.AllowUserToResizeRows = False
        Me.dgvCfg.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvCfg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCfg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cLinearPosMode, Me.cRotatePosMode})
        Me.dgvCfg.ContextMenuStrip = Me.cmsDGV
        Me.dgvCfg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCfg.Location = New System.Drawing.Point(3, 17)
        Me.dgvCfg.MultiSelect = False
        Me.dgvCfg.Name = "dgvCfg"
        Me.dgvCfg.ReadOnly = True
        Me.dgvCfg.RowHeadersWidth = 20
        Me.dgvCfg.RowTemplate.Height = 23
        Me.dgvCfg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCfg.Size = New System.Drawing.Size(389, 205)
        Me.dgvCfg.TabIndex = 1
        '
        'cLinearPosMode
        '
        Me.cLinearPosMode.HeaderText = "LinearPosMode"
        Me.cLinearPosMode.Name = "cLinearPosMode"
        Me.cLinearPosMode.ReadOnly = True
        Me.cLinearPosMode.Width = 183
        '
        'cRotatePosMode
        '
        Me.cRotatePosMode.HeaderText = "RotatePosMode"
        Me.cRotatePosMode.Name = "cRotatePosMode"
        Me.cRotatePosMode.ReadOnly = True
        Me.cRotatePosMode.Width = 183
        '
        'cmsDGV
        '
        Me.cmsDGV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.EDITToolStripMenuItem, Me.DELETEToolStripMenuItem})
        Me.cmsDGV.Name = "cmsDGV"
        Me.cmsDGV.Size = New System.Drawing.Size(107, 70)
        '
        'ADDToolStripMenuItem
        '
        Me.ADDToolStripMenuItem.Name = "ADDToolStripMenuItem"
        Me.ADDToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.ADDToolStripMenuItem.Text = "ADD"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCfg)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 225)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Continue Motion Parameter"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(363, 428)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(128, 47)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(662, 428)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(128, 47)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'tm1
        '
        '
        'DaqCfg1
        '
        Me.DaqCfg1.ADChanCount = 4
        Me.DaqCfg1.aveNum = 1
        Me.DaqCfg1.expInfo = "here experimental conditions content will paste in excel file at cell(""W1"")"
        Me.DaqCfg1.fileName = "C:\Program Files\Microsoft Visual Studio 14.0\Common7\IDE\ADLinkDaq"
        Me.DaqCfg1.IsDaqEnable = False
        Me.DaqCfg1.Location = New System.Drawing.Point(406, 3)
        Me.DaqCfg1.Name = "DaqCfg1"
        Me.DaqCfg1.ScanCount = 100000
        Me.DaqCfg1.scanFileFormatMode = "XLS"
        Me.DaqCfg1.ScanIntrv = 200
        Me.DaqCfg1.Size = New System.Drawing.Size(511, 225)
        Me.DaqCfg1.TabIndex = 3
        Me.DaqCfg1.xlsHeader = New String() {"CH_1", "CH_2", "CH_3", "CH_4"}
        '
        'ContinueMotionPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.DaqCfg1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "ContinueMotionPanel"
        Me.Size = New System.Drawing.Size(920, 540)
        CType(Me.dgvCfg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDGV.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents dgvCfg As DataGridView
    Friend WithEvents cmsDGV As ContextMenuStrip
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DaqCfg1 As DaqCfg
    Friend WithEvents cLinearPosMode As DataGridViewTextBoxColumn
    Friend WithEvents cRotatePosMode As DataGridViewTextBoxColumn
    Friend WithEvents btnStop As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents tm1 As Timer
End Class
