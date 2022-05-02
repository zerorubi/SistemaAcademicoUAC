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
    /// Lógica de interacción para frmIngresante.xaml
    /// </summary>
    public partial class frmIngresante : Window
    {
        public frmIngresante()
        {
            InitializeComponent();
        }
        static CapaNegocio.Ingresante ingresante = new CapaNegocio.Ingresante();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime? FechaNac = dateFechaNac.SelectedDate;
            ingresante.Apellidos = txtApellidos.Text.Trim();
            ingresante.Nombres = txtNombre.Text.Trim();
            ingresante.Codigo = txtCodigo.Text.Trim();
            ingresante.Correo = txtCorreo.Text.Trim();
            ingresante.Domicilio = txtDomicilio.Text.Trim();
            ingresante.FechaNac = FechaNac.Value;
            ingresante.LugarNac = txtLugarNac.Text.Trim();
            string notaIng = txtNotaIngreso.Text.Trim();
            string puesto = txtPuesto.Text.Trim();
            ingresante.NotaIng = Int32.Parse(notaIng);
            ingresante.PuestoIng = Int32.Parse(puesto);
            ingresante.Seguro = txtSeguro.Text.Trim();
            ingresante.Escuela = txtEscuela.Text.Trim();
        }
        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + ingresante.Apellidos + "\nNombres: " + ingresante.Nombres
                + "\nCodigo: " + ingresante.Codigo + "\nCorreo: " + ingresante.Correo +
                "\nDomicilio: " + ingresante.Domicilio + "\nLugarNac:" + ingresante.LugarNac +
                "\nFechaNac:" + ingresante.FechaNac + "\nNota de Ingreso: " + ingresante.NotaIng +
                "\nPuesto de Ingreso: " + ingresante.PuestoIng + "\nEscuela: " + ingresante.Escuela + "\nSeguro: " + ingresante.Seguro);
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

        private void btnMetodo8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sid implementado");
        }
    }
}
