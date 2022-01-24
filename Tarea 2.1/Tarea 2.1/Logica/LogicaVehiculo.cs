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
        public ObservableCollection<Vehiculo> listaVehiculos { get; set; }
        public LogicaVehiculo()
        {
            listaVehiculos = new ObservableCollection<Vehiculo>();
            listaVehiculos.Add(new Vehiculo("Opel", "Corsa", "2222BBB", "A11", 50, "17numeros", 40, 20000, true, new DateTime(2024,8,1), new LogicaTipoVehiculo().tiposVehiculos[1]));
            listaVehiculos.Add(new Vehiculo("Toyota", "Prius", "3333CCC", "A12", 100, "17numeros", 50, 10000, false, new DateTime(2025, 8, 1), new LogicaTipoVehiculo().tiposVehiculos[2]));
            listaVehiculos.Add(new Vehiculo("Tanque", "Grande", "7854", "A21", 1000, "17numeros", 200, 0, true, new DateTime(2099, 1, 1), new LogicaTipoVehiculo().tiposVehiculos[3]));
            listaVehiculos.Add(new Vehiculo("Renault", "Clio", "4568TFM", "A31", 20, "17numeros", 40, 30000, false, new DateTime(2024, 12, 1), new LogicaTipoVehiculo().tiposVehiculos[4]));
            listaVehiculos.Add(new Vehiculo("Furgoneta", "Verde", "4521CDF", "A32", 120, "17numeros", 80, 120000, true, new DateTime(2023, 1, 1), new LogicaTipoVehiculo().tiposVehiculos[5]));
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

