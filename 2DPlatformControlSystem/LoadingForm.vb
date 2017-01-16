Public Class LoadingForm
    Private Sub LoadingForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ControlBox = False
        Dim tWait As Threading.Thread = New Threading.Thread(AddressOf WaitProcess)
        tWait.IsBackground = True
        tWait.Start()
    End Sub

    Private Sub WaitProcess()
        Dim card2005_num As Short = 0
        CalibrationDaq2005(card2005_num)

        'close the form
        Me.Invoke(DirectCast(Sub() Me.Close(), EventHandler))
    End Sub
End Class