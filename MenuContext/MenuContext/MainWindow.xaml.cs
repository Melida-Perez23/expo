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

namespace MenuContext
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

        private void menuPulgacm_Click(object sender, RoutedEventArgs e)
        {
            double valor = Convert.ToDouble(txtMedida.Text);
            valor *= 2.54;
            txtMedida.Text = valor.ToString("F2");
        }

        private void menuCMaPulg_Click(object sender, RoutedEventArgs e)
        {
            double valor = Convert.ToDouble(txtMedida.Text);
            valor /= 2.54;
            txtMedida.Text = valor.ToString("F2");
        }
    }
}
