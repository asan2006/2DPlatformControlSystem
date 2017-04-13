Public Class AutomationPanel
    Dim cfgList As String()
    Dim AutoRunThread As System.Threading.Thread
    Dim isMotionThreadAlive As Boolean = False
    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        InfoDisp1.AddInfo("Use for TrdControl2 AUTOMATION")
    End Sub

    Private Sub btnAutoRun_Click(sender As Object, e As EventArgs) Handles btnAutoRun.Click
        'motionPanel =
        cfgList = CfgListBox1.autoCfgArray
        If cfgList.Count = 0 Then
            Exit Sub
        End If

        AutoRunThread = New Threading.Thread(AddressOf AutoStart)
        'set threading apartment state as sta mode , so can handle the xlsx file for the data to store
        'AutoRunThread.SetApartmentState(Threading.ApartmentState.STA)
        AutoRunThread.Start()

    End Sub

    Private Sub AutoStart()

        'loop every cfg file to motion use TrdControl2
        Dim n As Integer = cfgList.Count
        For i As Integer = 0 To n - 1
            Dim directoryName = System.IO.Path.GetDirectoryName(cfgList(i))
            Dim fileName = System.IO.Path.GetFileName(cfgList(i))
            '跨线程调用方法
            '加载配置文件
            Me.Invoke(DirectCast(Sub()
                                     My.Forms.MainForm.TrdControlPanel2.LoadCfgFile1.cfgFilePath = directoryName
                                     My.Forms.MainForm.TrdControlPanel2.LoadCfgFile1_CfgSet(fileName)

                                     '注意在这里进行excel进程的资源回收，否则无法结束excel进程
                                     GC.Collect()
                                     CfgListBox1.SetSelectIndex(i)
                                     InfoDisp1.AddInfo("Begin Motion: " + fileName)
                                 End Sub, EventHandler))
            '开始测试
            Me.Invoke(DirectCast(Sub()
                                     My.Forms.MainForm.TrdControlPanel2.btnMotion_Click(Nothing, Nothing)
                                 End Sub, EventHandler))
            '判断数据是否采集完了
            System.Threading.Thread.Sleep(1000) '暂停一段时间等待进入子线程
            While isMotionThreadAlive
                System.Threading.Thread.Sleep(500)
            End While

            '完成测试和数据采集
            Me.Invoke(DirectCast(Sub()
                                     InfoDisp1.AddInfo("Complete Motion: " + fileName)
                                 End Sub, EventHandler))
        Next
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        If AutoRunThread.IsAlive Then
            Try
                AutoRunThread.Abort()
                InfoDisp1.AddInfo("STOP auto test!")
            Catch ex As Exception

            End Try
        End If
        My.Forms.MainForm.TrdControlPanel2.btnStop_Click(sender, e)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        My.Forms.MainForm.TrdControlPanel2.btnQuit_Click(sender, e)
    End Sub

    Private Sub tm_Thread_Tick(sender As Object, e As EventArgs) Handles tm_Thread.Tick
        '监控TrdControl2的运动进程
        If My.Forms.MainForm.TrdControlPanel2.MotionThread IsNot Nothing Then
            If My.Forms.MainForm.TrdControlPanel2.MotionThread.IsAlive Then
                isMotionThreadAlive = True
            Else
                isMotionThreadAlive = False
            End If
        Else
            isMotionThreadAlive = False
        End If

        '监控Automation进行
        If AutoRunThread IsNot Nothing Then
            btnAutoRun.Enabled = Not AutoRunThread.IsAlive
        Else
            btnAutoRun.Enabled = True
        End If

    End Sub
End Class
