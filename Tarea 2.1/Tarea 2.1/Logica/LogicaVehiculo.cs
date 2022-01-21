using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_2._1.Dto;

namespace Tarea_2._1.Logica
{
        public class LogicaVehiculo
        {
        public ObservableCollection<Vehiculo> listaVehiculos;
        public LogicaVehiculo()
        {
            listaVehiculos = new ObservableCollection<Vehiculo>();
            listaVehiculos.Add(new Vehiculo());
        }

        public void addVehiculo(Vehiculo vehiculo)
        {
            listaVehiculos.Add(vehiculo);
        }

        public void updateVehiculo(Vehiculo vehiculo, int posicion)
        {
            listaVehiculos[posicion] = vehiculo;
        }

        public void deleteVehiculo(Vehiculo vehiculo)
        {
            listaVehiculos.Remove(vehiculo);
        }
    }
}

