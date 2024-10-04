using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gitTaak1
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

        private void Rood_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush red = new SolidColorBrush(Colors.Red);
            Venster.Background = red;
            
        }

        private void Geel_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush yellow = new SolidColorBrush(Colors.Yellow);
            Venster.Background = yellow;
            
        }

        private void Groen_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush green = new SolidColorBrush(Colors.Green);
            Venster.Background = green;
        }

        private void Blauw_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush blauw = new SolidColorBrush(Colors.Blue);
            Venster.Background = blauw;
        }

        private void Rood_KeyDown(object sender, KeyEventArgs e)
        {
            TxtKleurcode.Text = "#FF0000";
           
        }

        private void Groen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtKleurcode.Text = "#008000";
        }

        

        private void Rood_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtKleurcode.Text = "#FF0000";
        }

        private void Geel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtKleurcode.Text = "#FFFF00";
        }

        private void Blauw_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtKleurcode.Text = "#0000FF";
        }
    }
}
