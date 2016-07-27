<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrdControlPanel
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinearVelModeCfg1 = New _2DPlatformControlSystem.LinearVelModeCfg()
        Me.RotatePosModeCfg1 = New _2DPlatformControlSystem.RotatePosModeCfg()
        Me.btnMotion = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.tm = New System.Windows.Forms.Timer(Me.components)
        Me.DaqCfg1 = New _2DPlatformControlSystem.DaqCfg()
        Me.LoadCfgFile1 = New _2DPlatformControlSystem.LoadCfgFile()
        Me.PositionStatus1 = New _2DPlatformControlSystem.PositionStatus()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.LinearVelModeCfg1)
        Me.GroupBox1.Controls.Add(Me.RotatePosModeCfg1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 220)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONFIGURE"
        '
        'LinearVelModeCfg1
        '
        Me.LinearVelModeCfg1.IsLinearVelMode = False
        Me.LinearVelModeCfg1.LCurSpeed = 0R
        Me.LinearVelModeCfg1.LDelayTime = 1.0R
        Me.LinearVelModeCfg1.LMaxVel = 60.0R
        Me.LinearVelModeCfg1.Location = New System.Drawing.Point(6, 20)
        Me.LinearVelModeCfg1.LStrVel = 0R
        Me.LinearVelModeCfg1.LTacc = 0.1R
        Me.LinearVelModeCfg1.LTdec = 0.2R
        Me.LinearVelModeCfg1.LTunif = 0.2R
        Me.LinearVelModeCfg1.Name = "LinearVelModeCfg1"
        Me.LinearVelModeCfg1.Size = New System.Drawing.Size(183, 182)
        Me.LinearVelModeCfg1.TabIndex = 0
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
        'btnMotion
        '
        Me.btnMotion.Location = New System.Drawing.Point(47, 465)
        Me.btnMotion.Name = "btnMotion"
        Me.btnMotion.Size = New System.Drawing.Size(121, 43)
        Me.btnMotion.TabIndex = 4
        Me.btnMotion.Text = "Motion"
        Me.btnMotion.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(405, 465)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(121, 43)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(763, 465)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(121, 43)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'tm
        '
        Me.tm.Interval = 50
        '
        'DaqCfg1
        '
        Me.DaqCfg1.ADChanCount = 4
        Me.DaqCfg1.aveNum = 1
        Me.DaqCfg1.expInfo = "here experimental conditions content will paste in excel file at cell(""W1"")"
        Me.DaqCfg1.fileName = "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\ADLinkDaq"
        Me.DaqCfg1.IsDaqEnable = False
        Me.DaqCfg1.Location = New System.Drawing.Point(405, 3)
        Me.DaqCfg1.Name = "DaqCfg1"
        Me.DaqCfg1.ScanCount = 100000
        Me.DaqCfg1.scanFileFormatMode = "XLS"
        Me.DaqCfg1.ScanIntrv = 200
        Me.DaqCfg1.Size = New System.Drawing.Size(511, 220)
        Me.DaqCfg1.TabIndex = 6
        Me.DaqCfg1.xlsHeader = New String() {"CH_1", "CH_2", "CH_3", "CH_4"}
        '
        'LoadCfgFile1
        '
        Me.LoadCfgFile1.Location = New System.Drawing.Point(405, 229)
        Me.LoadCfgFile1.Name = "LoadCfgFile1"
        Me.LoadCfgFile1.Size = New System.Drawing.Size(511, 73)
        Me.LoadCfgFile1.TabIndex = 5
        '
        'PositionStatus1
        '
        Me.PositionStatus1.Location = New System.Drawing.Point(3, 229)
        Me.PositionStatus1.Name = "PositionStatus1"
        Me.PositionStatus1.Size = New System.Drawing.Size(397, 203)
        Me.PositionStatus1.TabIndex = 7
        '
        'TrdControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PositionStatus1)
        Me.Controls.Add(Me.DaqCfg1)
        Me.Controls.Add(Me.LoadCfgFile1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnMotion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TrdControlPanel"
        Me.Size = New System.Drawing.Size(922, 541)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LinearVelModeCfg1 As LinearVelModeCfg
    Friend WithEvents RotatePosModeCfg1 As RotatePosModeCfg
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnMotion As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents LoadCfgFile1 As LoadCfgFile
    Friend WithEvents DaqCfg1 As DaqCfg
    Friend WithEvents tm As Timer
    Friend WithEvents PositionStatus1 As PositionStatus
End Class
