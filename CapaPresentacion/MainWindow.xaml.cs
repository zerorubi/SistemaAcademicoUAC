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

namespace CapaPresentacion
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

        private void btnIngresantes_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento.frmIngresante ingresante = new Mantenimiento.frmIngresante();
            ingresante.Show();
        }

        private void btnRegular_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento.frmRegular regular = new Mantenimiento.frmRegular();
            regular.Show();
        }

        private void btnProfesor_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento.frmProfesor profesor= new Mantenimiento.frmProfesor();
            profesor.Show();
        }

        private void btnAdministrativo_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento.frmAdministrativo administrativo = new Mantenimiento.frmAdministrativo();
            administrativo.Show();
        }

        private void btnProceso_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Error 404");
        }

        private void btnSeguridad_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Error 404");
        }

        private void btnReportes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Error 404");
        }

        private void btnAyuda_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Error 404");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
