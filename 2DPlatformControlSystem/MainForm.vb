Public Class MainForm

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Me.Text = AppInfo.AssemblyName


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim test As Boolean()
        'test = {8, 0, 10, 0}
        'DaqAcqCfg1.chartOption = test

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'MsgBox(DaqAcqCfg1.strLineChart)
    End Sub
End Class
