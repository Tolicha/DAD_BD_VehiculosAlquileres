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
    /// Lógica de interacción para CrearVehiculo.xaml
    /// </summary>
    public partial class CrearVehiculo : Window
    {
        private Vehiculo vehiculo;
        private LogicaVehiculo logicaVehiculo;
        private int errores;
        private Boolean modificar;
        private int pos;
        private LogicaTipoVehiculo logicaTipoVehiculo;
        public CrearVehiculo(LogicaVehiculo logica)
        {
            InitializeComponent();
            this.vehiculo = new Vehiculo();
            this.DataContext = vehiculo;
            this.logicaVehiculo = logica;
            this.logicaTipoVehiculo = new LogicaTipoVehiculo();
            this.modificar = false;
            
            calendario.DisplayDate = DateTime.Now;
            String[] plazas = {"A01", "A02", "A03", "A04", "A11", "A12", "A13", "A14", "A21", "A22", "A23", "A24",
                                "B01", "B02", "B03", "B04", "B11", "B12", "B13", "B14", "B21", "B22", "B23", "B24"};
            //Contenido de ComboBoxes
            foreach (TipoVehiculo tipoVehiculo in logicaTipoVehiculo.tiposVehiculos)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = tipoVehiculo;
                comboTipoVehiculo.Items.Add(comboBoxItem);
            }

            foreach (String plaza in plazas)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = plaza;
                comboboxPlazas.Items.Add(comboBoxItem);
            }
        }

        public CrearVehiculo(LogicaVehiculo logica, Vehiculo vehiculoModificar, int pos)
        {
            InitializeComponent();
            this.vehiculo = vehiculoModificar;
            this.pos = pos;
            this.DataContext = vehiculo;
            this.logicaVehiculo = logica;
            this.logicaTipoVehiculo = new LogicaTipoVehiculo();
            this.modificar = true;
            calendario.SelectedDate = vehiculo.CaducidadITV.Date;
            String[] plazas = {"A01", "A02", "A03", "A04", "A11", "A12", "A13", "A14", "A21", "A22", "A23", "A24",
                                "B01", "B02", "B03", "B04", "B11", "B12", "B13", "B14", "B21", "B22", "B23", "B24"};
            //Contenido de ComboBoxes
            foreach (TipoVehiculo tipoVehiculo in logicaTipoVehiculo.tiposVehiculos)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = tipoVehiculo;
                comboTipoVehiculo.Items.Add(comboBoxItem);
            }

            foreach (String plaza in plazas)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = plaza;
                comboboxPlazas.Items.Add(comboBoxItem);
            }
        }
        private void anadirBoton_Click(object sender, RoutedEventArgs e)
        {
            if (modificar) 
            {
                this.vehiculo.Alquilado = false;
                this.vehiculo.CaducidadITV = (DateTimeOffset)calendario.SelectedDate;
                logicaVehiculo.updateVehiculo(this.vehiculo, this.pos);
            }
            else
            {
                this.vehiculo.Alquilado = false;//Todos los vehículos creados no estarán alquilados
                this.vehiculo.CaducidadITV = (DateTimeOffset)calendario.SelectedDate;
                logicaVehiculo.addVehiculo(this.vehiculo);
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
