Imports System.IO.Ports
Imports System.Text

Public Class SerialPort_Robin

    '是否正在关闭串口，执行Application.DoEvents，并阻止再次invoke
    Dim portClosing As Boolean = False
    '是否没有执行完invoke相关操作
    Dim listening As Boolean = False
    'sb用来存储和串口原始数据
    Dim sb As StringBuilder = New StringBuilder
    'sbResult用来存储和处理串口数据
    Dim sbResult As StringBuilder = New StringBuilder

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
            sbResult.Clear()
            spCom.Open()
            '发送命令开始接收数据
            UpdateTxtCMD("Serial Port:" + spCom.PortName + " Opened and begin acqure data!")
            spCom.WriteLine("<ASTRT>")
        Catch ex As Exception
            'if there is an error
            MsgBox(ex.ToString)
            ReleaseSP()
        End Try
    End Sub

    Sub UpdateTxtCMD(msg As String)
        Me.Invoke(DirectCast(Sub()
                                 txtCMD.AppendText(Now.ToString + " : " + msg + vbCrLf)
                             End Sub,
                             EventHandler))
    End Sub

    Sub ReleaseSP()
        'Release Serial Port Resource
        Try
            If spCom.IsOpen Then
                spCom.Write("STOP")
                spCom.Close()
                'sb.Clear()
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
            'Dim tmpstr = portData.Replace("i<", "").Replace(">i", "").Replace(",", vbTab)
            sb.Append(portData)

            While sb.ToString.IndexOf(">i") > 0
                Dim strResult = ParseReceiveStr(sb)
                sbResult.Append(strResult)  '添加处理后的数据到字符串构造器
            End While

            'UpdateTxtCMD(portData)  '显示在命令窗口中
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            listening = False   '我用完了，ui可以关闭串口了。
        End Try

    End Sub

    Function ParseReceiveStr(sb As StringBuilder) As String
        Dim StartMarkerPos = sb.ToString.IndexOf("i<")
        Dim EndMarkerPos = sb.ToString.IndexOf(">i")

        If EndMarkerPos >= 0 And StartMarkerPos >= 0 And EndMarkerPos - StartMarkerPos > 0 Then

            Dim tmpstr = sb.ToString.Substring(StartMarkerPos + 2, (EndMarkerPos - StartMarkerPos - 2))
            Dim parsedData = Split(tmpstr, ",")
            'For the test station, the only sensing axis of the gyro is z axis. So no need for other two axes. 
            'For the accelerometer, the z-axis is vertical to the rotation/acceleration plane. So no need for this axis. 
            Dim tmri = GetDouble(parsedData(0))
            Dim axi = GetDouble(parsedData(1))
            Dim ayi = GetDouble(parsedData(2))
            Dim rai = GetDouble(parsedData(3))
            Dim gzi = GetDouble(parsedData(4))
            Dim gti = GetDouble(parsedData(5))
            Dim tmr = (0.001 * tmri).ToString("F2")   'change to milliseconds for database
            axi = axi / 255 '- a_offx
            ayi = ayi / 255 '- a_offy
            rai = rai / 1023 '- ra_off
            'gzi = gzi '- g_offz
            'gti = gti '- g_offt

            Dim ax = axi.ToString("F4")
            Dim ay = ayi.ToString("F4")
            Dim ra = rai.ToString("F4")
            Dim gz = gzi.ToString("F2")
            Dim gt = gti.ToString("F2")

            sb.Remove(0, EndMarkerPos + 2)  'Remove from data string bulder

            Return tmr & vbTab & ax & vbTab & ay & vbTab & ra & vbTab & gz & vbTab & gt & vbCrLf
        Else
            If EndMarkerPos >= 0 Then
                'remove non integrity frame data
                sb.Remove(0, EndMarkerPos + 2)  'Remove from data string bulder
            End If
            Return String.Empty
        End If

    End Function

    Private Function GetDouble(ByVal doublestring As String) As Double
        'convert a string to double
        Dim value As Double
        If Double.TryParse(doublestring, value) Then
            Return value
        Else
            Return value = 0.0
        End If
    End Function

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtCMD.Clear()
    End Sub

    Sub SaveToXlsx()
        UpdateTxtCMD("Writing date to Excel file...")
        SaveToXls2(sbResult.ToString, txtFileName.Text)
        UpdateTxtCMD("Save " + txtFileName.Text + ".xlsx Completed!")
    End Sub

    Private Sub btnStartTest_Click(sender As Object, e As EventArgs) Handles btnStartTest.Click
        OpenSerialPort()
    End Sub

    Private Sub btnStopTest_Click(sender As Object, e As EventArgs) Handles btnStopTest.Click
        ReleaseSP()
        SaveToXlsx()
    End Sub
End Class