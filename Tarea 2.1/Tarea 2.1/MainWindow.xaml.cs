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

namespace Tarea_2._1
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
                
            } else if ((((MenuItem)sender).Name).Equals(updateVehiculo))
            {

            } else if ((((MenuItem)sender).Name).Equals(insertCliente))
            {

            } else if ((((MenuItem)sender).Name).Equals(updateCliente))
            {

            } else if ((((MenuItem)sender).Name).Equals(insertAlquiler))
            {

            } else if ((((MenuItem)sender).Name).Equals(updateAlquiler))
            {

            }
            
            
        }
    }
}
