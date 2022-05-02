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
    /// Lógica de interacción para frmRegular.xaml
    /// </summary>
    public partial class frmRegular : Window
    {
        public frmRegular()
        {
            InitializeComponent();
        }
        static CapaNegocio.Regular regular = new CapaNegocio.Regular();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime? FechaNac = dateFechaNac.SelectedDate;
            regular.Apellidos = txtApellidos.Text.Trim();
            regular.Nombres = txtNombre.Text.Trim();
            regular.Codigo = txtCodigo.Text.Trim();
            regular.Correo = txtCorreo.Text.Trim();
            regular.Domicilio = txtDomicilio.Text.Trim();
            regular.FechaNac = FechaNac.Value;
            regular.LugarNac = txtLugarNac.Text.Trim();
            string notaIng = txtPromedio.Text.Trim();
            string puesto = txtCreditos.Text.Trim();
            regular.Promedio = Int32.Parse(notaIng);
            regular.CreditosAcumulados = Int32.Parse(puesto);
            regular.Seguro = txtSeguro.Text.Trim();
            regular.Escuela = txtEscuela.Text.Trim();
            regular.Semestre = txtSemestre.Text.Trim();
        }
        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + regular.Apellidos + "\nNombres: " + regular.Nombres
                + "\nCodigo: " + regular.Codigo + "\nCorreo: " + regular.Correo +
                "\nDomicilio: " + regular.Domicilio + "\nLugarNac:" + regular.LugarNac +
                "\nFechaNac:" + regular.FechaNac + "\nPromedio: " + regular.Promedio +
                "\nNúmero de creditos Acumulados: " + regular.CreditosAcumulados + "\nEscuela: " + regular.Escuela + 
                "\nSeguro: " + regular.Seguro + "\nSemestre: " + regular.Semestre);
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
