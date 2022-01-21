using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2._1.Dto
{
    internal class Vehiculo : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private String marca;
        private String modelo;
        private String matricula;
        private String plaza;
        private double precio;
        private String bastidor;
        private int deposito;
        private int km;
        private Boolean alquilado;
        private DateTime caducidadITV;
        private String tipoVehiculo;

        public Vehiculo() { }
        public Vehiculo(string marca, string modelo, string matricula, string plaza, double precio, string bastidor, int deposito, int km, bool alquilado, DateTime caducidadITV, string tipoVehiculo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.matricula = matricula;
            this.plaza = plaza;
            this.precio = precio;
            this.bastidor = bastidor;
            this.deposito = deposito;
            this.km = km;
            this.alquilado = alquilado;
            this.caducidadITV = caducidadITV;
            this.tipoVehiculo = tipoVehiculo;
        }

        public string this[string columnName] => throw new NotImplementedException();

        public string Marca { get; set; }
        public string Modelo { get; set; }  
        public string Matricula { get; set; }
        public string Plaza { get; set; }
        public double Precio { get; set; }
        public string Bastidor { get; set; }
        public int Deposito { get; set; }
        public int Km { get; set; }
        public Boolean Alquilado { get; set; }
        public DateTime CaducidadITV { get; set; }
        public String TipoVehiculo { get; set; }

        public string Error => throw new NotImplementedException();

        public event PropertyChangedEventHandler? PropertyChanged;

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
