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
using Tarea_2._1.Logica;

namespace Tarea_2._1.Vista
{
    /// <summary>
    /// Lógica de interacción para CrearAlquiler.xaml
    /// </summary>
    public partial class CrearAlquiler : Window
    {
        private Alquiler alquiler;
        private Vehiculo vehiculo;
        private Cliente cliente;
        private LogicaAlquiler logicaAlquiler;
        private LogicaVehiculo logicaVehiculo;
        private LogicaCliente logicaCliente;
        private int errores;
        private Boolean modificar;
        private int pos;
        public CrearAlquiler(LogicaAlquiler logicaAlquiler, LogicaVehiculo logicaVehiculo, LogicaCliente logicaCliente)
        {   
            InitializeComponent();
            this.alquiler = new Alquiler();
            this.DataContext = alquiler;
            this.logicaAlquiler = logicaAlquiler;
            this.logicaVehiculo = logicaVehiculo;
            this.logicaCliente = logicaCliente;
            this.modificar = false;

            calendarioInicio.DisplayDate = DateTime.Now;
            calendarioFin.DisplayDate = DateTime.Now;

            //Contenido de ComboBoxes
            foreach (Vehiculo v in logicaVehiculo.listaVehiculos)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = v;
                comboVehiculos.Items.Add(comboBoxItem);
            }

            foreach (Cliente c in logicaCliente.listaClientes)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = c;
                comboClientes.Items.Add(comboBoxItem);
            }
        }

        public CrearAlquiler(LogicaAlquiler logicaAlquiler, LogicaVehiculo logicaVehiculo, LogicaCliente logicaCliente, Alquiler alquiler, int pos)
        {
            InitializeComponent();
            this.alquiler = alquiler;
            this.DataContext = alquiler;
            this.logicaAlquiler = logicaAlquiler;
            this.logicaVehiculo = logicaVehiculo;
            this.logicaCliente = logicaCliente;
            this.modificar = true;
            this.pos = pos;

            calendarioInicio.DisplayDate = DateTime.Now;
            calendarioFin.DisplayDate = DateTime.Now;

            //Contenido de ComboBoxes
            foreach (Vehiculo v in logicaVehiculo.listaVehiculos)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = v;
                comboVehiculos.Items.Add(comboBoxItem);
            }

            foreach (Cliente c in logicaCliente.listaClientes)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = c;
                comboClientes.Items.Add(comboBoxItem);
            }
        }

        private void anadirBoton_Click(object sender, RoutedEventArgs e)
        {
            //PARA INTRODUCIR EL OBJETO
            foreach (Vehiculo v in logicaVehiculo.listaVehiculos)
            {
                if (comboVehiculos.SelectedItem.ToString().Contains(v.ToString()))
                {
                    this.alquiler.Vehiculo = v;
                }
            }

            foreach (Cliente c in logicaCliente.listaClientes)
            {
                if (comboClientes.SelectedItem.ToString().Contains(c.ToString()))
                {
                    this.alquiler.Cliente = c;
                }
            }
            //PARA ESTABLECER ALQUILADO Y FECHA ITV
            this.alquiler.FechaInicio = (DateTimeOffset)calendarioInicio.SelectedDate;
            this.alquiler.FechaFin = (DateTimeOffset)calendarioFin.SelectedDate;

            if (todoRiesgo.IsChecked == true)
                this.alquiler.TipoSeguro = "Todo riesgo";
            else
                this.alquiler.TipoSeguro = "Terceros";

            if (modificar)
            {

                logicaAlquiler.updateAlquiler(this.alquiler, this.pos);
            }
            else
            {
                logicaAlquiler.addAlquiler(this.alquiler);
            }

            this.Close();
        }


        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                errores++;
            }
            else
            {
                errores--;
            }

            if (errores == 0)
            {
                anadirBoton.IsEnabled = true;
            }
            else
            {
                anadirBoton.IsEnabled = false;
            }
        }

        
    }
}
