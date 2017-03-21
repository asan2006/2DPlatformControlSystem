Public Class LinearPosModeCfg
    Public Property LDelayTime As Double
        Get
            Return CDbl(txtLDelayTime.Text)
        End Get
        Set(value As Double)
            txtLDelayTime.Text = value.ToString
        End Set
    End Property

    Public Property LStrVel As Double
        Get
            Return 0
        End Get
        Set(value As Double)

        End Set
    End Property

    Public Property LMaxVel As Double
        Get
            Return CDbl(txtLMaxSpeed.Text)
        End Get
        Set(value As Double)
            txtLMaxSpeed.Text = value.ToString
        End Set
    End Property

    Public Property LTacc As Double
        Get
            Return CDbl(txtLAccTime.Text)
        End Get
        Set(value As Double)
            txtLAccTime.Text = value.ToString
        End Set
    End Property

    Public Property LTdec As Double
        Get
            Return CDbl(txtLDecTime.Text)
        End Get
        Set(value As Double)
            txtLDecTime.Text = value.ToString
        End Set
    End Property

    Public Property LDist As Double
        Get
            Return CDbl(txtLDist.Text)
        End Get
        Set(value As Double)
            txtLDist.Text = value.ToString
        End Set
    End Property

    Public Property LCurSpeed As Double
        Get
            Return CDbl(txtLCurSpeed.Text)
        End Get
        Set(value As Double)
            txtLCurSpeed.Text = value.ToString
        End Set
    End Property

    Public Property IsLinearVelMode As Boolean
        Get
            Return chkLMode.Checked
        End Get
        Set(value As Boolean)
            chkLMode.Checked = value
        End Set
    End Property

End Class
