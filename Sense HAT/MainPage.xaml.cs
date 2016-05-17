using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Sense_HAT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            //RPi.SenseHat.Demo.DemoRunner.Run(senseHat => new RPi.SenseHat.Demo.Demos.DiscoLights(senseHat, this));
            //RPi.SenseHat.Demo.DemoRunner.Run(senseHat => new RPi.SenseHat.Demo.Demos.JoystickPixel(senseHat, this));
            //RPi.SenseHat.Demo.DemoRunner.Run(senseHat => new RPi.SenseHat.Demo.Demos.SingleColorScrollText(senseHat, this, "Gopas TechEd"));
            //RPi.SenseHat.Demo.DemoRunner.Run(senseHat => new RPi.SenseHat.Demo.Demos.GammaTest(senseHat, this));
        }

        public void SetScreenText(string s)
        {
        }
    }
}