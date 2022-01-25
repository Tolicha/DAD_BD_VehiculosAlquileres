using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tarea_2._1.Dto;

namespace Tarea_2._1.Logica
{
    public partial class LogicaAlquiler : Window
    {
        public ObservableCollection<Alquiler> listaAlquileres { get; set; }

        public LogicaAlquiler()
        {
            listaAlquileres = new ObservableCollection<Alquiler>();
            listaAlquileres.Add(new Alquiler(new DateTime(2020 - 10 - 01), new DateTime(2020 - 10 - 10), 100, 50, 20000, 25000, "Alquilado", "Terceros", new LogicaCliente().listaClientes[1], new LogicaVehiculo().listaVehiculos[1]));
            listaAlquileres.Add(new Alquiler(new DateTime(2021 - 08 - 11), new DateTime(2021 - 08 - 21), 150, 60, 15000, 30000, "Alquilado", "Terceros ampliado", new LogicaCliente().listaClientes[2], new LogicaVehiculo().listaVehiculos[2]));
            listaAlquileres.Add(new Alquiler(new DateTime(2021 - 02 - 04), new DateTime(2021 - 02 - 04), 1000, 100, 50000, 70000, "Alquilado", "Todo riesgo", new LogicaCliente().listaClientes[3], new LogicaVehiculo().listaVehiculos[3]));
            listaAlquileres.Add(new Alquiler(new DateTime(2021 - 11 - 03), new DateTime(2021 - 11 - 13), 80, 40, 5000, 10000, "Alquilado", "Terceros ampliado", new LogicaCliente().listaClientes[4], new LogicaVehiculo().listaVehiculos[4]));
            listaAlquileres.Add(new Alquiler(new DateTime(2020 - 06 - 22), new DateTime(2021 - 07 - 22), 1100, 110, 30000, 50000, "Alquilado", "Todo riesgo", new LogicaCliente().listaClientes[0], new LogicaVehiculo().listaVehiculos[0]));
        }

        public void addAlquiler(Alquiler alquiler)
        {
            listaAlquileres.Add(alquiler);
        }

        public void updateAlquiler(Alquiler alquiler, int posicion)
        {
            listaAlquileres[posicion] = alquiler;
        }

        public void deleteAlquiler(Alquiler alquiler)
        {
            listaAlquileres.Remove(alquiler);
        }
    }
}
