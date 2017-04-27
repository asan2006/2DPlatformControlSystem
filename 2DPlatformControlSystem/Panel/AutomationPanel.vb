Imports System.Text.RegularExpressions
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

        cfgList = CfgListBox1.autoCfgArray
        If cfgList.Count = 0 Then
            Exit Sub
        End If

        '从TrdControl2的运行按钮状态来判断是否可以运行
        If Not My.Forms.MainForm.TrdControlPanel2.btnMotion.Enabled Then
            InfoDisp1.AddInfo("Can not Motion, Please Check Driver intial!")
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
        Dim i As Integer
        For i = 0 To n - 1
            '挂起线程关键词：比如“SUSPEND_10_SECONDE”,表示挂起10S
            '正则表达式判断匹配
            Dim suspendPattern = "^\bSUSPEND_(\d*)_SECONDE\b"
            If Regex.IsMatch(cfgList(i), suspendPattern, RegexOptions.IgnoreCase) Then
                '跨线程调用方法
                Me.Invoke(DirectCast(Sub()
                                         CfgListBox1.SetSelectIndex(i)
                                         InfoDisp1.AddInfo("Begin Motion: " + cfgList(i))
                                     End Sub, EventHandler))

                Dim suspendTime = CInt(Regex.Match(cfgList(i), suspendPattern).Groups(1).Value)
                System.Threading.Thread.Sleep(suspendTime * 1000) '等待N秒，用来矫正传感器数据

                '完成
                Me.Invoke(DirectCast(Sub()
                                         InfoDisp1.AddInfo("Complete Motion: " + cfgList(i))
                                     End Sub, EventHandler))

            Else
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
            End If
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

    Private Sub btnCheckListItem_Click(sender As Object, e As EventArgs) Handles btnCheckListItem.Click
        Dim exceptKeys = "^\bSUSPEND_(\d*)_SECONDE\b"
        InfoDisp1.AddInfo(CheckFileListValidity(exceptKeys))
    End Sub
    ''' <summary>
    ''' 正则表达式判断文件列表有效性
    ''' </summary>
    ''' <param name="exceptKeys"></param>
    ''' <returns></returns>
    Private Function CheckFileListValidity(exceptKeys As String)

        cfgList = CfgListBox1.autoCfgArray
        Dim n As Integer = cfgList.Count
        Dim i As Integer
        '如果列表为空
        If n < 1 Then
            Return "No Item Exit, Please check again!"
            Exit Function
        End If

        For i = 0 To n - 1
            '正则表达式判断匹配,除去关键词外的文件路径检测
            If Not Regex.IsMatch(cfgList(i), exceptKeys, RegexOptions.IgnoreCase) Then
                If Not System.IO.File.Exists(cfgList(i)) Then
                    Return cfgList(i) + " is NOT EXIT, Please check it!"
                    Exit Function
                End If
            End If
        Next

        Return "Congratulations! All List Item is OK!"
    End Function
End Class
