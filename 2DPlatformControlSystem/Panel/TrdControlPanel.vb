Public Class TrdControlPanel

    Const card8158 As Short = 0
    Const card2005 As Short = 0

    'preTime/prePos used to calc feedback speed
    'Dim preTime As DateTime
    Dim preTime As Long = 0
    Dim prePosT As Double = 0
    Dim preCount As Long
    Dim prePos As Double = 0
    Dim CPUfreq As Long

    Dim aveNum As Integer
    Dim expInfo As String
    Dim fileName As String
    Dim xlsHeader() As String

    'unit by second
    Dim TDuration As Double = 0
    'control the decode/incode data acquire is continue or over ???
    Dim motionStatus As Boolean = False
    'a streamwrite obj to write data to txt file
    Dim sw As IO.StreamWriter

    Dim LstrVel As Double
    Dim LmaxVel As Double
    Dim LTacc As Double
    Dim LTdec As Double
    Dim LTUnif As Double
    Dim LTdelay As Double
    Dim RstrVel As Double
    Dim RmaxVel As Double
    Dim RTacc As Double
    Dim RTdec As Double
    Dim RTUnif As Double
    Dim RDist As Double
    Dim axis As Short

    Dim motionMode As M_MODE
    'targetPos is used for velocity motion mode to stop motion at target position
    Dim targetPos As Double

    Dim MotionThread As System.Threading.Thread
    Dim motionDirect As Boolean = True  'when value is true ,motion speed is positive;else is negative


    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        DaqCfg1.fileName = Application.StartupPath + "\ADLinkDaq"
        'LoadCfgFile1.cfgFilePath = Application.StartupPath + "\Configure\"
    End Sub

    Private Sub LoadCfgFile1_CfgSet(fileName As String) Handles LoadCfgFile1.CfgSet
        'configure change event occured!!!
        Try

            Dim fullFileName As String = LoadCfgFile1.cfgFilePath + "\" + fileName
            Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
            Dim xlBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Open(fullFileName)
            Dim xlSheet As Microsoft.Office.Interop.Excel.Worksheet = xlBook.Worksheets(1)

            Dim motionMode As String = xlSheet.Range("B2").Value
            If motionMode = "TrdControl" Then
                'Verify the motion as right mode as the configure file

                LinearVelModeCfg1.IsLinearVelMode = xlSheet.Range("B3").Value
                LinearVelModeCfg1.LDelayTime = xlSheet.Range("B4").Value
                LinearVelModeCfg1.LTacc = xlSheet.Range("B5").Value
                LinearVelModeCfg1.LTdec = xlSheet.Range("B6").Value
                LinearVelModeCfg1.LMaxVel = xlSheet.Range("B7").Value
                LinearVelModeCfg1.LTunif = xlSheet.Range("B8").Value

                RotatePosModeCfg1.IsRotatePosMode = xlSheet.Range("B9").Value
                RotatePosModeCfg1.RDelayTime = xlSheet.Range("B10").Value
                RotatePosModeCfg1.RTacc = xlSheet.Range("B11").Value
                RotatePosModeCfg1.RTdec = xlSheet.Range("B12").Value
                RotatePosModeCfg1.RMaxVel = xlSheet.Range("B13").Value
                RotatePosModeCfg1.RDist = xlSheet.Range("B14").Value

                DaqCfg1.IsDaqEnable = xlSheet.Range("B15").Value
                DaqCfg1.ScanIntrv = xlSheet.Range("B16").Value
                DaqCfg1.ScanCount = xlSheet.Range("B17").Value
                DaqCfg1.aveNum = xlSheet.Range("B18").Value
                DaqCfg1.setChartOption = {xlSheet.Range("B19").Value,
                    xlSheet.Range("B20").Value,
                    xlSheet.Range("B21").Value,
                    xlSheet.Range("B22").Value}
                DaqCfg1.xlsHeader = {xlSheet.Range("B23").Value,
                    xlSheet.Range("B24").Value,
                    xlSheet.Range("B25").Value,
                    xlSheet.Range("B26").Value}
                DaqCfg1.expInfo = xlSheet.Range("B27").Value
                DaqCfg1.scanFileFormatMode = xlSheet.Range("B28").Value
                DaqCfg1.fileName = xlSheet.Range("B29").Value
            End If

            'Release excel application
            xlBook.Close()
            xlApp.Quit()
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlSheet)
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlBook)
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlApp)
            xlSheet = Nothing
            xlBook = Nothing
            xlApp = Nothing
            '资源回收放在调用过程之外
            'GC.Collect()
        Catch ex As Exception
            MessageBox.Show("Can't creat excel object, confirm your computer has installed the excel...")
        End Try
    End Sub

    Private Sub btnMotion_Click(sender As Object, e As EventArgs) Handles btnMotion.Click

        'initial preCount , CPUfreq , prePos
        'intial preCount after start 2005 card
        'QueryPerformanceCounter(preCount)
        QueryPerformanceFrequency(CPUfreq)
        B_8158_get_position(0, prePos)

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'daq2005     
        Dim ScanIntrv As Integer = DaqCfg1.ScanIntrv
        Dim ScanCount As Integer = DaqCfg1.ScanCount
        Dim ADChanCount As Integer = DaqCfg1.ADChanCount
        If DaqCfg1.IsDaqEnable Then

            'Always creat *.dat file
            StartDAQ(card2005, ScanIntrv, ScanCount, ADChanCount, "DAT", DaqCfg1.fileName)

        End If

        'intial preCount after start 2005 card
        QueryPerformanceCounter(preCount)

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'pci-8158
        LstrVel = LinearVelModeCfg1.LStrVel
        LmaxVel = LinearVelModeCfg1.LMaxVel
        LTacc = LinearVelModeCfg1.LTacc
        LTdec = LinearVelModeCfg1.LTdec
        LTUnif = LinearVelModeCfg1.LTunif
        LTdelay = LinearVelModeCfg1.LDelayTime
        RstrVel = RotatePosModeCfg1.RStrVel
        RmaxVel = RotatePosModeCfg1.RMaxVel
        RTacc = RotatePosModeCfg1.RTacc
        RTdec = RotatePosModeCfg1.RTdec
        RDist = RotatePosModeCfg1.RDist

        If LinearVelModeCfg1.IsLinearVelMode Then
            'Linear Motion mode
            axis = 0
        End If

        If RotatePosModeCfg1.IsRotatePosMode Then
            'Rotation Motion mode
            axis = 1
        End If

        If LinearVelModeCfg1.IsLinearVelMode And RotatePosModeCfg1.IsRotatePosMode Then
            'both axis select , mixed motion mode
            axis = 2
        End If

        motionMode = M_MODE.VELOCITY
        If LmaxVel > 0 Then
            motionDirect = True
        Else
            motionDirect = False
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'set motion info to txt

        'Dim motionInfo As String
        'motionInfo = "AccTime:  " & txtAccTime.Text & " S" & vbCrLf &
        '    "MaxSpeed:  " & txtMaxSpeedP.Text & " MM/S" & vbCrLf &
        '    "UniformTime:  " & txtUnifTime.Text & " MM"
        'If chkDaq2005Enable.Checked Then
        '    motionInfo = motionInfo & vbCrLf &
        '        "Scan Intervals :   " & cboScanInterval.Text & vbCrLf &
        '        "Data Size      :   " & CboDataSize.Text
        'End If
        'WriteInfoToTxt(motionInfo)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'avoid invoke method
        aveNum = DaqCfg1.aveNum
        expInfo = DaqCfg1.expInfo
        fileName = DaqCfg1.fileName
        xlsHeader = DaqCfg1.xlsHeader
        MotionThread = New System.Threading.Thread(AddressOf MotionStart)
        'set threading apartment state as sta mode , so can handle the xlsx file for the data to store
        MotionThread.SetApartmentState(Threading.ApartmentState.STA)
        MotionThread.Start()

    End Sub

    Private Sub MotionStart()

        motionStatus = True         'Begin to move , and bengin to acquire decode data

        'if DAQ2005 enable, then acquire the feedback data
        If DaqCfg1.Enabled Then
            sw = New IO.StreamWriter(fileName & "_Feedback.txt", False)    'if file is exit, then cover it
            sw.WriteLine("Time_Duration(s)" & vbTab & "Send_Speed(mm/s)" & vbTab & "FeedBack_Speed(mm/s)")

            Dim FeedbackThread As New System.Threading.Thread(AddressOf GetFeedback)
            FeedbackThread.Start()
        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'pci-8158
        'Before motion begin , it is will be keep null status for some seconds. 
        'Before motion begin , it is will be keep null status for 1 second. detail at "修改需求文档20131206.docx"
        System.Threading.Thread.Sleep(1000)
        Dim LdelayTime As Double = LTdelay * 1000
        ' VELOCITY MOTION MODE ONLY FIT AXIS
        Select Case axis
            Case 0
                Start_1Axis_tv_move(axis, LstrVel, LmaxVel, LTacc, LTUnif, LTdec)
            Case 1
                Start_1Axis_tr_move(axis, RDist, RstrVel, RmaxVel, RTacc, RTdec)
            Case 2
                'rotate first, then linear motion
                Start_1Axis_tr_move(1, RDist, RstrVel, RmaxVel, RTacc, RTdec)
                System.Threading.Thread.Sleep(LTdelay)
                Start_1Axis_tv_move(0, LstrVel, LmaxVel, LTacc, LTUnif, LTdec)
        End Select

        'waitting for axis stop motion
        'System.Threading.Thread.Sleep(1000)
        While Not isStopMotion()
            System.Threading.Thread.Sleep(50)
        End While

        motionStatus = False        'Move is over , and stop to acquire decode data

        'clear daq-2005 card async buffer
        ClearDaq2005Async(card2005)

        If DaqCfg1.IsDaqEnable And DaqCfg1.scanFileFormatMode = "XLS" Then
            'SAVE DATA AND SOME INFO

            dataToXLSX(xlsHeader, InBuf, aveNum, expInfo, fileName, DaqCfg1.strLineChart)
        End If
    End Sub

    Private Sub GetFeedback()
        While motionStatus
            Dim prepreCount As Double = preCount

            Dim curspd As Double = CurSpeed(0)
            Dim curFeedSpd = FeedbackSpeed2(preCount, prePos, CPUfreq)

            If motionDirect = False Then
                curspd = -CurSpeed(0)
            End If
            'write motion decode data
            sw.WriteLine(TDuration.ToString("0.000000") & vbTab & curspd & vbTab & curFeedSpd)
            TDuration = TDuration + (preCount - prepreCount) / CPUfreq
        End While

        sw.Flush()
        sw.Close()
        sw = Nothing
        TDuration = 0
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If axis = 2 Then
            B_8158_stop_move_all(0)
        Else
            'single axis motion stop
            B_8158_emg_stop(axis)
        End If
        'Update Motion Status
        motionStatus = False
        'debug code
        'Timer1.Enabled = False
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

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Release()
        Me.ParentForm.Close()
    End Sub

    Private Sub tm_Tick(sender As Object, e As EventArgs) Handles tm.Tick
        btnMotion.Enabled = isStopMotion() And
            (LinearVelModeCfg1.IsLinearVelMode Or RotatePosModeCfg1.IsRotatePosMode)

        Dim curspd As Double = CurSpeed(0)
        'Dim curFeedSpd = FeedbackSpeed(preTime, prePosT)

        If motionDirect = False Then
            curspd = -CurSpeed(0)
        End If

        'LinearChart1.plotCurve(curspd, curFeedSpd)

        LinearVelModeCfg1.LCurSpeed = CurSpeed(0)
        RotatePosModeCfg1.RCurSpeed = CurSpeed(1)

        PositionStatus1.LPosStatus = CurLPos()
        PositionStatus1.RPosStatus = CurRPos()

    End Sub

    Private Sub PositionStatus1_LPosReset(sender As Object, e As EventArgs) Handles PositionStatus1.LPosReset
        ResetLPos()
    End Sub

    Private Sub PositionStatus1_RPosReset(sender As Object, e As EventArgs) Handles PositionStatus1.RPosReset
        ResetRPos()
    End Sub

    Private Sub PositionStatus1_LPosGo(sender As Object, e As EventArgs) Handles PositionStatus1.LPosGo
        Start_1Axis_tr_move(0, PositionStatus1.LPosSet, 0, 30, 0.1, 0.1)
    End Sub

    Private Sub PositionStatus1_RPosGo(sender As Object, e As EventArgs) Handles PositionStatus1.RPosGo
        Start_1Axis_tr_move(1, PositionStatus1.RPosSet, 0, 30, 0.1, 0.1)
    End Sub

End Class
