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
using Tarea_2._1.Dto;
using Tarea_2._1.Logica;
using Tarea_2._1.Vista;

namespace Tarea_2._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogicaVehiculo logicaVehiculo;
        private PaginaVehiculo p;
        public MainWindow()
        {
            InitializeComponent();
            logicaVehiculo = new LogicaVehiculo();
        }
        private void MenuItem_GotFocus(object sender, RoutedEventArgs e)
        {
            p = new PaginaVehiculo(logicaVehiculo);
            framePrincipal.NavigationService.Navigate(p);
        }
        private void insertVehiculo_Click(object sender, RoutedEventArgs e)
        {
            CrearVehiculo cv = new CrearVehiculo(logicaVehiculo);
            cv.Show();
        }

        private void updateVehiculo_Click(object sender, RoutedEventArgs e)
        {
            CrearVehiculo cv = new CrearVehiculo(logicaVehiculo, (Vehiculo)p.DatagridVehiculo.SelectedItem, p.DatagridVehiculo.SelectedIndex);
            cv.Show();
        }

        private void insertCliente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_GotFocus_1(object sender, RoutedEventArgs e)
        {
            PaginaAlquiler p = new PaginaAlquiler();
            framePrincipal.Navigate(p);
        }
        private void insertAlquiler_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
