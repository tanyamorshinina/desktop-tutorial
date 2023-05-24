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

namespace KPMusical_shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameMain.Navigate(new Pages.Autorisazia());
        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            if (FrameMain.CanGoBack)
                FrameMain.GoBack();
        }

        private void Tovari_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new Pages.TovariPage());
        }

        private void Korzina_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new Pages.KorzinaPage());
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Navigate(new Pages.ProfilePage());
        }
    }
}
