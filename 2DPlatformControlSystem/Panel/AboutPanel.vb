Public Class AboutPanel
    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        txtAbout.Text = "
Note: Please operate Daq Self-Calibration at TrdControl panel, before data acquired!!!

TrdControl Function:
1. Linear motion as Velocity Mode;
2. Rotate motion as Positon Mode;
3. Using for iTest, aTest, cTest for sensor.

TrdControl2 Function:
1. Linear motion as Positon Mode;
2. Rotate motion as Positon Mode;
3. Beta(Using for iTest, aTest, cTest for sensor).

TiltStep Function:
1. Tilt Step test for ATxxVx.xx;
2. Every tile step loop will avereged to one data;
3. Can test 4 sensor samples synchronize, if the fixture allowed;

"
    End Sub
End Class
