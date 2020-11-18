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

namespace Lab6
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
            string value = list.Items[list.SelectedIndex].ToString();
            string[] str = value.Split(' ');
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == "")
                    continue;
                else
                    str[i] += i;
                Result.Content = "Количество слов:" + (str.Length-1);
            }
        }
    }
}

