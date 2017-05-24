Imports System.ComponentModel
Public Class ContinueMotionPanel

    Const card8158 As Short = 0
    Const card2005 As Short = 0

    'preTime/prePos used to calc feedback speed
    'Dim preTime As DateTime
    Dim preTime As Long = 0
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

    'Is feedback data acquired
    Dim isFeedback As Boolean = False
    Dim arrayFeedback(,) As Double

    Dim LstrVel As Double
    Dim LmaxVel As Double
    Dim LTacc As Double
    Dim LTdec As Double
    Dim LDist As Double
    Dim LTdelay As Double
    Dim RstrVel As Double
    Dim RmaxVel As Double
    Dim RTacc As Double
    Dim RTdec As Double
    Dim RTdelay As Double
    Dim RDist As Double
    Dim axis As Short

    Dim motionMode As M_MODE
    'targetPos is used for velocity motion mode to stop motion at target position
    Dim targetPos As Double

    Public MotionThread As System.Threading.Thread
    Dim motionDirect As Boolean = True  'when value is true ,motion speed is positive;else is negative

    Dim posModeCfgList As BindingList(Of frmContinueMotion) = New BindingList(Of frmContinueMotion)

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        DaqCfg1.fileName = "ADlinkDaq"
        dgvCfg.AutoGenerateColumns = False
        dgvCfg.DataSource = posModeCfgList
        dgvCfg.Columns("cLinearPosMode").DataPropertyName = "strLineCfg"
        dgvCfg.Columns("cRotatePosMode").DataPropertyName = "strRotCfg"

    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
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
        Dim TimeBase As Integer = 40000000
        If DaqCfg1.IsDaqEnable Then

            StartDAQ(card2005, ScanIntrv, ScanCount, ADChanCount, DaqCfg1.scanFileFormatMode, DaqCfg1.fileName)

        End If

        'intial preCount after start 2005 card
        QueryPerformanceCounter(preCount)

        'if DAQ2005 enable, then acquire the feedback data
        If DaqCfg1.IsDaqEnable And False Then
            isFeedback = True
        Else
            isFeedback = False
        End If
        ReDim arrayFeedback(0, 2)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'avoid invoke method
        aveNum = DaqCfg1.aveNum
        expInfo = DaqCfg1.expInfo
        fileName = DaqCfg1.fileName
        xlsHeader = DaqCfg1.xlsHeader
        Dt = ScanIntrv / TimeBase * aveNum
        MotionThread = New System.Threading.Thread(AddressOf MotionStart)
        'set threading apartment state as sta mode , so can handle the xlsx file for the data to store
        MotionThread.SetApartmentState(Threading.ApartmentState.STA)
        MotionThread.Start()
    End Sub

    Private Sub MotionStart()
        motionStatus = True         'Begin to move , and bengin to acquire decode data

        Dim stepCount As Integer = posModeCfgList.Count
        For i = 1 To stepCount

            If Not IsNothing(posModeCfgList(i - 1).LineCfg) And Not IsNothing(posModeCfgList(i - 1).RotCfg) Then
                '二轴都有
                axis = 2
            ElseIf Not IsNothing(posModeCfgList(i - 1).RotCfg) Then
                '只有转动轴
                axis = 1

                RTdelay = posModeCfgList(i - 1).RotCfg.nullTime
                RTacc = posModeCfgList(i - 1).RotCfg.accTime
                RTdec = posModeCfgList(i - 1).RotCfg.decTime
                RstrVel = 0
                RmaxVel = posModeCfgList(i - 1).RotCfg.maxSpeed
                RDist = posModeCfgList(i - 1).RotCfg.dist

                '先暂停
                System.Threading.Thread.Sleep(RTdelay * 1000)
                Start_1Axis_tr_move(axis, RDist, RstrVel, RmaxVel, RTacc, RTdec)
            Else
                '只有平动轴
                axis = 0

                LTdelay = posModeCfgList(i - 1).LineCfg.nullTime
                LTacc = posModeCfgList(i - 1).LineCfg.accTime
                LTdec = posModeCfgList(i - 1).LineCfg.decTime
                LstrVel = 0
                LmaxVel = posModeCfgList(i - 1).LineCfg.maxSpeed
                LDist = posModeCfgList(i - 1).LineCfg.dist
            End If

            'waitting for axis stop motion
            While Not isStopMotion()
                System.Threading.Thread.Sleep(50)
            End While

        Next

        motionStatus = False        'Move is over , and stop to acquire decode data

        'clear daq-2005 card async buffer
        ClearDaq2005Async(card2005)

        If DaqCfg1.IsDaqEnable And DaqCfg1.scanFileFormatMode = "XLS" Then
            'SAVE DATA AND SOME INFO
            dataToXLSX(xlsHeader, InBuf, aveNum, expInfo, fileName, DaqCfg1.strLineChart, arrayFeedback)
        End If

    End Sub

    Private Sub ADDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem.Click
        Dim fAdd As New frmContinueMotion
        fAdd.ShowDialog()
        If fAdd.DialogResult = DialogResult.OK Then
            If Not IsNothing(fAdd.LineCfg) Or Not IsNothing(fAdd.RotCfg) Then
                posModeCfgList.Add(fAdd)
            End If
        End If
    End Sub

    Private Sub EDITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITToolStripMenuItem.Click
        If dgvCfg.SelectedRows.Count > 0 Then
            Dim fEdit As frmContinueMotion = posModeCfgList(dgvCfg.SelectedRows(0).Index)
            fEdit.ShowDialog()

            If fEdit.DialogResult = DialogResult.OK Then
                posModeCfgList(dgvCfg.SelectedRows(0).Index) = fEdit
            End If
        End If
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        If dgvCfg.SelectedRows.Count > 0 Then
            posModeCfgList.RemoveAt(dgvCfg.SelectedRows(0).Index)
        End If
    End Sub

    Private Sub dgvCfg_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgvCfg.RowStateChanged
        '显示行号
        e.Row.HeaderCell.Value = (e.Row.Index + 1).ToString
    End Sub

    Private Sub tm1_Tick(sender As Object, e As EventArgs) Handles tm1.Tick
        btnStart.Enabled = Not motionStatus

        '如果运动停止，但2005卡仍正在取数据，按钮不可用
        If Not IsNothing(MotionThread) Then
            If MotionThread.IsAlive Then
                btnStart.Enabled = False
            End If
        End If

        Dim curspd As Double = CurSpeed(0)

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

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        btnStop_Click(Nothing, Nothing)

        If Not IsNothing(MotionThread) Then
            Try
                MotionThread.Abort()
            Catch ex As Exception

            End Try
        End If

        B_8158_close()
        D2K_Release_Card(card2005)

        Me.ParentForm.Close()
    End Sub
End Class
