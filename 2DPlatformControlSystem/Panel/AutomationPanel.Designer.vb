<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AutomationPanel
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
        Me.btnAutoRun = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.tm_Thread = New System.Windows.Forms.Timer(Me.components)
        Me.btnCheckListItem = New System.Windows.Forms.Button()
        Me.InfoDisp1 = New _2DPlatformControlSystem.InfoDisp()
        Me.CfgListBox1 = New _2DPlatformControlSystem.CfgListBox()
        Me.SuspendLayout()
        '
        'btnAutoRun
        '
        Me.btnAutoRun.Location = New System.Drawing.Point(438, 443)
        Me.btnAutoRun.Name = "btnAutoRun"
        Me.btnAutoRun.Size = New System.Drawing.Size(131, 45)
        Me.btnAutoRun.TabIndex = 1
        Me.btnAutoRun.Text = "AutoRun"
        Me.btnAutoRun.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(611, 443)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(131, 45)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(786, 443)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(131, 45)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'tm_Thread
        '
        Me.tm_Thread.Enabled = True
        Me.tm_Thread.Interval = 500
        '
        'btnCheckListItem
        '
        Me.btnCheckListItem.Location = New System.Drawing.Point(340, 0)
        Me.btnCheckListItem.Name = "btnCheckListItem"
        Me.btnCheckListItem.Size = New System.Drawing.Size(92, 23)
        Me.btnCheckListItem.TabIndex = 3
        Me.btnCheckListItem.Text = "CheckListItem"
        Me.btnCheckListItem.UseVisualStyleBackColor = True
        '
        'InfoDisp1
        '
        Me.InfoDisp1.AutoScroll = True
        Me.InfoDisp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.InfoDisp1.Location = New System.Drawing.Point(438, 3)
        Me.InfoDisp1.Name = "InfoDisp1"
        Me.InfoDisp1.Size = New System.Drawing.Size(479, 423)
        Me.InfoDisp1.TabIndex = 2
        '
        'CfgListBox1
        '
        Me.CfgListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CfgListBox1.Location = New System.Drawing.Point(0, 3)
        Me.CfgListBox1.Name = "CfgListBox1"
        Me.CfgListBox1.Size = New System.Drawing.Size(432, 534)
        Me.CfgListBox1.TabIndex = 0
        '
        'AutomationPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCheckListItem)
        Me.Controls.Add(Me.InfoDisp1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnAutoRun)
        Me.Controls.Add(Me.CfgListBox1)
        Me.Name = "AutomationPanel"
        Me.Size = New System.Drawing.Size(920, 540)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CfgListBox1 As CfgListBox
    Friend WithEvents btnAutoRun As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents InfoDisp1 As InfoDisp
    Friend WithEvents tm_Thread As Timer
    Friend WithEvents btnCheckListItem As Button
End Class
