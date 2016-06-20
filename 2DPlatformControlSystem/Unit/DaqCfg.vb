Public Class DaqCfg

    Public Property IsDaqEnable As Boolean
        Get
            Return chkDaq2005Enable.Checked
        End Get
        Set(value As Boolean)
            chkDaq2005Enable.Checked = value
        End Set
    End Property

    Public Property ScanIntrv As Integer
        Get
            Return CInt(cboScanInterval.Text)
        End Get
        Set(value As Integer)
            cboScanInterval.Text = value
        End Set
    End Property

    Public Property ScanCount As Integer
        Get
            Return CInt(cboDataSize.Text)
        End Get
        Set(value As Integer)
            cboDataSize.Text = value
        End Set
    End Property

    Public Property aveNum As Integer
        Get
            Return CInt(cboNumOfAve.Text)
        End Get
        Set(value As Integer)
            cboNumOfAve.Text = value
        End Set
    End Property

    Public Property ADChanCount As Integer
        Get
            Return 4
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property expInfo As String
        Get
            Return txtExpCondition.Text
        End Get
        Set(value As String)
            txtExpCondition.Text = value
        End Set
    End Property

    Public Property scanFileFormatMode As String
        Get
            If rdDAT.Checked Then
                Return "DAT"
            Else
                Return "XLS"
            End If
        End Get
        Set(value As String)
            If value = "DAT" Then
                rdDAT.Checked = True
            ElseIf value = "XLS" Then
                rdXLS.Checked = True
            End If
        End Set
    End Property

    Public Property fileName As String
        Get
            Return txtFileToSave.Text
        End Get
        Set(value As String)
            txtFileToSave.Text = value
        End Set
    End Property

    Public Property xlsHeader As String()
        Get
            Return {txtxlsHeaderCH_1.Text, txtxlsHeaderCH_2.Text, txtxlsHeaderCH_3.Text, txtxlsHeaderCH_4.Text}
        End Get
        Set(value As String())
            txtxlsHeaderCH_1.Text = value(0)
            txtxlsHeaderCH_2.Text = value(1)
            txtxlsHeaderCH_3.Text = value(2)
            txtxlsHeaderCH_4.Text = value(3)
        End Set
    End Property

    Public ReadOnly Property strLineChart As String
        Get
            Dim s As String = Nothing
            If ChkCH_1.Checked Then
                If IsNothing(s) Then
                    s = ChkCH_1.Tag.ToString
                Else
                    s = s + "," + ChkCH_1.Tag.ToString
                End If
            End If

            If ChkCH_2.Checked Then
                If IsNothing(s) Then
                    s = ChkCH_2.Tag.ToString
                Else
                    s = s + "," + ChkCH_2.Tag.ToString
                End If
            End If

            If ChkCH_3.Checked Then
                If IsNothing(s) Then
                    s = ChkCH_3.Tag.ToString
                Else
                    s = s + "," + ChkCH_3.Tag.ToString
                End If
            End If

            If ChkCH_4.Checked Then
                If IsNothing(s) Then
                    s = ChkCH_4.Tag.ToString
                Else
                    s = s + "," + ChkCH_4.Tag.ToString
                End If
            End If
            Return s
        End Get
    End Property

    Public WriteOnly Property setChartOption As Boolean()
        Set(value As Boolean())
            ChkCH_1.Checked = value(0)
            ChkCH_2.Checked = value(1)
            ChkCH_3.Checked = value(2)
            ChkCH_4.Checked = value(3)
        End Set
    End Property

    'Public appPath As String

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        ChkCH_1.Tag = "A:A"
        ChkCH_2.Tag = "B:B"
        ChkCH_3.Tag = "C:C"
        ChkCH_4.Tag = "D:D"

        txtFileToSave.Text = Application.StartupPath + "\ADLinkDaq"
    End Sub


    Private Sub cboScanInterval_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboScanInterval.SelectedIndexChanged
        If IsNumeric(cboScanInterval.Text) Then
            Dim ScanRate As Long
            ScanRate = 40000000 / CInt(cboScanInterval.Text)
            lblScanRate.Text = "Scan rate(" & ScanRate & ") = " & vbCrLf &
                "Timebase(40,000,000)" & vbCrLf &
                "/Scan interval(" & cboScanInterval.Text & ")"
        End If
    End Sub

    Private Sub rdDAT_CheckedChanged(sender As Object, e As EventArgs) Handles rdDAT.CheckedChanged
        If rdDAT.Checked Then
            cboNumOfAve.Enabled = False
            ChkCH_1.Enabled = False
            ChkCH_2.Enabled = False
            ChkCH_3.Enabled = False
            ChkCH_4.Enabled = False
            txtxlsHeaderCH_1.Enabled = False
            txtxlsHeaderCH_2.Enabled = False
            txtxlsHeaderCH_3.Enabled = False
            txtxlsHeaderCH_4.Enabled = False
            txtExpCondition.Enabled = False
        Else
            cboNumOfAve.Enabled = True
            ChkCH_1.Enabled = True
            ChkCH_2.Enabled = True
            ChkCH_3.Enabled = True
            ChkCH_4.Enabled = True
            txtxlsHeaderCH_1.Enabled = True
            txtxlsHeaderCH_2.Enabled = True
            txtxlsHeaderCH_3.Enabled = True
            txtxlsHeaderCH_4.Enabled = True
            txtExpCondition.Enabled = True
        End If
    End Sub
End Class
