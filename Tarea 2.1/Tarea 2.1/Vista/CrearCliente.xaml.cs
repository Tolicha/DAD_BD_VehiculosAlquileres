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
using static Tarea_2._1.Dto.Carnet;

namespace Tarea_2._1.Paginas
{
    /// <summary>
    /// Lógica de interacción para CrearCliente.xaml
    /// </summary>
    public partial class CrearCliente : Window
    {
        private Cliente cliente;
        private Carnet carnet;
        private LogicaCliente logicaCliente;
        private int errores;
        private Boolean modificar;
        private int pos;
        private String[] tiposCarnet = { "AM", "A1", "A2", "A", "B", "C1", "C", "D1", "D" };
        public CrearCliente(LogicaCliente logica)
        {
            InitializeComponent();
            this.cliente = new Cliente();
            this.carnet = new Carnet();
            this.DataContext = cliente;
            this.logicaCliente = logica;
            this.modificar = false;

            calendarioNacimiento.DisplayDate = DateTime.Now;
            calendarioExpedicion.DisplayDate = DateTime.Now;
            calendarioCaducidad.DisplayDate = DateTime.Now;

            // Contenido de ComboBox
            foreach (String tipoCarnet in tiposCarnet)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = tipoCarnet;
                comboTipoCarnet.Items.Add(comboBoxItem);
            }
        }

        public CrearCliente(LogicaCliente logica, Cliente clienteModificar, int pos)
        {
            InitializeComponent();
            this.cliente = clienteModificar;
            this.carnet = new Carnet();
            this.pos = pos;
            this.DataContext = cliente;
            this.logicaCliente = logica;
            this.modificar = true;

            calendarioNacimiento.DisplayDate = DateTime.Now;
            calendarioExpedicion.DisplayDate = DateTime.Now;
            calendarioCaducidad.DisplayDate = DateTime.Now;

            // Contenido de ComboBox
            foreach (String tipoCarnet in tiposCarnet)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = tipoCarnet;
                comboTipoCarnet.Items.Add(comboBoxItem);
            }
        }
        private void anadirBoton_Click(object sender, RoutedEventArgs e)
        {
            String tipoDeCarnet = "";

            //PARA ESTABLECES TIPO DE CARNET
            foreach (String tipoCarnet in tiposCarnet)
            {
                if (comboTipoCarnet.SelectedItem.ToString().Contains(tipoCarnet))
                {
                    tipoDeCarnet = tipoCarnet;
                    break;
                }
            }
            //PARA ESTABLECER LAS FECHAS
            this.cliente.FechaNacimiento = (DateTimeOffset) calendarioNacimiento.SelectedDate;
            carnet = new Carnet(tipoDeCarnet, (DateTimeOffset)calendarioExpedicion.SelectedDate, (DateTimeOffset)calendarioCaducidad.SelectedDate);
            cliente.Carnet = this.carnet;

            if (modificar)
            {
                logicaCliente.updateCliente(this.cliente, this.pos);
            }
            else
            {
                logicaCliente.addCliente(this.cliente);
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
