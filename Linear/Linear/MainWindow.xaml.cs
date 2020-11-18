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

namespace LinearAlg
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(textX.Text);
                double y = double.Parse(textY.Text);
                double z = double.Parse(textZ.Text);
                double u = Math.Pow(Math.Pow(Math.Abs(x-y),2)+9,1/3)/(Math.Pow(x,2)+Math.Pow(y,2)+2)-Math.Exp(Math.Abs(x-y))*Math.Pow(Math.Tan(z)*Math.Tan(z)+1,x);
                Result.Text = "X=" + x.ToString() + "\n" +
                              "Y=" + y.ToString() + "\n" +
                              "Z=" + z.ToString() + "\n" +
                              "Результат U=" + u.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
