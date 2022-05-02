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
    /// Lógica de interacción para frmProfesor.xaml
    /// </summary>
    public partial class frmProfesor : Window
    {
        public frmProfesor()
        {
            InitializeComponent();
        }
        static CapaNegocio.Profesor profesor = new CapaNegocio.Profesor();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime? FechaNac = dateFechaNac.SelectedDate;
            profesor.Apellidos = txtApellidos.Text.Trim();
            profesor.Nombres = txtNombre.Text.Trim();
            profesor.Codigo = txtCodigo.Text.Trim();
            profesor.Correo = txtCorreo.Text.Trim();
            profesor.Domicilio = txtDomicilio.Text.Trim();
            profesor.FechaNac = FechaNac.Value;
            profesor.LugarNac = txtLugarNac.Text.Trim();
            string añoServ = txtAñosServicio.Text.Trim();
            profesor.AñosServicio = Int32.Parse(añoServ);
            profesor.Especialidad = txtEspecialidad.Text.Trim();
            profesor.Grado = txtGrado.Text.Trim();
        }
        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + profesor.Apellidos + "\nNombres: " + profesor.Nombres
                + "\nCodigo: " + profesor.Codigo + "\nCorreo: " + profesor.Correo +
                "\nDomicilio: " + profesor.Domicilio + "\nLugarNac:" + profesor.LugarNac +
                "\nFechaNac:" + profesor.FechaNac + "\nGrado: " + profesor.Grado + 
                "\nAños de Servicio: " + profesor.AñosServicio + "\nEspecialidad: " + profesor.Especialidad);
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
