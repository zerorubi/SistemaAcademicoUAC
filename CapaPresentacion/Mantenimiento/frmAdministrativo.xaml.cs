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
using System.Windows.Shapes;

namespace CapaPresentacion.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para frmAdministrativo.xaml
    /// </summary>
    public partial class frmAdministrativo : Window
    {
        public frmAdministrativo()
        {
            InitializeComponent();
        }
        static CapaNegocio.Administrativo administrativo = new CapaNegocio.Administrativo();
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime? FechaNac = dateFechaNac.SelectedDate;
            administrativo.Apellidos = txtApellidos.Text.Trim();
            administrativo.Nombres = txtNombre.Text.Trim();
            administrativo.Codigo = txtCodigo.Text.Trim();
            administrativo.Correo = txtCorreo.Text.Trim();
            administrativo.Domicilio = txtDomicilio.Text.Trim();
            administrativo.FechaNac = FechaNac.Value;
            administrativo.LugarNac = txtLugarNac.Text.Trim();
            administrativo.Cargo = txtCargo.Text.Trim();
            administrativo.Funcion = txtFuncion.Text.Trim();
        }
        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + administrativo.Apellidos + "\nNombres: " + administrativo.Nombres
                + "\nCodigo: " + administrativo.Codigo + "\nCorreo: " + administrativo.Correo + 
                "\nDomicilio: " + administrativo.Domicilio + "\nLugarNac:" + administrativo.LugarNac + 
                "\nFechaNac:" + administrativo.FechaNac + "\nCargo: " + administrativo.Cargo + "\nFunción: " + administrativo.Funcion);
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sid implementado");
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sid implementado");
        }

        private void btnMetodo3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sid implementado");
        }

        private void btnMetodo4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sid implementado");
        }

        private void btnMetodo5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sid implementado");
        }

        private void btnMetodo6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sid implementado");
        }

        private void btnMetodo7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sid implementado");
        }


    }
}
