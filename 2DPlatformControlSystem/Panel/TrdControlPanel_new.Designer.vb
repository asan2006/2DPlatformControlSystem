<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrdControlPanel_new
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnMotion = New System.Windows.Forms.Button()
        Me.tm = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinearPosModeCfg1 = New _2DPlatformControlSystem.LinearPosModeCfg()
        Me.RotatePosModeCfg1 = New _2DPlatformControlSystem.RotatePosModeCfg()
        Me.PositionStatus1 = New _2DPlatformControlSystem.PositionStatus()
        Me.LoadCfgFile1 = New _2DPlatformControlSystem.LoadCfgFile()
        Me.SerialPort_Robin1 = New _2DPlatformControlSystem.SerialPort_Robin()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(763, 465)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(121, 43)
        Me.btnQuit.TabIndex = 10
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(405, 465)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(121, 43)
        Me.btnStop.TabIndex = 11
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnMotion
        '
        Me.btnMotion.Location = New System.Drawing.Point(47, 465)
        Me.btnMotion.Name = "btnMotion"
        Me.btnMotion.Size = New System.Drawing.Size(121, 43)
        Me.btnMotion.TabIndex = 12
        Me.btnMotion.Text = "Motion"
        Me.btnMotion.UseVisualStyleBackColor = True
        '
        'tm
        '
        Me.tm.Interval = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.LinearPosModeCfg1)
        Me.GroupBox1.Controls.Add(Me.RotatePosModeCfg1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 220)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONFIGURE"
        '
        'LinearPosModeCfg1
        '
        Me.LinearPosModeCfg1.IsLinearPosMode = False
        Me.LinearPosModeCfg1.LCurSpeed = 0R
        Me.LinearPosModeCfg1.LDelayTime = 1.0R
        Me.LinearPosModeCfg1.LDist = 60.0R
        Me.LinearPosModeCfg1.LMaxVel = 60.0R
        Me.LinearPosModeCfg1.Location = New System.Drawing.Point(6, 20)
        Me.LinearPosModeCfg1.LStrVel = 0R
        Me.LinearPosModeCfg1.LTacc = 0.1R
        Me.LinearPosModeCfg1.LTdec = 0.2R
        Me.LinearPosModeCfg1.Name = "LinearPosModeCfg1"
        Me.LinearPosModeCfg1.Size = New System.Drawing.Size(189, 182)
        Me.LinearPosModeCfg1.TabIndex = 2
        '
        'RotatePosModeCfg1
        '
        Me.RotatePosModeCfg1.IsRotatePosMode = False
        Me.RotatePosModeCfg1.Location = New System.Drawing.Point(195, 20)
        Me.RotatePosModeCfg1.Name = "RotatePosModeCfg1"
        Me.RotatePosModeCfg1.RCurSpeed = 0R
        Me.RotatePosModeCfg1.RDelayTime = 0R
        Me.RotatePosModeCfg1.RDist = 60.0R
        Me.RotatePosModeCfg1.RMaxVel = 60.0R
        Me.RotatePosModeCfg1.RStrVel = 0R
        Me.RotatePosModeCfg1.RTacc = 0.1R
        Me.RotatePosModeCfg1.RTdec = 0.1R
        Me.RotatePosModeCfg1.Size = New System.Drawing.Size(191, 182)
        Me.RotatePosModeCfg1.TabIndex = 1
        '
        'PositionStatus1
        '
        Me.PositionStatus1.Location = New System.Drawing.Point(3, 229)
        Me.PositionStatus1.Name = "PositionStatus1"
        Me.PositionStatus1.Size = New System.Drawing.Size(397, 203)
        Me.PositionStatus1.TabIndex = 15
        '
        'LoadCfgFile1
        '
        Me.LoadCfgFile1.Location = New System.Drawing.Point(405, 229)
        Me.LoadCfgFile1.Name = "LoadCfgFile1"
        Me.LoadCfgFile1.Size = New System.Drawing.Size(511, 73)
        Me.LoadCfgFile1.TabIndex = 13
        '
        'SerialPort_Robin1
        '
        Me.SerialPort_Robin1.Location = New System.Drawing.Point(406, 3)
        Me.SerialPort_Robin1.Name = "SerialPort_Robin1"
        Me.SerialPort_Robin1.Size = New System.Drawing.Size(510, 220)
        Me.SerialPort_Robin1.TabIndex = 16
        '
        'TrdControlPanel_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SerialPort_Robin1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnMotion)
        Me.Controls.Add(Me.PositionStatus1)
        Me.Controls.Add(Me.LoadCfgFile1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TrdControlPanel_new"
        Me.Size = New System.Drawing.Size(922, 541)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RotatePosModeCfg1 As RotatePosModeCfg
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnMotion As Button
    Friend WithEvents tm As Timer
    Friend WithEvents PositionStatus1 As PositionStatus
    Friend WithEvents LoadCfgFile1 As LoadCfgFile
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LinearPosModeCfg1 As LinearPosModeCfg
    Friend WithEvents SerialPort_Robin1 As SerialPort_Robin
End Class
