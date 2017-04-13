Public Class InfoDisp
    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        txtInfo.ContextMenuStrip = cmsTxtInfo
        txtInfo.ReadOnly = True
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtInfo.Clear()
    End Sub

    Sub AddInfo(info As String)
        txtInfo.AppendText("[" + Now.ToString("T") + "]" + info + vbCrLf)
    End Sub
End Class
