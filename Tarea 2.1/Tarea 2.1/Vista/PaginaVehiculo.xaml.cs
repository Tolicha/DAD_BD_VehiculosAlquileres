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
using Tarea_2._1.Logica;

namespace Tarea_2._1
{
    /// <summary>
    /// Lógica de interacción para PaginaVehiculo.xaml
    /// </summary>
    public partial class PaginaVehiculo : Page
    {
        private LogicaVehiculo logicaVehiculo;
        public PaginaVehiculo()
        {
            InitializeComponent();
            logicaVehiculo = new LogicaVehiculo();
            DatagridVehiculo.DataContext = logicaVehiculo;
        }
    }
}
