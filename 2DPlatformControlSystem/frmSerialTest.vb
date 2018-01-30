Public Class frmSerialTest
    Const pci8158 = 0

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Me.Text = AppInfo.AssemblyName

        'intial 8158

        'initial_PCI8158() 'To be uncommented and activated later for formal test

        TrdControlPanel_new1.tm.Enabled = True

    End Sub

    Private Sub frmSerialTest_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            B_8158_stop_move_all(0)
            B_8158_close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbTrdControl_Selected(sender As Object, e As TabControlEventArgs) Handles tbTrdControl.Selected
        Dim tc As TabControl = sender
        If tc.SelectedTab.Name = tbTrdControl.Name Then
            TrdControlPanel_new1.tm.Enabled = True
        End If
    End Sub
End Class