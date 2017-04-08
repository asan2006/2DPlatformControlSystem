<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbTrdControl = New System.Windows.Forms.TabPage()
        Me.tbTrdControl2 = New System.Windows.Forms.TabPage()
        Me.tbTiltStep = New System.Windows.Forms.TabPage()
        Me.tbAbout = New System.Windows.Forms.TabPage()
        Me.TrdControlPanel1 = New _2DPlatformControlSystem.TrdControlPanel()
        Me.TrdControlPanel2 = New _2DPlatformControlSystem.TrdControlPanel2()
        Me.TiltStepPanel1 = New _2DPlatformControlSystem.TiltStepPanel()
        Me.AboutPanel1 = New _2DPlatformControlSystem.AboutPanel()
        Me.TabControl1.SuspendLayout()
        Me.tbTrdControl.SuspendLayout()
        Me.tbTrdControl2.SuspendLayout()
        Me.tbTiltStep.SuspendLayout()
        Me.tbAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbTrdControl)
        Me.TabControl1.Controls.Add(Me.tbTrdControl2)
        Me.TabControl1.Controls.Add(Me.tbTiltStep)
        Me.TabControl1.Controls.Add(Me.tbAbout)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(928, 572)
        Me.TabControl1.TabIndex = 1
        '
        'tbTrdControl
        '
        Me.tbTrdControl.Controls.Add(Me.TrdControlPanel1)
        Me.tbTrdControl.Location = New System.Drawing.Point(4, 22)
        Me.tbTrdControl.Name = "tbTrdControl"
        Me.tbTrdControl.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTrdControl.Size = New System.Drawing.Size(920, 546)
        Me.tbTrdControl.TabIndex = 0
        Me.tbTrdControl.Text = "TrdControl"
        Me.tbTrdControl.UseVisualStyleBackColor = True
        '
        'tbTrdControl2
        '
        Me.tbTrdControl2.Controls.Add(Me.TrdControlPanel2)
        Me.tbTrdControl2.Location = New System.Drawing.Point(4, 22)
        Me.tbTrdControl2.Name = "tbTrdControl2"
        Me.tbTrdControl2.Size = New System.Drawing.Size(920, 546)
        Me.tbTrdControl2.TabIndex = 3
        Me.tbTrdControl2.Text = "TrdControl2"
        Me.tbTrdControl2.UseVisualStyleBackColor = True
        '
        'tbTiltStep
        '
        Me.tbTiltStep.Controls.Add(Me.TiltStepPanel1)
        Me.tbTiltStep.Location = New System.Drawing.Point(4, 22)
        Me.tbTiltStep.Name = "tbTiltStep"
        Me.tbTiltStep.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTiltStep.Size = New System.Drawing.Size(920, 546)
        Me.tbTiltStep.TabIndex = 2
        Me.tbTiltStep.Text = "TiltStep"
        Me.tbTiltStep.UseVisualStyleBackColor = True
        '
        'tbAbout
        '
        Me.tbAbout.Controls.Add(Me.AboutPanel1)
        Me.tbAbout.Location = New System.Drawing.Point(4, 22)
        Me.tbAbout.Name = "tbAbout"
        Me.tbAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAbout.Size = New System.Drawing.Size(920, 546)
        Me.tbAbout.TabIndex = 1
        Me.tbAbout.Text = "About"
        Me.tbAbout.UseVisualStyleBackColor = True
        '
        'TrdControlPanel1
        '
        Me.TrdControlPanel1.Enabled = False
        Me.TrdControlPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TrdControlPanel1.Name = "TrdControlPanel1"
        Me.TrdControlPanel1.Size = New System.Drawing.Size(920, 526)
        Me.TrdControlPanel1.TabIndex = 2
        '
        'TrdControlPanel2
        '
        Me.TrdControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TrdControlPanel2.Name = "TrdControlPanel2"
        Me.TrdControlPanel2.Size = New System.Drawing.Size(922, 541)
        Me.TrdControlPanel2.TabIndex = 0
        '
        'TiltStepPanel1
        '
        Me.TiltStepPanel1.Location = New System.Drawing.Point(5, 5)
        Me.TiltStepPanel1.Name = "TiltStepPanel1"
        Me.TiltStepPanel1.Size = New System.Drawing.Size(912, 538)
        Me.TiltStepPanel1.TabIndex = 0
        '
        'AboutPanel1
        '
        Me.AboutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AboutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.AboutPanel1.Name = "AboutPanel1"
        Me.AboutPanel1.Size = New System.Drawing.Size(914, 540)
        Me.AboutPanel1.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 572)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MainForm"
        Me.Text = "2DPlatformControlSystem"
        Me.TabControl1.ResumeLayout(False)
        Me.tbTrdControl.ResumeLayout(False)
        Me.tbTrdControl2.ResumeLayout(False)
        Me.tbTiltStep.ResumeLayout(False)
        Me.tbAbout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbTrdControl As TabPage
    Friend WithEvents tbAbout As TabPage
    Friend WithEvents TrdControlPanel1 As TrdControlPanel
    Friend WithEvents AboutPanel1 As AboutPanel
    Friend WithEvents tbTiltStep As TabPage
    Friend WithEvents TiltStepPanel1 As TiltStepPanel
    Friend WithEvents tbTrdControl2 As TabPage
    Friend WithEvents TrdControlPanel2 As TrdControlPanel2
End Class
