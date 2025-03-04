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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercise15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            ConvertSecondsToHoursMinutesSeconds();
        }
        private void ConvertSecondsToHoursMinutesSeconds()
        {
            int seconds = Convert.ToInt32(secondsTextBox.Text);
            int minutes = seconds / 60;
            seconds = seconds % 60;
            int hours = minutes / 60;
            minutes = minutes % 60;
            timeLabel.Content = $"{secondsTextBox.Text} seconden is {hours} uur, {minutes} minuten en {seconds} seconden.";
        }
    }
}
