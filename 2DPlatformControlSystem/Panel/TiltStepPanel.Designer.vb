<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiltStepPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TiltStepPanel))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCaliTime = New System.Windows.Forms.TextBox()
        Me.txtEndTilt = New System.Windows.Forms.TextBox()
        Me.txtStartTilt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txtFileToSave = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.ChkCH_4 = New System.Windows.Forms.CheckBox()
        Me.ChkCH_3 = New System.Windows.Forms.CheckBox()
        Me.ChkCH_2 = New System.Windows.Forms.CheckBox()
        Me.ChkCH_1 = New System.Windows.Forms.CheckBox()
        Me.txtxlsHeaderCH_4 = New System.Windows.Forms.TextBox()
        Me.txtxlsHeaderCH_3 = New System.Windows.Forms.TextBox()
        Me.txtxlsHeaderCH_2 = New System.Windows.Forms.TextBox()
        Me.txtxlsHeaderCH_1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtExpCondition = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cboDataSize = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cboScanInterval = New System.Windows.Forms.ComboBox()
        Me.lblScanRate = New System.Windows.Forms.Label()
        Me.chkDaq2005Enable = New System.Windows.Forms.CheckBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tm = New System.Windows.Forms.Timer(Me.components)
        Me.RotatePosModeCfg1 = New _2DPlatformControlSystem.RotatePosModeCfg()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.RotatePosModeCfg1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 316)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tilt Step Configure"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtCaliTime)
        Me.GroupBox2.Controls.Add(Me.txtEndTilt)
        Me.GroupBox2.Controls.Add(Me.txtStartTilt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(191, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Step Configure"
        '
        'txtCaliTime
        '
        Me.txtCaliTime.Location = New System.Drawing.Point(83, 73)
        Me.txtCaliTime.Name = "txtCaliTime"
        Me.txtCaliTime.Size = New System.Drawing.Size(56, 21)
        Me.txtCaliTime.TabIndex = 1
        Me.txtCaliTime.Text = "10"
        '
        'txtEndTilt
        '
        Me.txtEndTilt.Location = New System.Drawing.Point(83, 45)
        Me.txtEndTilt.Name = "txtEndTilt"
        Me.txtEndTilt.Size = New System.Drawing.Size(56, 21)
        Me.txtEndTilt.TabIndex = 1
        Me.txtEndTilt.Text = "60"
        '
        'txtStartTilt
        '
        Me.txtStartTilt.Location = New System.Drawing.Point(83, 17)
        Me.txtStartTilt.Name = "txtStartTilt"
        Me.txtStartTilt.Size = New System.Drawing.Size(56, 21)
        Me.txtStartTilt.TabIndex = 1
        Me.txtStartTilt.Text = "-60"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(143, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 12)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "S"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "DEG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DEG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Calibration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "EndTilt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "StartTilt"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox11)
        Me.GroupBox3.Controls.Add(Me.GroupBox10)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox8)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.chkDaq2005Enable)
        Me.GroupBox3.Location = New System.Drawing.Point(213, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(513, 316)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 210)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(495, 100)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "NOTE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(335, 72)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.txtFileToSave)
        Me.GroupBox11.Location = New System.Drawing.Point(9, 155)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(495, 51)
        Me.GroupBox11.TabIndex = 10
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "FileToSave(*.xls|*.xlsx)"
        '
        'txtFileToSave
        '
        Me.txtFileToSave.Location = New System.Drawing.Point(3, 20)
        Me.txtFileToSave.Name = "txtFileToSave"
        Me.txtFileToSave.Size = New System.Drawing.Size(486, 21)
        Me.txtFileToSave.TabIndex = 0
        Me.txtFileToSave.Text = "ADLinkDaq"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.ChkCH_4)
        Me.GroupBox10.Controls.Add(Me.ChkCH_3)
        Me.GroupBox10.Controls.Add(Me.ChkCH_2)
        Me.GroupBox10.Controls.Add(Me.ChkCH_1)
        Me.GroupBox10.Controls.Add(Me.txtxlsHeaderCH_4)
        Me.GroupBox10.Controls.Add(Me.txtxlsHeaderCH_3)
        Me.GroupBox10.Controls.Add(Me.txtxlsHeaderCH_2)
        Me.GroupBox10.Controls.Add(Me.txtxlsHeaderCH_1)
        Me.GroupBox10.Location = New System.Drawing.Point(157, 22)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(116, 127)
        Me.GroupBox10.TabIndex = 9
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Header&&Chart"
        '
        'ChkCH_4
        '
        Me.ChkCH_4.AutoSize = True
        Me.ChkCH_4.Location = New System.Drawing.Point(9, 103)
        Me.ChkCH_4.Name = "ChkCH_4"
        Me.ChkCH_4.Size = New System.Drawing.Size(15, 14)
        Me.ChkCH_4.TabIndex = 1
        Me.ChkCH_4.UseVisualStyleBackColor = True
        '
        'ChkCH_3
        '
        Me.ChkCH_3.AutoSize = True
        Me.ChkCH_3.Location = New System.Drawing.Point(9, 78)
        Me.ChkCH_3.Name = "ChkCH_3"
        Me.ChkCH_3.Size = New System.Drawing.Size(15, 14)
        Me.ChkCH_3.TabIndex = 1
        Me.ChkCH_3.UseVisualStyleBackColor = True
        '
        'ChkCH_2
        '
        Me.ChkCH_2.AutoSize = True
        Me.ChkCH_2.Location = New System.Drawing.Point(9, 50)
        Me.ChkCH_2.Name = "ChkCH_2"
        Me.ChkCH_2.Size = New System.Drawing.Size(15, 14)
        Me.ChkCH_2.TabIndex = 1
        Me.ChkCH_2.UseVisualStyleBackColor = True
        '
        'ChkCH_1
        '
        Me.ChkCH_1.AutoSize = True
        Me.ChkCH_1.Checked = True
        Me.ChkCH_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCH_1.Location = New System.Drawing.Point(9, 23)
        Me.ChkCH_1.Name = "ChkCH_1"
        Me.ChkCH_1.Size = New System.Drawing.Size(15, 14)
        Me.ChkCH_1.TabIndex = 1
        Me.ChkCH_1.UseVisualStyleBackColor = True
        '
        'txtxlsHeaderCH_4
        '
        Me.txtxlsHeaderCH_4.Location = New System.Drawing.Point(30, 100)
        Me.txtxlsHeaderCH_4.Name = "txtxlsHeaderCH_4"
        Me.txtxlsHeaderCH_4.Size = New System.Drawing.Size(80, 21)
        Me.txtxlsHeaderCH_4.TabIndex = 0
        Me.txtxlsHeaderCH_4.Text = "CH_4"
        '
        'txtxlsHeaderCH_3
        '
        Me.txtxlsHeaderCH_3.Location = New System.Drawing.Point(30, 74)
        Me.txtxlsHeaderCH_3.Name = "txtxlsHeaderCH_3"
        Me.txtxlsHeaderCH_3.Size = New System.Drawing.Size(80, 21)
        Me.txtxlsHeaderCH_3.TabIndex = 0
        Me.txtxlsHeaderCH_3.Text = "CH_3"
        '
        'txtxlsHeaderCH_2
        '
        Me.txtxlsHeaderCH_2.Location = New System.Drawing.Point(30, 47)
        Me.txtxlsHeaderCH_2.Name = "txtxlsHeaderCH_2"
        Me.txtxlsHeaderCH_2.Size = New System.Drawing.Size(80, 21)
        Me.txtxlsHeaderCH_2.TabIndex = 0
        Me.txtxlsHeaderCH_2.Text = "CH_2"
        '
        'txtxlsHeaderCH_1
        '
        Me.txtxlsHeaderCH_1.Location = New System.Drawing.Point(30, 20)
        Me.txtxlsHeaderCH_1.Name = "txtxlsHeaderCH_1"
        Me.txtxlsHeaderCH_1.Size = New System.Drawing.Size(80, 21)
        Me.txtxlsHeaderCH_1.TabIndex = 0
        Me.txtxlsHeaderCH_1.Text = "CH_1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtExpCondition)
        Me.GroupBox4.Location = New System.Drawing.Point(279, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(225, 127)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Experimental conditions"
        '
        'txtExpCondition
        '
        Me.txtExpCondition.Location = New System.Drawing.Point(6, 20)
        Me.txtExpCondition.Multiline = True
        Me.txtExpCondition.Name = "txtExpCondition"
        Me.txtExpCondition.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtExpCondition.Size = New System.Drawing.Size(213, 97)
        Me.txtExpCondition.TabIndex = 0
        Me.txtExpCondition.Text = "here experimental conditions content will paste in excel file at cell(""W1"")"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cboDataSize)
        Me.GroupBox8.Location = New System.Drawing.Point(7, 107)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(144, 42)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Data Size:"
        '
        'cboDataSize
        '
        Me.cboDataSize.FormattingEnabled = True
        Me.cboDataSize.Items.AddRange(New Object() {"2000", "4000", "8000", "20000", "40000", "80000"})
        Me.cboDataSize.Location = New System.Drawing.Point(6, 18)
        Me.cboDataSize.Name = "cboDataSize"
        Me.cboDataSize.Size = New System.Drawing.Size(131, 20)
        Me.cboDataSize.TabIndex = 2
        Me.cboDataSize.Text = "1000"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cboScanInterval)
        Me.GroupBox7.Controls.Add(Me.lblScanRate)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(145, 79)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Scan Intervals:"
        '
        'cboScanInterval
        '
        Me.cboScanInterval.FormattingEnabled = True
        Me.cboScanInterval.Items.AddRange(New Object() {"80", "100", "160", "200", "400", "800", "1000"})
        Me.cboScanInterval.Location = New System.Drawing.Point(6, 15)
        Me.cboScanInterval.Name = "cboScanInterval"
        Me.cboScanInterval.Size = New System.Drawing.Size(131, 20)
        Me.cboScanInterval.TabIndex = 2
        Me.cboScanInterval.Text = "200"
        '
        'lblScanRate
        '
        Me.lblScanRate.AutoSize = True
        Me.lblScanRate.Location = New System.Drawing.Point(6, 38)
        Me.lblScanRate.Name = "lblScanRate"
        Me.lblScanRate.Size = New System.Drawing.Size(125, 36)
        Me.lblScanRate.TabIndex = 1
        Me.lblScanRate.Text = "Scan rate(200000) = " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Timebase(40,000,000)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/Scan interval(200)"
        '
        'chkDaq2005Enable
        '
        Me.chkDaq2005Enable.AutoSize = True
        Me.chkDaq2005Enable.Location = New System.Drawing.Point(6, 0)
        Me.chkDaq2005Enable.Name = "chkDaq2005Enable"
        Me.chkDaq2005Enable.Size = New System.Drawing.Size(102, 16)
        Me.chkDaq2005Enable.TabIndex = 1
        Me.chkDaq2005Enable.Text = "Daq2005Enable"
        Me.chkDaq2005Enable.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(303, 368)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(121, 43)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(17, 368)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(121, 43)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(589, 368)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(121, 43)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 426)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(730, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslStatus
        '
        Me.tsslStatus.ForeColor = System.Drawing.Color.Blue
        Me.tsslStatus.LinkColor = System.Drawing.Color.Blue
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(131, 17)
        Me.tsslStatus.Text = "ToolStripStatusLabel1"
        '
        'tm
        '
        '
        'RotatePosModeCfg1
        '
        Me.RotatePosModeCfg1.IsRotatePosMode = True
        Me.RotatePosModeCfg1.Location = New System.Drawing.Point(6, 20)
        Me.RotatePosModeCfg1.Name = "RotatePosModeCfg1"
        Me.RotatePosModeCfg1.RCurSpeed = 0R
        Me.RotatePosModeCfg1.RDelayTime = 0R
        Me.RotatePosModeCfg1.RDist = 1.0R
        Me.RotatePosModeCfg1.RMaxVel = 1.0R
        Me.RotatePosModeCfg1.RStrVel = 0R
        Me.RotatePosModeCfg1.RTacc = 0.1R
        Me.RotatePosModeCfg1.RTdec = 0.1R
        Me.RotatePosModeCfg1.Size = New System.Drawing.Size(191, 186)
        Me.RotatePosModeCfg1.TabIndex = 0
        '
        'TiltStepPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TiltStepPanel"
        Me.Size = New System.Drawing.Size(730, 448)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RotatePosModeCfg1 As RotatePosModeCfg
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCaliTime As TextBox
    Friend WithEvents txtEndTilt As TextBox
    Friend WithEvents txtStartTilt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Private WithEvents chkDaq2005Enable As CheckBox
    Private WithEvents GroupBox8 As GroupBox
    Private WithEvents cboDataSize As ComboBox
    Private WithEvents GroupBox7 As GroupBox
    Private WithEvents cboScanInterval As ComboBox
    Private WithEvents lblScanRate As Label
    Private WithEvents GroupBox4 As GroupBox
    Private WithEvents txtExpCondition As TextBox
    Private WithEvents GroupBox10 As GroupBox
    Private WithEvents ChkCH_4 As CheckBox
    Private WithEvents ChkCH_3 As CheckBox
    Private WithEvents ChkCH_2 As CheckBox
    Private WithEvents ChkCH_1 As CheckBox
    Private WithEvents txtxlsHeaderCH_4 As TextBox
    Private WithEvents txtxlsHeaderCH_3 As TextBox
    Private WithEvents txtxlsHeaderCH_2 As TextBox
    Private WithEvents txtxlsHeaderCH_1 As TextBox
    Private WithEvents GroupBox11 As GroupBox
    Private WithEvents txtFileToSave As TextBox
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslStatus As ToolStripStatusLabel
    Friend WithEvents tm As Timer
End Class
