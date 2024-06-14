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

namespace Menu
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void menusuma_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtValorA.Text);
            double b = Convert.ToDouble(txtValorB.Text);
            double r = a + b;
            txtR.Text = r.ToString("N2");
        }

        private void menuSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuresta_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtValorA.Text);
            double b = Convert.ToDouble(txtValorB.Text);
            double r = a - b;
            txtR.Text = r.ToString("N2");

        }

        private void menumultiplicacion_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtValorA.Text);
            double b = Convert.ToDouble(txtValorB.Text);
            double r = a * b;
            txtR.Text = r.ToString("N2");
        }

        private void menudivision_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtValorA.Text);
            double b = Convert.ToDouble(txtValorB.Text);
            double r = a / b;
            txtR.Text = r.ToString("N2");
        }
    }
}
