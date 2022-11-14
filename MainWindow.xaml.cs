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

namespace Wpf_Chemeris_PR2._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Itog.Text = "Ст.гр. ИСП Чемерис Г.С.";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая работа 2";
            double x = double.Parse(j1.Text);

            Itog.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(j2.Text);

            Itog.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(j3.Text);

            Itog.Text += Environment.NewLine + "Z = " + z.ToString();
            double a = Math.Tan(x + y) * Math.Tan(x + y);
            double b = Math.Exp(y - z);
            double c = Math.Sqrt(Math.Cos(x * x) + Math.Sin(z * z));
            double u = a - b * c;

            Itog.Text += Environment.NewLine + "Результат U = " + u.ToString();
        }

        private void j1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
