Public Class frmContinueMotion
    Public LineCfg As PosModeCfg
    Public RotCfg As PosModeCfg
    Private _strLineCfg As String
    Private _strRotCfg As String

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub frmContinueMotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '窗体载入
        RotatePosModeCfg1.RDelayTime = 1
        RotatePosModeCfg1.RTacc = 0.1
        RotatePosModeCfg1.RTdec = 0.1

        '设置按钮的窗体返回结果
        btnSave.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If LinearPosModeCfg1.IsLinearPosMode Then
            LineCfg = New PosModeCfg
            LineCfg.nullTime = LinearPosModeCfg1.LDelayTime
            LineCfg.accTime = LinearPosModeCfg1.LTacc
            LineCfg.decTime = LinearPosModeCfg1.LTdec
            LineCfg.maxSpeed = LinearPosModeCfg1.LMaxVel
            LineCfg.dist = LinearPosModeCfg1.LDist
            _strLineCfg = LineCfg.strCfg
        End If
        If RotatePosModeCfg1.IsRotatePosMode Then
            RotCfg = New PosModeCfg
            RotCfg.nullTime = RotatePosModeCfg1.RDelayTime
            RotCfg.accTime = RotatePosModeCfg1.RTacc
            RotCfg.decTime = RotatePosModeCfg1.RTdec
            RotCfg.maxSpeed = RotatePosModeCfg1.RMaxVel
            RotCfg.dist = RotatePosModeCfg1.RDist
            _strRotCfg = RotCfg.strCfg
        End If

    End Sub

    Public ReadOnly Property strLineCfg As String
        Get
            Return _strLineCfg
        End Get
    End Property

    Public ReadOnly Property strRotCfg As String
        Get
            Return _strRotCfg
        End Get
    End Property

End Class