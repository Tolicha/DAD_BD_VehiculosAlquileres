using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_2._1.Dto;

namespace Tarea_2._1.Logica
{
    public class LogicaTipoVehiculo
    {
        public List<TipoVehiculo> tiposVehiculos { get; set; }
        public LogicaTipoVehiculo()
        {
            tiposVehiculos = new List<TipoVehiculo>();
            tiposVehiculos.Add(new TipoVehiculo("Vehículo mixto", 2, 4100));
            tiposVehiculos.Add(new TipoVehiculo("Coche 5 plazas", 5));
            tiposVehiculos.Add(new TipoVehiculo("Coche 7 plazas", 7));
            tiposVehiculos.Add(new TipoVehiculo("Coche 9 plazas", 9));
            tiposVehiculos.Add(new TipoVehiculo("Guagua micro", 9));
            tiposVehiculos.Add(new TipoVehiculo("Guagua grande", 54));
            tiposVehiculos.Add(new TipoVehiculo("Furgoneta", 2, 3500));
            tiposVehiculos.Add(new TipoVehiculo("Camion", 2, 7000));
        }

    }
}
