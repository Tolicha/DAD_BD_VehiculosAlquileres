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
        private String estadoVehiculo;
        private String tipoSeguro;
        private Cliente cliente;
        private Vehiculo vehiculo;
        public Alquiler()
        {

        }
        public Alquiler(DateTime fechaInicio, DateTime fechaFin, double precioTotal, double fianza, double kmInicio, double kmFin, String estadoVehiculo, String tipoSeguro)
        {
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.precioTotal = precioTotal;
            this.Fianza = fianza;
            this.KmInicio = kmInicio;
            this.KmFin = kmFin;
            this.EstadoVehiculo = estadoVehiculo;
            this.TipoSeguro = tipoSeguro;
        }
        public DateTime FechaInicio 
        {
            get
            {
                return fechaInicio;
            }
            set 
            {
                this.fechaInicio = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("fechaInicio"));
            }
            
        }
        public DateTime FechaFin 
        {
            get
            {
                return fechaFin;
            }
            set
            {
                this.fechaFin = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("fechaFin"));
            }
        }
        public double PrecioTotal 
        {
            get
            {
                return precioTotal;
            }
            set
            {
                this.precioTotal = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("precioTotal"));
            }
        }
        public double Fianza 
        {
            get
            {
                return fianza;
            }
            set
            {
                this.fianza = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("fianza"));
            }
        }
        public double KmInicio 
        {
            get
            {
                return kmInicio;
            }
            set
            {
                this.kmInicio = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("kmInicio"));
            }
        }
        public double KmFin 
        {
            get
            {
                return kmFin;
            }
            set
            {
                this.kmFin = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("kmFin"));
            }
        }
        public string EstadoVehiculo
        {
            get
            {
                return estadoVehiculo;
            }
            set
            {
                this.estadoVehiculo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("estadoVehiculo"));
            }
        }
        public string TipoSeguro 
        {
            get
            {
                return tipoSeguro;
            }
            set
            {
                this.tipoSeguro = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("tipoSeguro"));
            }
        }
        public Cliente Cliente 
        {
            get
            {
                return cliente;
            }
            set
            {
                this.cliente = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("cliente"));
            }
        }
        public Vehiculo Vehiculo 
        {
            get
            {
                return vehiculo;
            }
            set
            {
                this.vehiculo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("vehiculo"));
            }
        }
        public string Error { get { return ""; } }
        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Fecha Inicio")
                {
                //    if (string.IsNullOrEmpty())
                //        result = "Debe introducir la fecha de inicio del alquiler";
                }
                if (columnName == "Fecha Fin")
                {
                //    if (string.IsNullOrEmpty())
                //        result = "Debe introducir la fecha de fin del alquiler";
                }
                if (columnName == "Precio Total")
                {
                    if (!(precioTotal > 0 || precioTotal < 5000))
                        result = "Debe introducir el precio total del alquiler";
                }
                if (columnName == "Fianza")
                {
                    if (!(Fianza > 0 || Fianza <= 1000))
                        result = "Debe introducir la fianza del alquiler";
                }
                if (columnName == "Km Inicio")
                {
                    if (!(KmInicio > 0 || KmInicio < 100000))
                        result = "Debe introducir los Km del coche al iniciar el alquiler";
                }
                if (columnName == "Km Fin")
                {
                    if (!(KmFin > 0 || KmFin <= 100000))
                        result = "Debe introducir los Km del coche al finalizar el alquiler";
                }
                if (columnName == "Estado del Vehículo")
                {
                    if (string.IsNullOrEmpty(EstadoVehiculo))
                        result = "Debe introducir el estado del vehículo";
                }
                if (columnName == "Tipo de Seguro")
                {
                    if (string.IsNullOrEmpty(TipoSeguro))
                        result = "Debe introducir el tipo de seguro contratado";
                }
                return result;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
