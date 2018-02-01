Imports System.IO.Ports
Imports System.Text

Public Class SerialPort_Robin

    '是否正在关闭串口，执行Application.DoEvents，并阻止再次invoke
    Dim portClosing As Boolean = False
    '是否没有执行完invoke相关操作
    Dim listening As Boolean = False
    'sb用来存储和处理串口数据
    Dim sb As StringBuilder = New StringBuilder

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        '初始化串口查找
        InitialSerialPorts()

    End Sub

    Sub InitialSerialPorts()
        cboPorts.Items.Clear()

        Dim spNames As String() = My.Computer.Ports.SerialPortNames.ToArray
        Array.Sort(spNames)
        cboPorts.Items.AddRange(spNames)
        'choose the latest serial port as default
        cboPorts.SelectedIndex = spNames.Length - 1
    End Sub

    Private Sub btnFindPorts_Click(sender As Object, e As EventArgs) Handles btnFindPorts.Click
        InitialSerialPorts()

    End Sub

    Sub OpenSerialPort()
        If spCom.IsOpen Then
            portClosing = True

            While listening
                Application.DoEvents()
            End While

            spCom.Close()
        End If

        portClosing = False
        With spCom
            .PortName = cboPorts.Text
            .BaudRate = 115200
            .DataBits = 8
            .Parity = Parity.None
            .StopBits = StopBits.One
        End With
        Try
            '清除字符串构造器
            sb.Clear()
            spCom.Open()
            '发送命令开始接收数据
            spCom.WriteLine("<ASTRT>")
        Catch ex As Exception
            'if there is an error
            MsgBox(ex.ToString)
            ReleaseSP()
        End Try
    End Sub

    Sub UpdateTxtCMD(msg As String)
        Me.Invoke(DirectCast(Sub()
                                 txtCMD.AppendText(msg + vbCrLf)
                             End Sub,
                             EventHandler))
    End Sub

    Sub ReleaseSP()
        'Release Serial Port Resource
        Try
            If spCom.IsOpen Then
                spCom.Write("STOP")
                spCom.Close()
                sb.Clear()
                UpdateTxtCMD("Serial Port:" + spCom.PortName + " Closed!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub spCom_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles spCom.DataReceived
        If portClosing Then
            '如果正在关闭，忽略操作，直接返回，尽快的完成串口监听线程的一次循环
            Return
        End If

        Try
            listening = True        '设置标记，说明我已经开始处理数据，一会儿要使用系统UI的
            Dim portData = spCom.ReadExisting
            sb.Append(portData)
            UpdateTxtCMD(portData)  '显示在命令窗口中
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            listening = False   '我用完了，ui可以关闭串口了。
        End Try

    End Sub

    Function ParseReceiveStr(sb As StringBuilder) As Double()

    End Function

End Class
