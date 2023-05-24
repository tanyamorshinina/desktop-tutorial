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

namespace KPMusical_shop.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autorisazia.xaml
    /// </summary>
    public partial class Autorisazia : Page
    {
        public Autorisazia()
        {
            InitializeComponent();
        }

        private void Regestrazia_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Registrazia());
        }

        private void Autorisaziya_Click(object sender, RoutedEventArgs e)
        {
            var curPokupateli = App.Context.Pokupatelis.FirstOrDefault(x => x.login == Login.Text && x.password == Password.Password);
            var curAdmistrator = App.Context.Sotrudnikis.FirstOrDefault(x => x.login == Login.Text && x.password == Password.Password);
            if (curPokupateli != null)
            {
                App.Pokupateli = curPokupateli;
                NavigationService.Navigate(new TovariPage());
            }
            else if (curAdmistrator != null)
            {
                App.Sotrudniki = curAdmistrator;
                NavigationService.Navigate(new TovariPage());
            }
            else
            {
                MessageBox.Show("Пользователя нет в системе", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
