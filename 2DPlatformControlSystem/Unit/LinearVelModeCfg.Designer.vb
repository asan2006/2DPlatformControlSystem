<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinearVelModeCfg
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkLMode = New System.Windows.Forms.CheckBox()
        Me.txtLDecTime = New System.Windows.Forms.TextBox()
        Me.txtLUnifTime = New System.Windows.Forms.TextBox()
        Me.txtLCurSpeed = New System.Windows.Forms.TextBox()
        Me.txtLMaxSpeed = New System.Windows.Forms.TextBox()
        Me.txtLDelayTime = New System.Windows.Forms.TextBox()
        Me.txtLAccTime = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.chkLMode)
        Me.GroupBox2.Controls.Add(Me.txtLDecTime)
        Me.GroupBox2.Controls.Add(Me.txtLUnifTime)
        Me.GroupBox2.Controls.Add(Me.txtLCurSpeed)
        Me.GroupBox2.Controls.Add(Me.txtLMaxSpeed)
        Me.GroupBox2.Controls.Add(Me.txtLDelayTime)
        Me.GroupBox2.Controls.Add(Me.txtLAccTime)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 194)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Linear Velocity Mode"
        '
        'chkLMode
        '
        Me.chkLMode.AutoSize = True
        Me.chkLMode.Location = New System.Drawing.Point(7, 0)
        Me.chkLMode.Name = "chkLMode"
        Me.chkLMode.Size = New System.Drawing.Size(144, 16)
        Me.chkLMode.TabIndex = 8
        Me.chkLMode.Text = "Linear Velocity Mode"
        Me.chkLMode.UseVisualStyleBackColor = True
        '
        'txtLDecTime
        '
        Me.txtLDecTime.Location = New System.Drawing.Point(68, 74)
        Me.txtLDecTime.Name = "txtLDecTime"
        Me.txtLDecTime.Size = New System.Drawing.Size(72, 21)
        Me.txtLDecTime.TabIndex = 5
        Me.txtLDecTime.Text = "0.2"
        '
        'txtLUnifTime
        '
        Me.txtLUnifTime.Location = New System.Drawing.Point(68, 126)
        Me.txtLUnifTime.Name = "txtLUnifTime"
        Me.txtLUnifTime.Size = New System.Drawing.Size(72, 21)
        Me.txtLUnifTime.TabIndex = 5
        Me.txtLUnifTime.Text = "0.2"
        '
        'txtLCurSpeed
        '
        Me.txtLCurSpeed.Location = New System.Drawing.Point(68, 153)
        Me.txtLCurSpeed.Name = "txtLCurSpeed"
        Me.txtLCurSpeed.ReadOnly = True
        Me.txtLCurSpeed.Size = New System.Drawing.Size(72, 21)
        Me.txtLCurSpeed.TabIndex = 1
        Me.txtLCurSpeed.Text = "0"
        '
        'txtLMaxSpeed
        '
        Me.txtLMaxSpeed.Location = New System.Drawing.Point(68, 99)
        Me.txtLMaxSpeed.Name = "txtLMaxSpeed"
        Me.txtLMaxSpeed.Size = New System.Drawing.Size(72, 21)
        Me.txtLMaxSpeed.TabIndex = 4
        Me.txtLMaxSpeed.Text = "60"
        '
        'txtLDelayTime
        '
        Me.txtLDelayTime.Location = New System.Drawing.Point(68, 22)
        Me.txtLDelayTime.Name = "txtLDelayTime"
        Me.txtLDelayTime.Size = New System.Drawing.Size(72, 21)
        Me.txtLDelayTime.TabIndex = 1
        Me.txtLDelayTime.Text = "1"
        '
        'txtLAccTime
        '
        Me.txtLAccTime.Location = New System.Drawing.Point(68, 47)
        Me.txtLAccTime.Name = "txtLAccTime"
        Me.txtLAccTime.Size = New System.Drawing.Size(72, 21)
        Me.txtLAccTime.TabIndex = 1
        Me.txtLAccTime.Text = "0.1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(140, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "S"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CurLSpeed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "UnifTime"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(140, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "MM/S"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MaxSpeed"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(140, 76)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(11, 12)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "S"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(140, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 12)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "S"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 12)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "S"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 76)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 12)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "DecTime"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 12)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "delayTime"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AccTime"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MM/S"
        '
        'LinearVelModeCfg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "LinearVelModeCfg"
        Me.Size = New System.Drawing.Size(189, 194)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txtLDelayTime As TextBox
    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents chkLMode As CheckBox
    Private WithEvents txtLDecTime As TextBox
    Private WithEvents txtLUnifTime As TextBox
    Private WithEvents txtLCurSpeed As TextBox
    Private WithEvents txtLMaxSpeed As TextBox
    Private WithEvents txtLAccTime As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label21 As Label
    Private WithEvents Label16 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label7 As Label
    Private WithEvents Label8 As Label
    Private WithEvents Label22 As Label
    Private WithEvents Label20 As Label
    Private WithEvents Label6 As Label
    Private WithEvents Label1 As Label
End Class
