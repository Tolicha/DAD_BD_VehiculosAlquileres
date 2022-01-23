using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Tarea_2._1
{
    /// <summary>
    /// Interaction logic for VistaCliente.xaml
    /// </summary>
    public partial class LogicaCliente : Window
    {
        public ObservableCollection<Cliente> listaClientes;

        public LogicaCliente()
        {
            listaClientes = new ObservableCollection<Cliente>();
            listaClientes.Add(new Cliente("42112233A", , "María Hernández", "6667777888", "maria@gmail.com", new DateTime(1995, 02, 02)));
        }

        public void addCLiente(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        public void updateCliente(Cliente cliente, int posicion)
        {
            listaClientes[posicion] = cliente;
        }

        public void deleteCLiente(Cliente cliente)
        {
            listaClientes.Remove(cliente);
        }
    }
}
