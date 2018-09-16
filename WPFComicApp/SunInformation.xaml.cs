using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFComicApp
{
    /// <summary>
    /// Interaction logic for SunInformation.xaml
    /// </summary>
    public partial class SunInformation : Window
    {
        public SunInformation()
        {
            InitializeComponent();
        }

        private async void LoanSunInfo_Click(object sender, RoutedEventArgs e)
        {
            var sunInfo = await SunProcessor.LoadSunInformation();
            sunriseText.Text = $"Sunrise is at {sunInfo.Sunrise.ToLocalTime().ToString()}";
            sunsetText.Text = $"Sunrise is at {sunInfo.Sunset.ToLocalTime().ToString()}";
        }
    }
}
