<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Me.ContinueMotionPanel1 = New _2DPlatformControlSystem.ContinueMotionPanel()
        Me.SuspendLayout()
        '
        'ContinueMotionPanel1
        '
        Me.ContinueMotionPanel1.Location = New System.Drawing.Point(12, 12)
        Me.ContinueMotionPanel1.Name = "ContinueMotionPanel1"
        Me.ContinueMotionPanel1.Size = New System.Drawing.Size(962, 464)
        Me.ContinueMotionPanel1.TabIndex = 0
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 547)
        Me.Controls.Add(Me.ContinueMotionPanel1)
        Me.Name = "TestForm"
        Me.Text = "TestForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContinueMotionPanel1 As ContinueMotionPanel
End Class
