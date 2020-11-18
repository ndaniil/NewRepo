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

namespace WpfApp1
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Label.Content = "Привет";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Label.Content = "До свидания";
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MyWindow.Background = Brushes.OrangeRed;
            Label.Content = "Начало работы";
        }
    }

    
}
