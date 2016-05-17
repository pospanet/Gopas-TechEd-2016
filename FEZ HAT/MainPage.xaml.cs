using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using GHIElectronics.UWP.Shields;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FEZ_HAT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private FEZHAT fezHat;

        public MainPage()
        {
            InitializeComponent();
            InitFezHat();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, object e)
        {
            if (fezHat.IsDIO18Pressed())
            {
                fezHat.D2.Color = FEZHAT.Color.White;
            }
            else
            {
                fezHat.D2.TurnOff();
            }
            if (fezHat.IsDIO22Pressed())
            {
                fezHat.D3.Color = FEZHAT.Color.White;
            }
            else
            {
                fezHat.D3.TurnOff();
            }
        }

        private async Task InitFezHat()
        {
            fezHat = await FEZHAT.CreateAsync();
        }
    }
}