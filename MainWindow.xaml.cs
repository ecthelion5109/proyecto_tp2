﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClinicaMedica {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void MetodoBotonIniciarSesion(object sender, RoutedEventArgs e) {
			//MessageBox.Show($"Usuario correcta?: {label_user.Text.Equals("juanita_conchuda_123")}");
			//MessageBox.Show($"Contraseña correcta?: {label_pass.Text.Equals("123")}");

			Console.WriteLine(sender.ToString());
			//MessageBox.Show(sender.ToString());
			string usuario = "mariela";
			string contraseña = "123";


			if (  label_user.Text.Equals(usuario) && label_pass.Text.Equals(contraseña)   ) {
				//escondo la anterior
				this.Hide();

				//creo una nueva y la vinculo a la aplicacion completa
				Inicio inicio = new Inicio();
				inicio.Owner = this;
				inicio.Show();
			}
			else {
				MessageBox.Show("Contraseña o usuario incorrecta");
			}
		}

        private void MetodoBotonSalir(object sender, RoutedEventArgs e)
        {
			Application.Current.Shutdown ();
        }
	}
}