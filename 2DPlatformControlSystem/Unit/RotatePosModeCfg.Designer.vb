<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RotatePosModeCfg
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkRMode = New System.Windows.Forms.CheckBox()
        Me.txtRDecTime = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRDist = New System.Windows.Forms.TextBox()
        Me.txtRCurSpeed = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtRMaxSpeed = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtRDelayTime = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtRAccTime = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.chkRMode)
        Me.GroupBox3.Controls.Add(Me.txtRDecTime)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtRDist)
        Me.GroupBox3.Controls.Add(Me.txtRCurSpeed)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtRMaxSpeed)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txtRDelayTime)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.txtRAccTime)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(191, 194)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rotation Position Mode"
        '
        'chkRMode
        '
        Me.chkRMode.AutoSize = True
        Me.chkRMode.Location = New System.Drawing.Point(8, -1)
        Me.chkRMode.Name = "chkRMode"
        Me.chkRMode.Size = New System.Drawing.Size(156, 16)
        Me.chkRMode.TabIndex = 8
        Me.chkRMode.Text = "Rotation Position Mode"
        Me.chkRMode.UseVisualStyleBackColor = True
        '
        'txtRDecTime
        '
        Me.txtRDecTime.Location = New System.Drawing.Point(68, 74)
        Me.txtRDecTime.Name = "txtRDecTime"
        Me.txtRDecTime.Size = New System.Drawing.Size(72, 21)
        Me.txtRDecTime.TabIndex = 5
        Me.txtRDecTime.Text = "0.1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 12)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "CurRSpeed"
        '
        'txtRDist
        '
        Me.txtRDist.Location = New System.Drawing.Point(68, 127)
        Me.txtRDist.Name = "txtRDist"
        Me.txtRDist.Size = New System.Drawing.Size(72, 21)
        Me.txtRDist.TabIndex = 5
        Me.txtRDist.Text = "60"
        '
        'txtRCurSpeed
        '
        Me.txtRCurSpeed.Location = New System.Drawing.Point(68, 152)
        Me.txtRCurSpeed.Name = "txtRCurSpeed"
        Me.txtRCurSpeed.ReadOnly = True
        Me.txtRCurSpeed.Size = New System.Drawing.Size(72, 21)
        Me.txtRCurSpeed.TabIndex = 1
        Me.txtRCurSpeed.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 12)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "delayTime"
        '
        'txtRMaxSpeed
        '
        Me.txtRMaxSpeed.Location = New System.Drawing.Point(68, 100)
        Me.txtRMaxSpeed.Name = "txtRMaxSpeed"
        Me.txtRMaxSpeed.Size = New System.Drawing.Size(72, 21)
        Me.txtRMaxSpeed.TabIndex = 4
        Me.txtRMaxSpeed.Text = "60"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(5, 51)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 12)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "AccTime"
        '
        'txtRDelayTime
        '
        Me.txtRDelayTime.Location = New System.Drawing.Point(68, 23)
        Me.txtRDelayTime.Name = "txtRDelayTime"
        Me.txtRDelayTime.ReadOnly = True
        Me.txtRDelayTime.Size = New System.Drawing.Size(72, 21)
        Me.txtRDelayTime.TabIndex = 1
        Me.txtRDelayTime.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(5, 77)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 12)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "DecTime"
        '
        'txtRAccTime
        '
        Me.txtRAccTime.Location = New System.Drawing.Point(68, 48)
        Me.txtRAccTime.Name = "txtRAccTime"
        Me.txtRAccTime.Size = New System.Drawing.Size(72, 21)
        Me.txtRAccTime.TabIndex = 1
        Me.txtRAccTime.Text = "0.1"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(139, 51)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 12)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "S"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(139, 130)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(23, 12)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "DEG"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(139, 28)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(11, 12)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "S"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(139, 77)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(11, 12)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "S"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 130)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 12)
        Me.Label31.TabIndex = 6
        Me.Label31.Text = "Distance"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 103)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(53, 12)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "MaxSpeed"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(139, 103)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(35, 12)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "DEG/S"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DEG/S"
        '
        'RotatePosModeCfg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "RotatePosModeCfg"
        Me.Size = New System.Drawing.Size(191, 194)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents chkRMode As CheckBox
    Private WithEvents txtRDecTime As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents txtRDist As TextBox
    Private WithEvents txtRCurSpeed As TextBox
    Private WithEvents Label24 As Label
    Private WithEvents txtRMaxSpeed As TextBox
    Private WithEvents Label23 As Label
    Private WithEvents txtRDelayTime As TextBox
    Private WithEvents Label25 As Label
    Private WithEvents txtRAccTime As TextBox
    Private WithEvents Label26 As Label
    Private WithEvents Label32 As Label
    Private WithEvents Label27 As Label
    Private WithEvents Label28 As Label
    Private WithEvents Label31 As Label
    Private WithEvents Label29 As Label
    Private WithEvents Label30 As Label
    Private WithEvents Label1 As Label
End Class
