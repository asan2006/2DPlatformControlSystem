Imports System.IO
Public Class LoadCfgFile
    Public cfgFilePath As String
    Private strCboIndex0 As String = "Refresh file list"
    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        cboCfgList.SelectedIndex = 0

    End Sub
    Private Sub btnLoadCfg_Click(sender As Object, e As EventArgs) Handles btnLoadCfg.Click
        If cboCfgList.Text = strCboIndex0 Then
            cboCfgList.Items.Clear()
            cboCfgList.Items.Add(strCboIndex0)

            For Each f As String In Directory.GetFiles(cfgFilePath)
                If Path.GetExtension(f) = ".xls" Or Path.GetExtension(f) = ".xlsx" Then
                    'congifure file save as xls or xlsx
                    'add in the file list
                    cboCfgList.Items.Add(Path.GetFileName(f))
                End If
            Next

            cboCfgList.SelectedIndex = 0
            Exit Sub
        End If

        RaiseEvent CfgSet(cboCfgList.Text)
        '注意在这里进行资源回收，否则在CfgSet函数内进行资源回收，无法结束excel进程
        GC.Collect()
    End Sub

    Public Event CfgSet(ByVal fileName As String)
End Class
