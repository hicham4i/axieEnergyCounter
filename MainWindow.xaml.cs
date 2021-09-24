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

namespace axieEnergyCounter
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Text { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Text = "3";
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.IsUp && e.Key.GetHashCode() == 85)
            {
                var count = int.Parse(Text);
                Text = (count + 1).ToString();
                display.Text = Text;
            }

            if (e.IsUp && e.Key.GetHashCode() == 87)
            {
                var count = int.Parse(Text);
                Text = (count - 1).ToString();
                display.Text = Text;
            }

            if (e.IsUp && e.Key.GetHashCode() == 6)
            {
                var count = int.Parse(Text);
                Text = (count + 2).ToString();
                display.Text = Text;
            }

            if (e.IsUp && (e.Key.GetHashCode() == 13 || e.Key.GetHashCode() == 32))
            {
                Text = "3";
                display.Text = Text;
            }
        }
    }
}
