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
using Tarea_2._1.Paginas;
using Tarea_2._1.Vista;

namespace Tarea_2._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogicaVehiculo logicaVehiculo;
        private LogicaCliente logicaCliente;
        private LogicaAlquiler logicaAlquiler;
        private PaginaVehiculo paginaVehiculo;
        private PaginaCliente paginaCliente;
        private PaginaAlquiler paginaAlquiler;
        public MainWindow()
        {
            InitializeComponent();
            logicaVehiculo = new LogicaVehiculo();
            logicaCliente = new LogicaCliente();
            logicaAlquiler = new LogicaAlquiler();
            paginaVehiculo = new PaginaVehiculo(logicaVehiculo);
            framePrincipal.NavigationService.Navigate(paginaVehiculo);
        }

        // Menu Vehiculo Eventos
        private void listVehiculo_Click(object sender, RoutedEventArgs e)
        {
            paginaVehiculo = new PaginaVehiculo(logicaVehiculo);
            framePrincipal.NavigationService.Navigate(paginaVehiculo);
        }
        private void insertVehiculo_Click(object sender, RoutedEventArgs e)
        {
            CrearVehiculo cv = new CrearVehiculo(logicaVehiculo);
            cv.Show();
        }

        private void updateVehiculo_Click(object sender, RoutedEventArgs e)
        {
            CrearVehiculo cv = new CrearVehiculo(logicaVehiculo, (Vehiculo)paginaVehiculo.DatagridVehiculo.SelectedItem, paginaVehiculo.DatagridVehiculo.SelectedIndex);
            cv.Show();
        }

        private void deleteVehiculo_Click(object sender, RoutedEventArgs e)
        {
            logicaVehiculo.deleteVehiculo((Vehiculo)paginaVehiculo.DatagridVehiculo.SelectedItem);
        }

        // Metodos Cliente

        private void listCliente_Click(object sender, RoutedEventArgs e)
        {
            paginaCliente = new PaginaCliente(logicaCliente);
            framePrincipal.NavigationService.Navigate(paginaCliente);

        }
        private void insertCliente_Click(object sender, RoutedEventArgs e)
        {
            CrearCliente cc = new CrearCliente(logicaCliente);
            cc.Show();
        }

        private void updateCliente_Click(object sender, RoutedEventArgs e)
        {
            CrearCliente cc = new CrearCliente(logicaCliente, (Cliente)paginaCliente.DatagridCliente.SelectedItem, paginaCliente.DatagridCliente.SelectedIndex);
            cc.Show();
        }

        private void deleteCliente_Click(object sender, RoutedEventArgs e)
        {
            logicaCliente.deleteCliente((Cliente)paginaCliente.DatagridCliente.SelectedItem);
        }

        //ALQUILERES
        private void listAlquiler_Click(object sender, RoutedEventArgs e)
        {
            paginaAlquiler = new PaginaAlquiler(logicaAlquiler);
            framePrincipal.NavigationService.Navigate(paginaAlquiler);
        }

        private void insertAlquiler_Click(object sender, RoutedEventArgs e)
        {   
            CrearAlquiler ca = new CrearAlquiler(logicaAlquiler, logicaVehiculo, logicaCliente);
            ca.Show();
        }

        private void updateAlquiler_Click(object sender, RoutedEventArgs e)
        {
            CrearAlquiler ca = new CrearAlquiler(logicaAlquiler, logicaVehiculo, logicaCliente, (Alquiler)paginaAlquiler.DatagridAlquiler.SelectedItem, paginaAlquiler.DatagridAlquiler.SelectedIndex);
            ca.Show();
        }

        private void deleteAlquiler_Click(object sender, RoutedEventArgs e)
        {
            logicaAlquiler.deleteAlquiler((Alquiler)paginaAlquiler.DatagridAlquiler.SelectedItem);
        }
    }
}
