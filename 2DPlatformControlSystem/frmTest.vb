Imports System.Text
Public Class frmTest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSTART.Click
        Dim sb As StringBuilder = New StringBuilder("asdfa")
        Dim r = parseSB(sb)
        If r IsNot Nothing Then
            For Each ele As Double In r
                MsgBox(ele)
            Next
        End If

        Dim a = "i<1,1,2,3,4>i" + vbCrLf + "i<1,1,2,3,4>i"
        MsgBox(a.Replace("i<", "").Replace(">i", "").Replace(",", vbTab))

    End Sub

    Private Sub ENDbtn_Click(sender As Object, e As EventArgs) Handles btnEND.Click
        SerialPort_Robin1.ReleaseSP()
    End Sub

    Function parseSB(ByVal s As StringBuilder) As Double()
        If s.Length < 10 Then
            Return Nothing
        Else
            Return {1, 2, 3}
        End If
    End Function
End Class