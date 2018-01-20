<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContinueMotion
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.RotatePosModeCfg1 = New _2DPlatformControlSystem.RotatePosModeCfg()
        Me.LinearPosModeCfg1 = New _2DPlatformControlSystem.LinearPosModeCfg()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(82, 212)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(199, 43)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'RotatePosModeCfg1
        '
        Me.RotatePosModeCfg1.IsRotatePosMode = False
        Me.RotatePosModeCfg1.Location = New System.Drawing.Point(197, 12)
        Me.RotatePosModeCfg1.Name = "RotatePosModeCfg1"
        Me.RotatePosModeCfg1.RCurSpeed = 0R
        Me.RotatePosModeCfg1.RDelayTime = 0R
        Me.RotatePosModeCfg1.RDist = 60.0R
        Me.RotatePosModeCfg1.RMaxVel = 60.0R
        Me.RotatePosModeCfg1.RStrVel = 0R
        Me.RotatePosModeCfg1.RTacc = 0.1R
        Me.RotatePosModeCfg1.RTdec = 0.1R
        Me.RotatePosModeCfg1.Size = New System.Drawing.Size(191, 194)
        Me.RotatePosModeCfg1.TabIndex = 1
        '
        'LinearPosModeCfg1
        '
        Me.LinearPosModeCfg1.IsLinearPosMode = False
        Me.LinearPosModeCfg1.LCurSpeed = 0R
        Me.LinearPosModeCfg1.LDelayTime = 1.0R
        Me.LinearPosModeCfg1.LDist = 60.0R
        Me.LinearPosModeCfg1.LMaxVel = 60.0R
        Me.LinearPosModeCfg1.Location = New System.Drawing.Point(2, 12)
        Me.LinearPosModeCfg1.LStrVel = 0R
        Me.LinearPosModeCfg1.LTacc = 0.1R
        Me.LinearPosModeCfg1.LTdec = 0.2R
        Me.LinearPosModeCfg1.Name = "LinearPosModeCfg1"
        Me.LinearPosModeCfg1.Size = New System.Drawing.Size(189, 194)
        Me.LinearPosModeCfg1.TabIndex = 0
        '
        'frmContinueMotion
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 259)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.RotatePosModeCfg1)
        Me.Controls.Add(Me.LinearPosModeCfg1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContinueMotion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ContinueMotionConfigure"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LinearPosModeCfg1 As LinearPosModeCfg
    Friend WithEvents RotatePosModeCfg1 As RotatePosModeCfg
    Friend WithEvents btnSave As Button
End Class
