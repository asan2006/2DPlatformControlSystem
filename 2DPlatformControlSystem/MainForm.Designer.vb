﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbTrdControl = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbAbout = New System.Windows.Forms.TabPage()
        Me.txtAbout = New System.Windows.Forms.TextBox()
        Me.TrdControlPanel1 = New _2DPlatformControlSystem.TrdControlPanel()
        Me.TabControl1.SuspendLayout()
        Me.tbTrdControl.SuspendLayout()
        Me.tbAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbTrdControl)
        Me.TabControl1.Controls.Add(Me.tbAbout)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(928, 604)
        Me.TabControl1.TabIndex = 1
        '
        'tbTrdControl
        '
        Me.tbTrdControl.Controls.Add(Me.TrdControlPanel1)
        Me.tbTrdControl.Controls.Add(Me.Button2)
        Me.tbTrdControl.Controls.Add(Me.Button1)
        Me.tbTrdControl.Location = New System.Drawing.Point(4, 22)
        Me.tbTrdControl.Name = "tbTrdControl"
        Me.tbTrdControl.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTrdControl.Size = New System.Drawing.Size(920, 578)
        Me.tbTrdControl.TabIndex = 0
        Me.tbTrdControl.Text = "TrdControl"
        Me.tbTrdControl.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(280, 324)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbAbout
        '
        Me.tbAbout.Controls.Add(Me.txtAbout)
        Me.tbAbout.Location = New System.Drawing.Point(4, 22)
        Me.tbAbout.Name = "tbAbout"
        Me.tbAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAbout.Size = New System.Drawing.Size(942, 534)
        Me.tbAbout.TabIndex = 1
        Me.tbAbout.Text = "About"
        Me.tbAbout.UseVisualStyleBackColor = True
        '
        'txtAbout
        '
        Me.txtAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAbout.Location = New System.Drawing.Point(3, 3)
        Me.txtAbout.Multiline = True
        Me.txtAbout.Name = "txtAbout"
        Me.txtAbout.Size = New System.Drawing.Size(936, 528)
        Me.txtAbout.TabIndex = 0
        '
        'TrdControlPanel1
        '
        Me.TrdControlPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TrdControlPanel1.Name = "TrdControlPanel1"
        Me.TrdControlPanel1.Size = New System.Drawing.Size(920, 519)
        Me.TrdControlPanel1.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 604)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MainForm"
        Me.Text = "2DPlatformControlSystem"
        Me.TabControl1.ResumeLayout(False)
        Me.tbTrdControl.ResumeLayout(False)
        Me.tbAbout.ResumeLayout(False)
        Me.tbAbout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbTrdControl As TabPage
    Friend WithEvents tbAbout As TabPage
    Friend WithEvents txtAbout As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TrdControlPanel1 As TrdControlPanel
End Class
