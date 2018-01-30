Public Class frmTest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSTART.Click
        SerialPort_Robin1.OpenSerialPort()
    End Sub

    Private Sub ENDbtn_Click(sender As Object, e As EventArgs) Handles btnEND.Click
        SerialPort_Robin1.ReleaseSP()
    End Sub
End Class