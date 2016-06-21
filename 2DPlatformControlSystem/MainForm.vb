Public Class MainForm

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Me.Text = AppInfo.AssemblyName
        TabControl1.SelectedTab = tbAbout

        'intial 8158 and 2005 card
        initial_PCI8158()
        initial_DAQ2005()

    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected

        Dim tc As TabControl = sender
        If tc.SelectedTab.Name = tbTrdControl.Name Then
            TrdControlPanel1.tm.Enabled = True
        End If
    End Sub
End Class
