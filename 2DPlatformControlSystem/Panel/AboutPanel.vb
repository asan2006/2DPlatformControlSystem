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

Automation Function:
1. Automate test for TrdControl2;
2. Automate test for iTest, aTest, cTest;
3. Configure file is xlsx or Configure files infomation in txt file to drag.

ConMotion Function:
1. Continue Rotate(Linear) Motion Test by position mode;
2. Test for eTest, i2Test;
3. Note use calibration Daq2005 function in TrdControl2 before test.

"
    End Sub
End Class
