Imports System.IO
Imports System.Text

Public Class CfgListBox
    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        lbConfigFile.ScrollAlwaysVisible = True
        lbConfigFile.HorizontalScrollbar = True
        lbConfigFile.AllowDrop = True
        lbConfigFile.ContextMenuStrip = cmsListConfig
    End Sub

    ReadOnly Property autoCfgArray As String()
        Get
            Dim n As Integer = lbConfigFile.Items.Count
            Dim strArray(n - 1) As String
            For i As Integer = 0 To n - 1
                strArray(i) = lbConfigFile.Items(i).ToString
            Next
            Return strArray
        End Get
    End Property

    Public Sub SetSelectIndex(i As Integer)
        If i < lbConfigFile.Items.Count Then
            lbConfigFile.SelectedIndex = i
        End If
    End Sub

    Private Sub lbConfigFile_DragEnter(sender As Object, e As DragEventArgs) Handles lbConfigFile.DragEnter
        Dim isTxtFile As Boolean = False

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim path = CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString
            Dim ext = System.IO.Path.GetExtension(path)
            If ext = ".txt" Then
                isTxtFile = True
            End If
        End If

        If isTxtFile Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub lbConfigFile_DragDrop(sender As Object, e As DragEventArgs) Handles lbConfigFile.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim path = CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString
            Dim ext = System.IO.Path.GetExtension(path)
            'txt file store the config file full path
            If ext = ".txt" Then
                lbConfigFile.Items.Clear()
                Dim sr As StreamReader = New StreamReader(path, Encoding.Default)
                Dim line As String
                'add every line in the txt file
                While True
                    line = sr.ReadLine
                    If line IsNot Nothing Then
                        lbConfigFile.Items.Add(line)
                    Else
                        sr.Dispose()
                        Exit While
                    End If
                End While
            End If
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        If ofdConfig.ShowDialog = DialogResult.OK Then
            lbConfigFile.Items.Add(ofdConfig.FileName)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If lbConfigFile.SelectedIndex >= 0 Then
            lbConfigFile.Items.Remove(lbConfigFile.SelectedItem)
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lbConfigFile.Items.Clear()
    End Sub
End Class
