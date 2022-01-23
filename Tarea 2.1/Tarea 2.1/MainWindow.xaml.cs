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

namespace Tarea_2._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PaginaVehiculo p = new PaginaVehiculo();
            framePrincipal.Navigate(p);
        }

        private void insertVehiculo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void insertCliente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void insertAlquiler_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
