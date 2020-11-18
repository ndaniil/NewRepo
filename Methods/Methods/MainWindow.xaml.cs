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

namespace Methods
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
                double X = double.Parse(x.Text);
                double Y = double.Parse(y.Text);
                double a = 141, b = 255, c = 13,d = 44;
                Result.Text += "Максимальное число из X и Y: " + String.Format("{0}", max(X, Y)) + Environment.NewLine;
                Result.Text += "Максимальное число: " + String.Format("{0}", max(max(a, b), max(c, d))) + Environment.NewLine;
                Fine();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public double max (double n1, double n2)
        {
            return n1 >= n2 ? n1 : n2;
        }
        private void Fine()
        {
            Result.Text += "Программа закончена"+ "\n";
        }
    }
}
