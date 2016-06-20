Public Class LinearChart
    Public Sub plotCurve(ByVal inputSpeed As Double, ByVal feedbackSpeed As Double)

        chtCurve.Series(0).Points.AddY(inputSpeed)
        chtCurve.Series(1).Points.AddY(feedbackSpeed)

        '滚动X轴
        If chtCurve.Series(0).Points.Count > 100 Then
            chtCurve.ChartAreas(0).AxisX.Minimum = chtCurve.Series(0).Points.Count - 100
            chtCurve.ChartAreas(0).AxisX.Maximum = chtCurve.Series(0).Points.Count
        End If
    End Sub
End Class
