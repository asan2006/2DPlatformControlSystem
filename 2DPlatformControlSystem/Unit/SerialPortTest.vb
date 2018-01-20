Imports System.IO.Ports
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop

Public Class SerialPortTest

    Dim a_offx, a_offy, ra_off As Double
    Dim g_offz As Double
    Dim count = 0
    Dim receivedData, tmpstr As String
    Dim connected As Boolean = False
    Dim comPORT As String
    Dim testDataStopNow As Boolean = True
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim range As Excel.Range
    Dim rCnt As Integer
    Dim cCnt As Integer
    Dim Obj As Object

    Private Sub btnFindPort_Click(sender As Object, e As EventArgs) Handles btnFindPort.Click
        cbSerialPort.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cbSerialPort.Items.Add(sp)
        Next
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        ' When the Connect button is clicked; if a COM port has been selected, connect and send out a HELLO message.
        ' Then wait for the Arduino to respond with its own HELLO.
        ' When the HELLO is received we are connected; change the button text to Dis-connect.
        Dim portName As String = ""
        portName = cbSerialPort.SelectedItem.ToString
        If (btnConnect.Text = "Connect") Then
            btnConnect.Text = "Connecting..."
            If (portName <> "") Then
                SerialPort_COM.Close()
                SerialPort_COM.PortName = portName
                SerialPort_COM.BaudRate = 115200
                SerialPort_COM.DataBits = 8
                SerialPort_COM.Parity = Parity.None
                SerialPort_COM.StopBits = StopBits.One
                SerialPort_COM.Handshake = Handshake.None
                SerialPort_COM.Encoding = System.Text.Encoding.Default
                SerialPort_COM.ReadTimeout = 100

                SerialPort_COM.Open()
                btnConnect.Text = "Dis-connect"

                'See if the Arduino is there
                'count = 0
                'SerialPort_COM.WriteLine("<HELLO>")
                connecting_Timer.Enabled = True
                data_Timer.Enabled = False
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            'close the connection a reset the button and timer label
            'Timer1.Enabled = False
            'Timer_LBL.Text = "Timer: OFF"
            SerialPort_COM.Close()
            'connected = False
            btnConnect.Text = "Connect"
            btnFindPort_Click(Nothing, Nothing)
            connecting_Timer.Enabled = False
        End If
    End Sub

    'The connecting_Timer waits for the Arduino to say HELLO.
    ' If HELLO is not received in 2 seconds display an error message.
    ' The connecting_Timer is used for calibration
    Private Sub connecting_Timer_Tick(sender As Object, e As EventArgs) Handles connecting_Timer.Tick

        receivedData = ReceiveSerialDataIni()
        RichTextBox1.Text &= receivedData



    End Sub

    Private Sub populateCOMport()
        comPORT = ""
        cbSerialPort.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cbSerialPort.Items.Add(sp)
        Next
    End Sub

    Sub btnStartTest_Click(sender As Object, e As EventArgs) Handles btnStartTest.Click
        'Send MotionStart=true signal to 8158 motion control card to start motionconnecting_Timer
        SerialPort_COM.WriteLine("<ASTRT>")    'Tell Arduino card to start receive sensor signals and send to GUI
        Threading.Thread.Sleep(10)
        data_Timer.Enabled = True
        connecting_Timer.Enabled = False
        RichTextBox1.Text = ""
        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open("c:\2DTestStationExcelFiles/DataExample.xlsx")
        xlWorkSheet = xlWorkBook.Worksheets("sheet1")

    End Sub
    Private Sub acclDataLog()   'Call sub for 2 D
        Dim StartMarkerPos As Integer
        Dim EndMarkerPos As Integer
        Dim axi As Double   'No need for the az axis for the test station. 
        Dim ayi As Double
        Dim rai As Double
        Dim gzi As Double   'No need for the gx and gy axes for the test station. 
        Dim gti As Double   'for temperature in gyro 
        Dim tmri As Double
        Dim ax As String
        Dim ay As String
        Dim ra As String
        Dim tmr As String  'timer count from arduino 
        Dim j As Integer
        Dim gz As Double
        Dim gt As Double    'for temperature in gyro 

        Dim receivedData, tmpstr As String
        Dim parsedData As String()

        EndMarkerPos = 0
        StartMarkerPos = 0
        'j = 0

        receivedData = ReceiveSerialData()
        StartMarkerPos = receivedData.IndexOf("i<")
        EndMarkerPos = receivedData.IndexOf(">i") 'The endmmark position is at E and there should be another 6
        If (EndMarkerPos - StartMarkerPos) > 0 And StartMarkerPos >= 0 Then

            tmpstr = receivedData.Substring(StartMarkerPos + 2, (EndMarkerPos - StartMarkerPos - 2))
            parsedData = Split(tmpstr, ",")
            'For the test station, the only sensing axis of the gyro is z axis. So no need for other two axes. 
            'For the accelerometer, the z-axis is vertical to the rotation/acceleration plane. So no need for this axis. 
            tmri = GetDouble(parsedData(0))
            axi = GetDouble(parsedData(1))
            ayi = GetDouble(parsedData(2))
            rai = GetDouble(parsedData(3))
            gzi = GetDouble(parsedData(4))
            gti = GetDouble(parsedData(5))
            j += 1
            'RichTextBox1.Text = ""
            tmr = (0.001 * tmri).ToString("F2")   'change to milliseconds for database
            axi = axi / 255 '- a_offx
            ayi = ayi / 255 '- a_offy
            rai = rai / 1023 '- ra_off
            'gzi = gzi '- g_offz
            'gt = gti '- g_offt
            ax = axi.ToString("F4")
            ay = ayi.ToString("F4")
            ra = rai.ToString("F4")
            gz = gzi.ToString("F2")
            gt = gti.ToString("F2")

            RichTextBox1.Text &= tmr & ", " & ax & ", " & ay & ", " & ra & ", " & gz & ", " & gt & vbCrLf


            'range = xlWorkSheet.UsedRange
            count = xlWorkSheet.UsedRange.Rows.Count
            xlWorkSheet.Cells(count + 1, 1) = tmr
            xlWorkSheet.Cells(count + 1, 2) = ax
            xlWorkSheet.Cells(count + 1, 3) = ay
            xlWorkSheet.Cells(count + 1, 4) = ra
            xlWorkSheet.Cells(count + 1, 5) = gz
            xlWorkSheet.Cells(count + 1, 6) = gt

            'Obj = CType(range.Cells(count + 1, cCnt), Excel.Range)

        End If


    End Sub

    Function ReceiveSerialDataIni() As String   'For checking if the microcontroler is connected to GUI
        Dim Incoming As String
        Dim StartMarkerPos As Integer = 0
        Try
            Incoming = SerialPort_COM.ReadExisting()
            'StartMarkerPos = receivedData.IndexOf("HELLO")
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else

                Incoming = "Microcontroller ready!" & vbCrLf
                'btnConnect.Text = "Data Ready"
                'btnConnect.Visible = False
                'connecting_Timer.Enabled = False
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try


    End Function
    Function ReceiveSerialData() As String
        Dim Incoming As String
        Dim StartMarkerPos As Integer = 0
        Try
            Incoming = SerialPort_COM.ReadExisting()
            'StartMarkerPos = receivedData.IndexOf("HELLO")
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try


    End Function

    Public Function GetDouble(ByVal doublestring As String) As Double  'convert a string to double
        Dim value As Double
        If Double.TryParse(doublestring, value) Then
            Return value
        Else
            Return value = 0.0
        End If

    End Function

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dataStopBtn_Click(sender As Object, e As EventArgs) Handles dataStopBtn.Click
        'testDataStopNow = True
        SerialPort_COM.DiscardInBuffer()
        SerialPort_COM.Close()
        btnConnect.Text = "Connect"
        btnFindPort_Click(Nothing, Nothing)         'Resume to initial status
        data_Timer.Enabled = False
        xlWorkBook.Save()

        'Release excel application
        xlWorkBook.Close()
        xlApp.Quit()
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlWorkSheet)
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlWorkBook)
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlApp)
        xlWorkSheet = Nothing
        xlWorkBook = Nothing
        xlApp = Nothing
        GC.Collect()

        'xlWorkBook.Close()
        'xlApp.Quit()
        'releaseObject(xlApp)
        'releaseObject(xlWorkBook)
        'releaseObject(xlWorkSheet)
    End Sub

    Private Sub data_Timer_Tick(sender As Object, e As EventArgs) Handles data_Timer.Tick
        'testDataStopNow = False
        acclDataLog()

    End Sub

    Private Sub releaseObject(ByVal obj As Object)

        Try

            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)

            obj = Nothing

        Catch ex As Exception

            obj = Nothing

        Finally

            GC.Collect()

        End Try

    End Sub

    Public Sub stopDataAcq()
        'stop data acquire
        Try
            dataStopBtn_Click(Nothing, Nothing)
        Catch ex As Exception

        End Try
    End Sub

End Class
