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

namespace OperSwitch
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double n = double.Parse(Num.Text);
                double p;
                p = n % 10;
                if (n >= 20 || n < 10)
                    switch (p)
                    {
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9: Result.Content = n + " копеек"; break;
                        case 1: Result.Content = n + " копейка"; break;
                        case 2:
                        case 3:
                        case 4: Result.Content = n + " копейки"; break;
                        default: Result.Content = "Неправильно введено число"; break;
                    }
                else
                {
                    Result.Content = n + " копеек";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}