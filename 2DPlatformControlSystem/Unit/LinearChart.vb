Public Class LinearChart
    Private dbInput As New List(Of Double)
    Private dbFeedback As New List(Of Double)
    Public Sub plotCurve(ByVal inputSpeed As Double, ByVal feedbackSpeed As Double)
        Try
            'chtCurve.Series(0).Points.AddY(inputSpeed)
            'chtCurve.Series(1).Points.AddY(feedbackSpeed)

            '优化内存，Points.AddY方法太耗CPU和内存
            If dbInput.Count >= 100 Then
                dbInput.RemoveAt(0)
                dbFeedback.RemoveAt(0)
            End If
            dbInput.Add(inputSpeed)
            dbFeedback.Add(feedbackSpeed)
            chtCurve.Series(0).Points.DataBindY(dbInput)
            chtCurve.Series(1).Points.DataBindY(dbFeedback)

            ''滚动X轴
            'If chtCurve.Series(0).Points.Count > 100 Then
            '    chtCurve.ChartAreas(0).AxisX.Minimum = chtCurve.Series(0).Points.Count - 100
            '    chtCurve.ChartAreas(0).AxisX.Maximum = chtCurve.Series(0).Points.Count
            'End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
