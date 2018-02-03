Imports System.Text
Public Class frmTest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSTART.Click
        SerialPort_Robin1.OpenSerialPort()

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