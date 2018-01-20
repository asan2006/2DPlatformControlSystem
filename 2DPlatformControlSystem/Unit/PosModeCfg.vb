Public Class PosModeCfg
    ''' <summary>
    ''' 运动前标定时间，单位S
    ''' </summary>
    Public nullTime As Double

    ''' <summary>
    ''' 加速时间，单位S
    ''' </summary>
    Public accTime As Double

    ''' <summary>
    ''' 减速时间，单位S
    ''' </summary>
    Public decTime As Double

    ''' <summary>
    ''' 最大速度，单位mm/s或deg/s
    ''' </summary>
    Public maxSpeed As Double

    ''' <summary>
    ''' 运动距离，单位mm或deg
    ''' </summary>
    Public dist As Double


    ''' <summary>
    ''' 显示的配置字符串
    ''' </summary>
    Public ReadOnly Property strCfg() As String
        Get
            Return nullTime & "," & accTime & "," & decTime & "," & maxSpeed & "," & dist
        End Get
    End Property
End Class
