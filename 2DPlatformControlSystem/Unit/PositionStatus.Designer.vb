<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PositionStatus
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLPosStatus = New System.Windows.Forms.TextBox()
        Me.btnLPosReset = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnRPosReset = New System.Windows.Forms.Button()
        Me.txtRPosStatus = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnRPosGo = New System.Windows.Forms.Button()
        Me.txtRPosSet = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnLPosGo = New System.Windows.Forms.Button()
        Me.txtLPosSet = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLPosReset)
        Me.GroupBox1.Controls.Add(Me.txtLPosStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Linear(mm)"
        '
        'txtLPosStatus
        '
        Me.txtLPosStatus.Location = New System.Drawing.Point(6, 20)
        Me.txtLPosStatus.Name = "txtLPosStatus"
        Me.txtLPosStatus.ReadOnly = True
        Me.txtLPosStatus.Size = New System.Drawing.Size(70, 21)
        Me.txtLPosStatus.TabIndex = 0
        '
        'btnLPosReset
        '
        Me.btnLPosReset.Location = New System.Drawing.Point(82, 18)
        Me.btnLPosReset.Name = "btnLPosReset"
        Me.btnLPosReset.Size = New System.Drawing.Size(75, 23)
        Me.btnLPosReset.TabIndex = 1
        Me.btnLPosReset.Text = "Reset"
        Me.btnLPosReset.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 203)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PositionControl"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 84)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PostionStatus"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnRPosReset)
        Me.GroupBox4.Controls.Add(Me.txtRPosStatus)
        Me.GroupBox4.Location = New System.Drawing.Point(211, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(168, 53)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rotate(deg)"
        '
        'btnRPosReset
        '
        Me.btnRPosReset.Location = New System.Drawing.Point(82, 18)
        Me.btnRPosReset.Name = "btnRPosReset"
        Me.btnRPosReset.Size = New System.Drawing.Size(75, 23)
        Me.btnRPosReset.TabIndex = 1
        Me.btnRPosReset.Text = "Reset"
        Me.btnRPosReset.UseVisualStyleBackColor = True
        '
        'txtRPosStatus
        '
        Me.txtRPosStatus.Location = New System.Drawing.Point(6, 20)
        Me.txtRPosStatus.Name = "txtRPosStatus"
        Me.txtRPosStatus.ReadOnly = True
        Me.txtRPosStatus.Size = New System.Drawing.Size(70, 21)
        Me.txtRPosStatus.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 110)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(385, 84)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PostionSet"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnRPosGo)
        Me.GroupBox6.Controls.Add(Me.txtRPosSet)
        Me.GroupBox6.Location = New System.Drawing.Point(211, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(168, 53)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Rotate(deg)"
        '
        'btnRPosGo
        '
        Me.btnRPosGo.Location = New System.Drawing.Point(82, 18)
        Me.btnRPosGo.Name = "btnRPosGo"
        Me.btnRPosGo.Size = New System.Drawing.Size(75, 23)
        Me.btnRPosGo.TabIndex = 1
        Me.btnRPosGo.Text = "Go"
        Me.btnRPosGo.UseVisualStyleBackColor = True
        '
        'txtRPosSet
        '
        Me.txtRPosSet.Location = New System.Drawing.Point(6, 20)
        Me.txtRPosSet.Name = "txtRPosSet"
        Me.txtRPosSet.Size = New System.Drawing.Size(70, 21)
        Me.txtRPosSet.TabIndex = 0
        Me.txtRPosSet.Text = "0"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnLPosGo)
        Me.GroupBox7.Controls.Add(Me.txtLPosSet)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(166, 53)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Linear(mm)"
        '
        'btnLPosGo
        '
        Me.btnLPosGo.Location = New System.Drawing.Point(82, 20)
        Me.btnLPosGo.Name = "btnLPosGo"
        Me.btnLPosGo.Size = New System.Drawing.Size(75, 23)
        Me.btnLPosGo.TabIndex = 1
        Me.btnLPosGo.Text = "Go"
        Me.btnLPosGo.UseVisualStyleBackColor = True
        '
        'txtLPosSet
        '
        Me.txtLPosSet.Location = New System.Drawing.Point(6, 20)
        Me.txtLPosSet.Name = "txtLPosSet"
        Me.txtLPosSet.Size = New System.Drawing.Size(70, 21)
        Me.txtLPosSet.TabIndex = 0
        Me.txtLPosSet.Text = "0"
        '
        'PositionStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "PositionStatus"
        Me.Size = New System.Drawing.Size(397, 203)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents txtLPosStatus As TextBox
    Private WithEvents btnLPosReset As Button
    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents GroupBox5 As GroupBox
    Private WithEvents GroupBox6 As GroupBox
    Private WithEvents btnRPosGo As Button
    Private WithEvents txtRPosSet As TextBox
    Private WithEvents GroupBox7 As GroupBox
    Private WithEvents btnLPosGo As Button
    Private WithEvents txtLPosSet As TextBox
    Private WithEvents GroupBox3 As GroupBox
    Private WithEvents GroupBox4 As GroupBox
    Private WithEvents btnRPosReset As Button
    Private WithEvents txtRPosStatus As TextBox
End Class
