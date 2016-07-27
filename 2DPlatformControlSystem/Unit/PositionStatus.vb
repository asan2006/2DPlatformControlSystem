Public Class PositionStatus

    Public WriteOnly Property LPosStatus As Double
        Set(ByVal value As Double)
            txtLPosStatus.Text = value.ToString
        End Set
    End Property

    Public WriteOnly Property RPosStatus As Double
        Set(value As Double)
            txtRPosStatus.Text = value.ToString
        End Set
    End Property

    Public ReadOnly Property LPosSet As Double
        Get
            Return CDbl(txtLPosSet.Text)
        End Get
    End Property

    Public ReadOnly Property RPosSet As Double
        Get
            Return CDbl(txtRPosSet.Text)
        End Get
    End Property

    Public Event LPosReset(ByVal sender As Object, ByVal e As EventArgs)
    Public Event RPosReset(ByVal sender As Object, ByVal e As EventArgs)
    Public Event LPosGo(ByVal sender As Object, ByVal e As EventArgs)
    Public Event RPosGo(ByVal sender As Object, ByVal e As EventArgs)

    Private Sub btnLPosReset_Click(sender As Object, e As EventArgs) Handles btnLPosReset.Click
        RaiseEvent LPosReset(sender, e)
    End Sub

    Private Sub btnRPosReset_Click(sender As Object, e As EventArgs) Handles btnRPosReset.Click
        RaiseEvent RPosReset(sender, e)
    End Sub

    Private Sub btnLPosGo_Click(sender As Object, e As EventArgs) Handles btnLPosGo.Click
        RaiseEvent LPosGo(sender, e)
    End Sub

    Private Sub btnRPosGo_Click(sender As Object, e As EventArgs) Handles btnRPosGo.Click
        RaiseEvent RPosGo(sender, e)
    End Sub
End Class
