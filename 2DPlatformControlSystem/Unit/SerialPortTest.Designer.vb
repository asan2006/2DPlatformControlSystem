<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerialPortTest
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
        Me.SerialPort_COM = New System.IO.Ports.SerialPort(Me.components)
        Me.connecting_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFindPort = New System.Windows.Forms.Button()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnStartTest = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbSerialPort = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dataStop = New System.Windows.Forms.GroupBox()
        Me.dataStopBtn = New System.Windows.Forms.Button()
        Me.data_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.dataStop.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort_COM
        '
        Me.SerialPort_COM.BaudRate = 115200
        '
        'connecting_Timer
        '
        '
        'btnFindPort
        '
        Me.btnFindPort.Location = New System.Drawing.Point(117, 20)
        Me.btnFindPort.Name = "btnFindPort"
        Me.btnFindPort.Size = New System.Drawing.Size(89, 38)
        Me.btnFindPort.TabIndex = 2
        Me.btnFindPort.Text = "Find Com ports"
        Me.ToolTip1.SetToolTip(Me.btnFindPort, "打开微处理器连接COM")
        Me.btnFindPort.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(117, 64)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(89, 38)
        Me.btnConnect.TabIndex = 3
        Me.btnConnect.Text = "Connect"
        Me.ToolTip2.SetToolTip(Me.btnConnect, "检查数据采集是否正常。数据不保存。")
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnStartTest
        '
        Me.btnStartTest.Location = New System.Drawing.Point(117, 108)
        Me.btnStartTest.Name = "btnStartTest"
        Me.btnStartTest.Size = New System.Drawing.Size(89, 38)
        Me.btnStartTest.TabIndex = 4
        Me.btnStartTest.Text = "Start Test"
        Me.ToolTip3.SetToolTip(Me.btnStartTest, "正式开始数据采集")
        Me.btnStartTest.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbSerialPort)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(107, 53)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "COM Port"
        '
        'cbSerialPort
        '
        Me.cbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSerialPort.FormattingEnabled = True
        Me.cbSerialPort.Location = New System.Drawing.Point(6, 20)
        Me.cbSerialPort.Name = "cbSerialPort"
        Me.cbSerialPort.Size = New System.Drawing.Size(91, 20)
        Me.cbSerialPort.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(211, 20)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(291, 127)
        Me.RichTextBox1.TabIndex = 64
        Me.RichTextBox1.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.dataStop)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.btnStartTest)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.btnFindPort)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 167)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Communication to Microcontroller Setup"
        '
        'dataStop
        '
        Me.dataStop.Controls.Add(Me.dataStopBtn)
        Me.dataStop.Location = New System.Drawing.Point(6, 88)
        Me.dataStop.Margin = New System.Windows.Forms.Padding(2)
        Me.dataStop.Name = "dataStop"
        Me.dataStop.Padding = New System.Windows.Forms.Padding(2)
        Me.dataStop.Size = New System.Drawing.Size(107, 51)
        Me.dataStop.TabIndex = 66
        Me.dataStop.TabStop = False
        Me.dataStop.Text = "Stop Test"
        '
        'dataStopBtn
        '
        Me.dataStopBtn.Location = New System.Drawing.Point(6, 22)
        Me.dataStopBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.dataStopBtn.Name = "dataStopBtn"
        Me.dataStopBtn.Size = New System.Drawing.Size(89, 25)
        Me.dataStopBtn.TabIndex = 0
        Me.dataStopBtn.Text = "Stop Test"
        Me.dataStopBtn.UseVisualStyleBackColor = True
        '
        'data_Timer
        '
        Me.data_Timer.Interval = 1
        '
        'SerialPortTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SerialPortTest"
        Me.Size = New System.Drawing.Size(515, 167)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.dataStop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort_COM As IO.Ports.SerialPort
    Friend WithEvents connecting_Timer As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbSerialPort As System.Windows.Forms.ComboBox
    Friend WithEvents btnFindPort As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnStartTest As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dataStop As System.Windows.Forms.GroupBox
    Friend WithEvents dataStopBtn As System.Windows.Forms.Button
    Friend WithEvents data_Timer As System.Windows.Forms.Timer
End Class
