﻿using System;
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
    /// Логика взаимодействия для TovariPage.xaml
    /// </summary>
    public partial class TovariPage : Page
    {
        public TovariPage()
        {
            InitializeComponent();
            LVTovari.ItemsSource = App.Context.Tovaris.ToList();
        }

        private void BTNKorzina_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTNDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTNRedDop_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
