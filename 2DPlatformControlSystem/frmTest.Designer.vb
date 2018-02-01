<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.btnSTART = New System.Windows.Forms.Button()
        Me.SerialPort_Robin1 = New _2DPlatformControlSystem.SerialPort_Robin()
        Me.btnEND = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSTART
        '
        Me.btnSTART.Location = New System.Drawing.Point(128, 226)
        Me.btnSTART.Name = "btnSTART"
        Me.btnSTART.Size = New System.Drawing.Size(75, 23)
        Me.btnSTART.TabIndex = 1
        Me.btnSTART.Text = "START"
        Me.btnSTART.UseVisualStyleBackColor = True
        '
        'SerialPort_Robin1
        '
        Me.SerialPort_Robin1.Location = New System.Drawing.Point(37, 23)
        Me.SerialPort_Robin1.Name = "SerialPort_Robin1"
        Me.SerialPort_Robin1.Size = New System.Drawing.Size(583, 237)
        Me.SerialPort_Robin1.TabIndex = 0
        '
        'btnEND
        '
        Me.btnEND.Location = New System.Drawing.Point(303, 226)
        Me.btnEND.Name = "btnEND"
        Me.btnEND.Size = New System.Drawing.Size(75, 23)
        Me.btnEND.TabIndex = 1
        Me.btnEND.Text = "END"
        Me.btnEND.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 381)
        Me.Controls.Add(Me.btnEND)
        Me.Controls.Add(Me.btnSTART)
        Me.Controls.Add(Me.SerialPort_Robin1)
        Me.Name = "frmTest"
        Me.Text = "frmTest"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort_Robin1 As SerialPort_Robin
    Friend WithEvents btnSTART As Button
    Friend WithEvents btnEND As Button
End Class
