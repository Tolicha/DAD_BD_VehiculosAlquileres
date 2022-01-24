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
using Tarea_2._1.Dto;
using Tarea_2._1.Paginas;

namespace Tarea_2._1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogicaCliente logicaCliente;
        private PaginaCliente p;
        public MainWindow()
        {
            InitializeComponent();
            logicaCliente = new LogicaCliente();
        }
        private void menuItem_gotFocus(object sender, RoutedEventArgs e)
        {
            if ((((MenuItem)sender).Name).Equals(vehiculo))
            {
                
            }
            else if ((((MenuItem)sender).Name).Equals(cliente))
            {
                p = new PaginaCliente(logicaCliente);
                framePrincipal.NavigationService.Navigate(p);
            }
            else if ((((MenuItem)sender).Name).Equals(alquiler))
            {
                PaginaAlquiler p = new PaginaAlquiler();
                framePrincipal.Navigate(p);
            }
        }
        private void menu_Click(object sender, RoutedEventArgs e)
        {
            if ((((MenuItem)sender).Name).Equals(vehiculo))
            {

            }
            else if ((((MenuItem)sender).Name).Equals(cliente))
            {
                                
            }
            else if ((((MenuItem)sender).Name).Equals(alquiler))
            {

            }
        }
        private void menuItem_Click(object sender, RoutedEventArgs e)
        {
            if ((((MenuItem)sender).Name).Equals(insertVehiculo)) 
            {
                
            } 
            else if ((((MenuItem)sender).Name).Equals(updateVehiculo))
            {

            } 
            else if ((((MenuItem)sender).Name).Equals(insertCliente))
            {
                CrearCliente cc = new CrearCliente(logicaCliente);
                cc.Show();
            } 
            else if ((((MenuItem)sender).Name).Equals(updateCliente))
            {
                CrearCliente cc = new CrearCliente(logicaCliente, (Cliente)p.DatagridCliente.SelectedItem, p.DatagridCliente.SelectedIndex);
                cc.Show();
            } 
            else if ((((MenuItem)sender).Name).Equals(insertAlquiler))
            {

            } 
            else if ((((MenuItem)sender).Name).Equals(updateAlquiler))
            {

            }
        }
    }
}
