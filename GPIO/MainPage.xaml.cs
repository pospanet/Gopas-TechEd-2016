using System;
using Windows.Devices.Gpio;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GPIO
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly GpioPin _ledPin;
        private readonly GpioPin _switchPin;


        public MainPage()
        {
            InitializeComponent();
            GpioController gpioController = GpioController.GetDefault();
            _ledPin = gpioController.OpenPin(4);
            _ledPin.SetDriveMode(GpioPinDriveMode.Output);
            _switchPin = gpioController.OpenPin(27);
            _switchPin.SetDriveMode(GpioPinDriveMode.Input);
            DispatcherTimer timer = new DispatcherTimer {Interval = TimeSpan.FromMilliseconds(100)};
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, object e)
        {
            _ledPin.Write(_switchPin.Read());
        }

        private void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            _ledPin.Write(toggleSwitch.IsOn ? GpioPinValue.High : GpioPinValue.Low);
        }
    }
}