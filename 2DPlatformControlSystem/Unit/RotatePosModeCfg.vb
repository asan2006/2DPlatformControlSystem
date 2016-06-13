Public Class RotatePosModeCfg
    Public Property RDelayTime As Double
        Get
            Return CDbl(txtRDelayTime.Text)
        End Get
        Set(value As Double)
            txtRDelayTime.Text = value.ToString
        End Set
    End Property

    Public Property RTacc As Double
        Get
            Return CDbl(txtRAccTime.Text)
        End Get
        Set(value As Double)
            txtRAccTime.Text = value.ToString
        End Set
    End Property

    Public Property RTdec As Double
        Get
            Return CDbl(txtRDecTime.Text)
        End Get
        Set(value As Double)
            txtRDecTime.Text = value.ToString
        End Set
    End Property

    Public Property RStrVel As Double
        Get
            Return 0
        End Get
        Set(value As Double)

        End Set
    End Property

    Public Property RMaxVel As Double
        Get
            Return CDbl(txtRMaxSpeed.Text)
        End Get
        Set(value As Double)
            txtRMaxSpeed.Text = value.ToString
        End Set
    End Property

    Public Property RDist As Double
        Get
            Return CDbl(txtRDist.Text)
        End Get
        Set(value As Double)
            txtRDist.Text = value.ToString
        End Set
    End Property

    Public Property RCurSpeed As Double
        Get
            Return CDbl(txtRCurSpeed.Text)
        End Get
        Set(value As Double)
            txtRCurSpeed.Text = value.ToString
        End Set
    End Property

    Public Property IsRotatePosMode As Boolean
        Get
            Return chkRMode.Checked
        End Get
        Set(value As Boolean)
            chkRMode.Checked = value
        End Set
    End Property

End Class
