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
using System.Windows.Shapes;

namespace ClinicaMedica
{
    /// <summary>
    /// Lógica de interacción para TurnosModificar.xaml
    /// </summary>
    public partial class TurnosModificar : Window
    {
        public TurnosModificar()
        {
            InitializeComponent();
        }

        private void ButtonSalir(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonTurnos(object sender, RoutedEventArgs e)
        {
            this.NavegarA<TurnosVer>();
        }

        private void ButtonAgregar(object sender, RoutedEventArgs e)
        {
            this.NavegarA<TurnosVer>();
        }

        private void ButtonCancelar(object sender, RoutedEventArgs e)
        {
            this.NavegarA<Turnos>();
        }
    }
}
