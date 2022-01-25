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
using Tarea_2._1.Logica;

namespace Tarea_2._1
{
    /// <summary>
    /// Lógica de interacción para WindowAlquiler.xaml
    /// </summary>
    public partial class WindowAlquiler : Window
    {
        private LogicaAlquiler logicaAlquiler;
        public WindowAlquiler()
        {
            InitializeComponent();
            logicaAlquiler = new LogicaAlquiler();
            DatagridAlquiler.DataContext = logicaAlquiler;
        }
    }
}
