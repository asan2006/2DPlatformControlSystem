Public Class TrdControlPanel
    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        DaqCfg1.fileName = Application.StartupPath + "\ADLinkDaq"
        LoadCfgFile1.cfgFilePath = Application.StartupPath + "\Configure\"
    End Sub

    Private Sub LoadCfgFile1_CfgSet(fileName As String) Handles LoadCfgFile1.CfgSet
        'configure change event occured!!!
        Try

            Dim fullFileName As String = LoadCfgFile1.cfgFilePath + fileName
            Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
            Dim xlBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Open(fullFileName)
            Dim xlSheet As Microsoft.Office.Interop.Excel.Worksheet = xlBook.Worksheets(1)

            Dim motionMode As String = xlSheet.Range("B2").Value
            If motionMode = "TrdControl" Then
                'Verify the motion as right mode as the configure file

                LinearVelModeCfg1.IsLinearVelMode = xlSheet.Range("B3").Value
                LinearVelModeCfg1.LDelayTime = xlSheet.Range("B4").Value
                LinearVelModeCfg1.LTacc = xlSheet.Range("B5").Value
                LinearVelModeCfg1.LTdec = xlSheet.Range("B6").Value
                LinearVelModeCfg1.LMaxVel = xlSheet.Range("B7").Value
                LinearVelModeCfg1.LTunif = xlSheet.Range("B8").Value

                RotatePosModeCfg1.IsRotatePosMode = xlSheet.Range("B9").Value
                RotatePosModeCfg1.RDelayTime = xlSheet.Range("B10").Value
                RotatePosModeCfg1.RTacc = xlSheet.Range("B11").Value
                RotatePosModeCfg1.RTdec = xlSheet.Range("B12").Value
                RotatePosModeCfg1.RMaxVel = xlSheet.Range("B13").Value
                RotatePosModeCfg1.RDist = xlSheet.Range("B14").Value

                DaqCfg1.IsDaqEnable = xlSheet.Range("B15").Value
                DaqCfg1.ScanIntrv = xlSheet.Range("B16").Value
                DaqCfg1.ScanCount = xlSheet.Range("B17").Value
                DaqCfg1.aveNum = xlSheet.Range("B18").Value
                DaqCfg1.setChartOption = {xlSheet.Range("B19").Value,
                    xlSheet.Range("B20").Value,
                    xlSheet.Range("B21").Value,
                    xlSheet.Range("B22").Value}
                DaqCfg1.xlsHeader = {xlSheet.Range("B23").Value,
                    xlSheet.Range("B24").Value,
                    xlSheet.Range("B25").Value,
                    xlSheet.Range("B26").Value}
                DaqCfg1.expInfo = xlSheet.Range("B27").Value
                DaqCfg1.scanFileFormatMode = xlSheet.Range("B28").Value
                DaqCfg1.fileName = xlSheet.Range("B29").Value
            End If

            'Release excel application
            xlBook.Close()
            xlApp.Quit()
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlSheet)
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlBook)
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlApp)
            xlSheet = Nothing
            xlBook = Nothing
            xlApp = Nothing
            '资源回收放在调用过程之外
            'GC.Collect()
        Catch ex As Exception
            MessageBox.Show("Can't creat excel object, confirm your computer has installed the excel...")
        End Try
    End Sub

    Private Sub btnMotion_Click(sender As Object, e As EventArgs) Handles btnMotion.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application
        Dim xlBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add(True)
        Dim xlSheet As Microsoft.Office.Interop.Excel.Worksheet = xlBook.Worksheets.Add()
        Dim fullFileName As String = System.IO.Path.GetFullPath(DaqCfg1.fileName) & ".xlsx"
        'Use it more than office 2007 version, And add the Extension name ".xlsx"
        xlApp.DisplayAlerts = False
        xlBook.SaveAs(fullFileName)

        'Release excel application
        xlBook.Close()
        xlApp.Quit()
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlSheet)
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlBook)
        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlApp)
        xlSheet = Nothing
        xlBook = Nothing
        xlApp = Nothing
        GC.Collect()

    End Sub
End Class
