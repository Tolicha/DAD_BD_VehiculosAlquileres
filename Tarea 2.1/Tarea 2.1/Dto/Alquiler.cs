using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2._1.Dto
{
    public class Alquiler : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private double precioTotal;
        private double fianza;
        private double kmInicio;
        private double kmFin;
        public enum EstadoVehiculo { Alquilado, Libre };
        private EstadoVehiculo estadoVehiculo;
        public enum TipoSeguro { Terceros, TercerosAmpliado, TodoRiesgo };
        private TipoSeguro tipoSeguro;
        public Alquiler()
        {

        }
        public Alquiler(DateTime fechaInicio, DateTime fechaFin, double precioTotal, double fianza, double kmInicio, double kmFin, EstadoVehiculo estadoVehiculo, TipoSeguro tipoSeguro)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.precioTotal = precioTotal;
            this.fianza = fianza;
            this.kmInicio = kmInicio;
            this.kmFin = kmFin;
            this.estadoVehiculo = estadoVehiculo;
            this.tipoSeguro = tipoSeguro;
        }
        
        public string this[string columnName] => throw new NotImplementedException();
        public string Error => throw new NotImplementedException();

        public event PropertyChangedEventHandler? PropertyChanged;
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
