<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CfgListBox
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
        Me.components = New System.ComponentModel.Container()
        Me.lbConfigFile = New System.Windows.Forms.ListBox()
        Me.cmsListConfig = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ofdConfig = New System.Windows.Forms.OpenFileDialog()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmsListConfig.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbConfigFile
        '
        Me.lbConfigFile.AllowDrop = True
        Me.lbConfigFile.ContextMenuStrip = Me.cmsListConfig
        Me.lbConfigFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbConfigFile.FormattingEnabled = True
        Me.lbConfigFile.HorizontalScrollbar = True
        Me.lbConfigFile.ItemHeight = 12
        Me.lbConfigFile.Location = New System.Drawing.Point(3, 17)
        Me.lbConfigFile.Name = "lbConfigFile"
        Me.lbConfigFile.ScrollAlwaysVisible = True
        Me.lbConfigFile.Size = New System.Drawing.Size(362, 306)
        Me.lbConfigFile.TabIndex = 0
        '
        'cmsListConfig
        '
        Me.cmsListConfig.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.cmsListConfig.Name = "cmsListConfig"
        Me.cmsListConfig.Size = New System.Drawing.Size(107, 70)
        '
        'ofdConfig
        '
        Me.ofdConfig.Filter = "配置文件|*.xlsx"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbConfigFile)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 326)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AutoConfigList"
        '
        'CfgListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CfgListBox"
        Me.Size = New System.Drawing.Size(368, 326)
        Me.cmsListConfig.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbConfigFile As ListBox
    Friend WithEvents cmsListConfig As ContextMenuStrip
    Friend WithEvents ofdConfig As OpenFileDialog
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
End Class
