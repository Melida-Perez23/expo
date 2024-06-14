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

namespace StatusBar
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
        private void txtDatos_KeyDown(object sender, KeyEventArgs e)
        {
            int cantidad = txtDatos.Text.Length + 1;
            string[] palabras = txtDatos.Text.Split(new char[] { ' ' });
            int cantPalabras = palabras.Length;

            txtInformacion.Text = "se tiene " + cantidad.ToString() + " caracteres";
            txtPalabras.Text = "con " + cantPalabras.ToString() + " palabras";
        }
    }
}
