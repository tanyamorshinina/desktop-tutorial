using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KPMusical_shop
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Entities.Musical_magazinEntities Context
        { get; } = new Entities.Musical_magazinEntities();
        public static Entities.Pokupateli Pokupateli = null;
        public static Entities.Sotrudniki Sotrudniki = null;
    }
}
