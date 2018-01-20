<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSerialTest
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Me.tbTrdControl = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TrdControlPanel_new1 = New _2DPlatformControlSystem.TrdControlPanel_new()
        Me.tbTrdControl.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbTrdControl
        '
        Me.tbTrdControl.Controls.Add(Me.TabPage2)
        Me.tbTrdControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTrdControl.Location = New System.Drawing.Point(0, 0)
        Me.tbTrdControl.Name = "tbTrdControl"
        Me.tbTrdControl.SelectedIndex = 0
        Me.tbTrdControl.Size = New System.Drawing.Size(948, 590)
        Me.tbTrdControl.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TrdControlPanel_new1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(940, 564)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TrdControlPanel"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TrdControlPanel_new1
        '
        Me.TrdControlPanel_new1.Location = New System.Drawing.Point(6, 6)
        Me.TrdControlPanel_new1.Name = "TrdControlPanel_new1"
        Me.TrdControlPanel_new1.Size = New System.Drawing.Size(922, 541)
        Me.TrdControlPanel_new1.TabIndex = 0
        '
        'frmSerialTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 590)
        Me.Controls.Add(Me.tbTrdControl)
        Me.Name = "frmSerialTest"
        Me.Text = "frmSerialTest"
        Me.tbTrdControl.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbTrdControl As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TrdControlPanel_new1 As TrdControlPanel_new
End Class
