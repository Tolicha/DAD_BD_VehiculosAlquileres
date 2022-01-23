using System;
using System.Collections.ObjectModel;
using System.Windows;
using Tarea_2._1.Dto;

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
            listaClientes.Add(new Cliente("42112233A", new Carnet(Carnet.Tipo.B, new DateTime(1995, 02, 02), new DateTime(2005, 02, 02)), "María Hernández", "6667777888", "maria@gmail.com", new DateTime(1995, 02, 02)));
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
