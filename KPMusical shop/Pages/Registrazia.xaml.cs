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
    /// Логика взаимодействия для Registrazia.xaml
    /// </summary>
    public partial class Registrazia : Page
    {
        public Registrazia()
        {
            InitializeComponent();
        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            var user = new Entities.Pokupateli()
            {
                login = Login.Text,
                password = Password.Password,
                familiya=Familiya.Text,
                name=Imya.Text,
                otchestvo=Otchestvo.Text,
                telefon=Convert.ToInt64(Telefon.Text),
                email=Pochta.Text
            };
            App.Context.Pokupatelis.Add(user);
            App.Context.SaveChanges();
            App.Pokupateli = user;
            NavigationService.Navigate(new TovariPage());
        }
    }
}
