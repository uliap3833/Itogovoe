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

namespace EnglishSchooll
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Const.frame = Fmain;
            Const.BD = new Entities();
            Fmain.Navigate(new ServiceList());
        }

        private void Bsing_in_Click(object sender, RoutedEventArgs e)
        {
           
        }

    }
}
