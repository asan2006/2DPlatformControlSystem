Public Class TiltStepPanel
    Const card2005 As Short = 0

    Dim bolDAQ As Boolean
    Dim ScanIntrv As Integer
    Dim ScanCount As Integer
    Dim ADChanCount As Integer = 4

    Dim expInfo As String
    Dim fileName As String

    Dim RstrVel As Double
    Dim RmaxVel As Double
    Dim RTacc As Double
    Dim RTdec As Double
    Dim RDist As Double
    Dim axis As Short

    Dim sTilt As Double
    Dim eTilt As Double

    Dim Tcalibration As Double
    Dim stepCount As Double
    Dim dataSB As New System.Text.StringBuilder     'store every step averaged point

    Dim MotionThread As System.Threading.Thread

    Dim strMotionStatus As String = "STATUS: NONE"

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        txtFileToSave.Text = Application.StartupPath + "\ADLinkDaq"
        tsslStatus.Text = strMotionStatus
    End Sub

    Private Sub cboScanInterval_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboScanInterval.SelectedIndexChanged
        If IsNumeric(cboScanInterval.Text) Then
            Dim ScanRate As Long
            ScanRate = 40000000 / CInt(cboScanInterval.Text)
            lblScanRate.Text = "Scan rate(" & ScanRate & ") = " & vbCrLf &
                "Timebase(40,000,000)" & vbCrLf &
                "/Scan interval(" & cboScanInterval.Text & ")"
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        'initial the parameters
        axis = 1  'rotation axis
        RstrVel = RotatePosModeCfg1.RStrVel
        RmaxVel = RotatePosModeCfg1.RMaxVel
        RTacc = RotatePosModeCfg1.RTacc
        RTdec = RotatePosModeCfg1.RTdec
        RDist = RotatePosModeCfg1.RDist
        Tcalibration = CDbl(txtCaliTime.Text)

        sTilt = CDbl(txtStartTilt.Text)
        eTilt = CDbl(txtEndTilt.Text)
        stepCount = (eTilt - sTilt) / RDist

        'check the tilt parameters
        If stepCount <= 0 Then
            MsgBox("Parameter is not correct, please confiure again!")
            Exit Sub
        End If

        ScanIntrv = CInt(cboScanInterval.Text)
        ScanCount = CInt(cboDataSize.Text)

        bolDAQ = chkDaq2005Enable.Enabled
        expInfo = txtExpCondition.Text
        fileName = txtFileToSave.Text

        dataSB.Clear
        'ADD EXLCE HEADER STRING
        dataSB.AppendLine("Tilt" + vbTab + txtxlsHeaderCH_1.Text + vbTab + txtxlsHeaderCH_2.Text + vbTab + txtxlsHeaderCH_3.Text + vbTab + txtxlsHeaderCH_4.Text)

        MotionThread = New System.Threading.Thread(AddressOf MotionStart)
        'set threading apartment state as sta mode , so can handle the xlsx file for the data to store
        MotionThread.SetApartmentState(Threading.ApartmentState.STA)
        MotionThread.Start()

    End Sub

    Private Sub MotionStart()

        For i = 1 To stepCount

            strMotionStatus = "STATUS: step motion " & i & "/" & stepCount
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'pci-8158
            Start_1Axis_tr_move(axis, RDist, RstrVel, RmaxVel, RTacc, RTdec)

            'waiting for the motion stop
            While Not isStopMotion()
                System.Threading.Thread.Sleep(50)
            End While

            'sensor calibration time
            System.Threading.Thread.Sleep(Tcalibration * 1000)


            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'DAQ-2005

            If bolDAQ Then
                StartDAQ(card2005, ScanIntrv, ScanCount, ADChanCount, "XLS")

                ClearDaq2005Async(card2005)

                dataSB.Append((sTilt + i * RDist).ToString + vbTab)
                For index = 0 To StepPoint.Length - 1
                    dataSB.Append(StepPoint(index).ToString + vbTab)
                Next
                dataSB.AppendLine()
            End If
        Next
        strMotionStatus = "STATUS: motion completed..."

        If bolDAQ Then
            strMotionStatus = "STATUS: data storing..."
            'store data to xls/xlsx
            SaveToXls(dataSB.ToString, expInfo, fileName)

            strMotionStatus = "STATUS: data store completed!!!"
        End If
    End Sub

    Private Function StepPoint() As Double()
        'get step point used to average methods
        Dim voltage(ScanCount - 1, ADChanCount - 1) As Double
        Dim i As Integer = 0
        While i < InBuf.GetLength(0)
            voltage(i / 4, 0) = Digital2Voltage(InBuf(i))
            voltage(i / 4, 1) = Digital2Voltage(InBuf(i + 1))
            voltage(i / 4, 2) = Digital2Voltage(InBuf(i + 2))
            voltage(i / 4, 3) = Digital2Voltage(InBuf(i + 3))
            i = i + 4
        End While
        Dim aveData(,) As Double = Average(voltage, ScanCount)
        Dim rtData(ADChanCount - 1) As Double

        For i = 0 To ADChanCount - 1
            'unit by millivolt
            rtData(i) = aveData(0, i) * 1000
        Next

        'return double(ADChanCount-1)
        Return rtData
    End Function

    Private Function Average(ByVal a(,) As Double, ByVal aveNum As Integer) As Double(,)

        If aveNum < 1 Then
            MsgBox("average num must be a positive number , pls check it!!!")
            Return Nothing
        Else
            Dim ave(a.GetLength(0) / aveNum - 1, a.GetLength(1) - 1) As Double
            Dim sum(a.GetLength(1) - 1) As Double
            For index = 0 To sum.Length - 1
                sum(index) = 0
            Next
            Dim i As Integer = 0
            Dim k As Integer = 0
            Dim l As Integer = a.GetLength(0)
            While l - i > 0

                For j = 0 To a.GetLength(1) - 1
                    sum(j) = sum(j) + a(i, j)
                Next

                i = i + 1

                If i Mod aveNum = 0 Then
                    For index = 0 To a.GetLength(1) - 1
                        'here data uint by millvolt instead of voltage...
                        ave(k, index) = sum(index) / aveNum * 1000
                    Next
                    k = k + 1
                    'sum set zero
                    For index = 0 To sum.Length - 1
                        sum(index) = 0
                    Next
                End If
            End While
            Return ave
        End If
    End Function

    Private Sub SaveToXls(ByVal StrData As String, ByVal StrExpCondition As String, ByVal StrFileName As String, Optional ByVal StrChartRange As String = Nothing)

        If String.IsNullOrEmpty(StrData) Or String.IsNullOrEmpty(StrFileName) Then
            Return
        Else
            Try
                Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
                xlApp.DefaultFilePath = ""
                xlApp.SheetsInNewWorkbook = 1
                Dim xlBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add(True)
                Dim xlSheet As Microsoft.Office.Interop.Excel.Worksheet = xlBook.Worksheets.Add()

                System.Windows.Forms.Clipboard.SetDataObject(StrData)
                xlSheet.Paste()

                '------------------------------------------------------------------------------
                ' here experimental conditions content will write in excel file at cell("W1")
                System.Windows.Forms.Clipboard.SetDataObject(StrExpCondition)
                xlSheet.Range("W1").PasteSpecial()

                '------------------------------------------------------------------------------
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'generally used the chanel "A:A,B:B"
                If ChkCH_4.Checked Then
                    StrChartRange = "A:A,E:E"
                    LineChart(xlSheet, xlSheet.Range(StrChartRange), 50, 50)
                    LineChart(xlSheet, xlSheet.Range(StrChartRange), 350, 250)
                Else
                    xlSheet.Range("E:E").Delete()
                End If

                If ChkCH_3.Checked Then
                    StrChartRange = "A:A,D:D"
                    LineChart(xlSheet, xlSheet.Range(StrChartRange), 50, 250)
                Else
                    xlSheet.Range("D:D").Delete()
                End If

                If ChkCH_2.Checked Then
                    StrChartRange = "A:A,C:C"
                    LineChart(xlSheet, xlSheet.Range(StrChartRange), 350, 50)
                Else
                    xlSheet.Range("C:C").Delete()
                End If

                If ChkCH_1.Checked Then
                    StrChartRange = "A:A,B:B"
                    LineChart(xlSheet, xlSheet.Range(StrChartRange), 50, 50)
                Else
                    xlSheet.Range("B:B").Delete()
                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                'here avoid the data overwrite alert info
                xlApp.DisplayAlerts = False
                'xlApp.AlertBeforeOverwriting = False
                'here avoid the defalt excel path is windows/system32

                'Use it more than office 2007 version, And add the Extension name ".xlsx"
                StrFileName = System.IO.Path.GetFullPath(StrFileName) & ".xlsx"
                xlBook.SaveAs(StrFileName)

                'Release excel application
                xlBook.Close()
                xlApp.Quit()
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlSheet)
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlBook)
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlApp)
                xlSheet = Nothing
                xlBook = Nothing
                xlApp = Nothing
                GC.Collect()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If

    End Sub

    Private Sub LineChart(ByVal xlSheet As Microsoft.Office.Interop.Excel.Worksheet, ByVal oRange As Microsoft.Office.Interop.Excel.Range, left As Double, top As Double)
        Dim oShape As Microsoft.Office.Interop.Excel.Shape = xlSheet.Shapes.AddChart(Microsoft.Office.Interop.Excel.XlChartType.xlXYScatter, left, top, 300, 200)
        Dim oChart As Microsoft.Office.Interop.Excel.Chart = oShape.Chart
        oChart.SetSourceData(oRange)

        'add trend line
        Dim tls As Microsoft.Office.Interop.Excel.Trendlines
        Dim tl As Microsoft.Office.Interop.Excel.Trendline
        Dim s As Microsoft.Office.Interop.Excel.Series = oChart.SeriesCollection(1)
        tls = s.Trendlines
        tl = tls.Add(Microsoft.Office.Interop.Excel.XlTrendlineType.xlLinear,,,,,, True, True)
        'alige dock at right
        tl.DataLabel.Left = oShape.Width - tl.DataLabel.Width

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        'test excel moulde
        'dataSB.Clear()
        'dataSB.AppendLine("AA" + vbTab + "BB" + vbTab + "CC" + vbTab + "DD")
        'dataSB.AppendLine("1" + vbTab + "5" + vbTab + "5" + vbTab + "5")
        'dataSB.AppendLine("2" + vbTab + "6" + vbTab + "6" + vbTab + "6")
        'dataSB.AppendLine("3" + vbTab + "9" + vbTab + "9" + vbTab + "10")
        'SaveToXls(dataSB.ToString, "test", "testfile")

        If axis = 2 Then
            B_8158_stop_move_all(0)
        Else
            'single axis motion stop
            B_8158_emg_stop(axis)
        End If
        'abort the thread
        If Not IsNothing(MotionThread) Then
            MotionThread.Abort()
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Release()
        Me.ParentForm.Close()
    End Sub

    Private Sub Release()
        btnStop_Click(Nothing, Nothing)

        If Not IsNothing(MotionThread) Then
            Try
                MotionThread.Abort()
            Catch ex As Exception

            End Try
        End If

        B_8158_close()
        D2K_Release_Card(card2005)
    End Sub

    Private Sub tm_Tick(sender As Object, e As EventArgs) Handles tm.Tick
        'this is useful ,conmment only for debug program
        btnStart.Enabled = isStopMotion()

        RotatePosModeCfg1.RCurSpeed = CurSpeed(1)

        tsslStatus.Text = strMotionStatus
    End Sub
End Class
