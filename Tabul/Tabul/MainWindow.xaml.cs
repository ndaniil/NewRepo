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

namespace Tabul
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
                double x0 = double.Parse(X0.Text);
                double xk = double.Parse(Xk.Text);
                double dx = double.Parse(Dx.Text);
                double a = double.Parse(A.Text);
                double b = double.Parse(B.Text);
                int N = (int)((xk - x0) / dx) + 1;
                double x = x0;
                string res = "";
                for (int i = 0; i <= N; i++)
                {
                    double y = 1.2 * Math.Pow(a - b, 3) * Math.Exp(x * x) + x;
                    res += String.Format("x={0} y={1:F2}\n", x, y);
                    x += dx;
                }
                Result.Text = res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
