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
        public ObservableCollection<Cliente> listaClientes { get; set; }

        public LogicaCliente()
        {
            listaClientes = new ObservableCollection<Cliente>();
            listaClientes.Add(new Cliente("42112233A", new Carnet(Carnet.Tipo.B, new DateTime(1995, 02, 02), new DateTime(2005, 02, 02)), "María Hernández", "6667777888", "maria@gmail.com", new DateTime(1975, 12, 14)));
            listaClientes.Add(new Cliente("42112233B", new Carnet(Carnet.Tipo.A2, new DateTime(2000, 10, 05), new DateTime(2010, 10, 05)), "Pedro Martín", "666888999", "pedro@gmail.com", new DateTime(1980, 09, 03)));
            listaClientes.Add(new Cliente("42112233C", new Carnet(Carnet.Tipo.C, new DateTime(1990, 04, 11), new DateTime(2000, 04, 11)), "Julia Álvarez", "666999000", "julia@gmail.com", new DateTime(1970, 05, 17)));
            listaClientes.Add(new Cliente("42112233D", new Carnet(Carnet.Tipo.D1, new DateTime(2005, 03, 22), new DateTime(2015, 03, 22)), "Ruyman Acosta", "666000111", "ruyman@gmail.com", new DateTime(1985, 01, 01)));
            listaClientes.Add(new Cliente("42112233E", new Carnet(Carnet.Tipo.B, new DateTime(2003, 11, 01), new DateTime(2013, 11, 01)), "Ana Brito", "666111222", "ana@gmail.com", new DateTime(1983, 02, 10)));
        }

        public void addCliente(Cliente cliente)
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
