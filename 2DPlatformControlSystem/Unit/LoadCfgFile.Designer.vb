<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadCfgFile
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSetPath = New System.Windows.Forms.Button()
        Me.txtCfgPath = New System.Windows.Forms.TextBox()
        Me.cboCfgList = New System.Windows.Forms.ComboBox()
        Me.btnLoadCfg = New System.Windows.Forms.Button()
        Me.fbd1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnSetPath)
        Me.GroupBox2.Controls.Add(Me.txtCfgPath)
        Me.GroupBox2.Controls.Add(Me.cboCfgList)
        Me.GroupBox2.Controls.Add(Me.btnLoadCfg)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 73)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Load configure file"
        '
        'btnSetPath
        '
        Me.btnSetPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSetPath.Location = New System.Drawing.Point(430, 16)
        Me.btnSetPath.Name = "btnSetPath"
        Me.btnSetPath.Size = New System.Drawing.Size(75, 23)
        Me.btnSetPath.TabIndex = 9
        Me.btnSetPath.Text = "SetPath"
        Me.btnSetPath.UseVisualStyleBackColor = True
        '
        'txtCfgPath
        '
        Me.txtCfgPath.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCfgPath.Location = New System.Drawing.Point(3, 18)
        Me.txtCfgPath.Name = "txtCfgPath"
        Me.txtCfgPath.ReadOnly = True
        Me.txtCfgPath.Size = New System.Drawing.Size(421, 21)
        Me.txtCfgPath.TabIndex = 8
        '
        'cboCfgList
        '
        Me.cboCfgList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCfgList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCfgList.FormattingEnabled = True
        Me.cboCfgList.Items.AddRange(New Object() {"Refresh file list"})
        Me.cboCfgList.Location = New System.Drawing.Point(3, 45)
        Me.cboCfgList.Name = "cboCfgList"
        Me.cboCfgList.Size = New System.Drawing.Size(421, 20)
        Me.cboCfgList.TabIndex = 7
        '
        'btnLoadCfg
        '
        Me.btnLoadCfg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoadCfg.Location = New System.Drawing.Point(430, 43)
        Me.btnLoadCfg.Name = "btnLoadCfg"
        Me.btnLoadCfg.Size = New System.Drawing.Size(75, 22)
        Me.btnLoadCfg.TabIndex = 6
        Me.btnLoadCfg.Text = "Load"
        Me.btnLoadCfg.UseVisualStyleBackColor = True
        '
        'fbd1
        '
        Me.fbd1.ShowNewFolderButton = False
        '
        'LoadCfgFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "LoadCfgFile"
        Me.Size = New System.Drawing.Size(511, 73)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents cboCfgList As ComboBox
    Private WithEvents btnLoadCfg As Button
    Private WithEvents btnSetPath As Button
    Private WithEvents txtCfgPath As TextBox
    Private WithEvents fbd1 As FolderBrowserDialog
End Class
