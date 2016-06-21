using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Gpio;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly GpioPin _ledPin;
        public MainPage()
        {
            this.InitializeComponent();
            GpioController gpioController = GpioController.GetDefault();
            _ledPin = gpioController.OpenPin(4);
            _ledPin.SetDriveMode(GpioPinDriveMode.Output);
        }

        private void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            _ledPin.Write(toggleSwitch.IsOn ? GpioPinValue.High : GpioPinValue.Low);
        }
    }
}
