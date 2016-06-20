<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaqCfg
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.rdXLS = New System.Windows.Forms.RadioButton()
        Me.txtFileToSave = New System.Windows.Forms.TextBox()
        Me.rdDAT = New System.Windows.Forms.RadioButton()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.ChkCH_4 = New System.Windows.Forms.CheckBox()
        Me.ChkCH_3 = New System.Windows.Forms.CheckBox()
        Me.ChkCH_2 = New System.Windows.Forms.CheckBox()
        Me.ChkCH_1 = New System.Windows.Forms.CheckBox()
        Me.txtxlsHeaderCH_4 = New System.Windows.Forms.TextBox()
        Me.txtxlsHeaderCH_3 = New System.Windows.Forms.TextBox()
        Me.txtxlsHeaderCH_2 = New System.Windows.Forms.TextBox()
        Me.txtxlsHeaderCH_1 = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboNumOfAve = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cboDataSize = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtExpCondition = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cboScanInterval = New System.Windows.Forms.ComboBox()
        Me.lblScanRate = New System.Windows.Forms.Label()
        Me.chkDaq2005Enable = New System.Windows.Forms.CheckBox()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.GroupBox11)
        Me.GroupBox6.Controls.Add(Me.GroupBox10)
        Me.GroupBox6.Controls.Add(Me.GroupBox9)
        Me.GroupBox6.Controls.Add(Me.GroupBox8)
        Me.GroupBox6.Controls.Add(Me.GroupBox4)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.chkDaq2005Enable)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(511, 225)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.rdXLS)
        Me.GroupBox11.Controls.Add(Me.txtFileToSave)
        Me.GroupBox11.Controls.Add(Me.rdDAT)
        Me.GroupBox11.Location = New System.Drawing.Point(157, 159)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(347, 53)
        Me.GroupBox11.TabIndex = 7
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "FileToSave"
        '
        'rdXLS
        '
        Me.rdXLS.AutoSize = True
        Me.rdXLS.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.rdXLS.Checked = True
        Me.rdXLS.Location = New System.Drawing.Point(178, 0)
        Me.rdXLS.Name = "rdXLS"
        Me.rdXLS.Size = New System.Drawing.Size(131, 16)
        Me.rdXLS.TabIndex = 9
        Me.rdXLS.TabStop = True
        Me.rdXLS.Text = "*.dat&&*.xls|*.xlsx"
        Me.rdXLS.UseVisualStyleBackColor = True
        '
        'txtFileToSave
        '
        Me.txtFileToSave.Location = New System.Drawing.Point(6, 27)
        Me.txtFileToSave.Name = "txtFileToSave"
        Me.txtFileToSave.Size = New System.Drawing.Size(335, 21)
        Me.txtFileToSave.TabIndex = 0
        Me.txtFileToSave.Text = "ADLinkDaq"
        '
        'rdDAT
        '
        Me.rdDAT.AutoSize = True
        Me.rdDAT.Location = New System.Drawing.Point(119, 0)
        Me.rdDAT.Name = "rdDAT"
        Me.rdDAT.Size = New System.Drawing.Size(53, 16)
        Me.rdDAT.TabIndex = 8
        Me.rdDAT.Text = "*.dat"
        Me.rdDAT.UseVisualStyleBackColor = True
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
        Me.GroupBox10.TabIndex = 6
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
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label13)
        Me.GroupBox9.Controls.Add(Me.cboNumOfAve)
        Me.GroupBox9.Location = New System.Drawing.Point(7, 155)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(144, 57)
        Me.GroupBox9.TabIndex = 4
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Num Of Ave:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 12)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "(default is 1)"
        '
        'cboNumOfAve
        '
        Me.cboNumOfAve.FormattingEnabled = True
        Me.cboNumOfAve.Items.AddRange(New Object() {"1", "50", "100", "200"})
        Me.cboNumOfAve.Location = New System.Drawing.Point(5, 32)
        Me.cboNumOfAve.Name = "cboNumOfAve"
        Me.cboNumOfAve.Size = New System.Drawing.Size(132, 20)
        Me.cboNumOfAve.TabIndex = 0
        Me.cboNumOfAve.Text = "1"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cboDataSize)
        Me.GroupBox8.Location = New System.Drawing.Point(7, 107)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(144, 42)
        Me.GroupBox8.TabIndex = 5
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
        Me.cboDataSize.Text = "100000"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtExpCondition)
        Me.GroupBox4.Location = New System.Drawing.Point(279, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(225, 127)
        Me.GroupBox4.TabIndex = 2
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
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cboScanInterval)
        Me.GroupBox7.Controls.Add(Me.lblScanRate)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(145, 79)
        Me.GroupBox7.TabIndex = 4
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
        Me.chkDaq2005Enable.Location = New System.Drawing.Point(7, 0)
        Me.chkDaq2005Enable.Name = "chkDaq2005Enable"
        Me.chkDaq2005Enable.Size = New System.Drawing.Size(102, 16)
        Me.chkDaq2005Enable.TabIndex = 0
        Me.chkDaq2005Enable.Text = "Daq2005Enable"
        Me.chkDaq2005Enable.UseVisualStyleBackColor = True
        '
        'DaqAcqCfg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "DaqAcqCfg"
        Me.Size = New System.Drawing.Size(511, 225)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GroupBox6 As GroupBox
    Private WithEvents GroupBox11 As GroupBox
    Private WithEvents rdXLS As RadioButton
    Private WithEvents txtFileToSave As TextBox
    Private WithEvents rdDAT As RadioButton
    Private WithEvents GroupBox10 As GroupBox
    Private WithEvents ChkCH_4 As CheckBox
    Private WithEvents ChkCH_3 As CheckBox
    Private WithEvents ChkCH_2 As CheckBox
    Private WithEvents ChkCH_1 As CheckBox
    Private WithEvents txtxlsHeaderCH_4 As TextBox
    Private WithEvents txtxlsHeaderCH_3 As TextBox
    Private WithEvents txtxlsHeaderCH_2 As TextBox
    Private WithEvents txtxlsHeaderCH_1 As TextBox
    Private WithEvents GroupBox9 As GroupBox
    Private WithEvents Label13 As Label
    Private WithEvents cboNumOfAve As ComboBox
    Private WithEvents GroupBox8 As GroupBox
    Private WithEvents cboDataSize As ComboBox
    Private WithEvents GroupBox4 As GroupBox
    Private WithEvents txtExpCondition As TextBox
    Private WithEvents GroupBox7 As GroupBox
    Private WithEvents cboScanInterval As ComboBox
    Private WithEvents lblScanRate As Label
    Private WithEvents chkDaq2005Enable As CheckBox
End Class
