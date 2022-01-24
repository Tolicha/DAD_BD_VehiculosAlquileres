using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarea_2._1.Dto
{
    public class Vehiculo : INotifyPropertyChanged, ICloneable, IDataErrorInfo
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
        private DateTimeOffset caducidadITV;
        private String tipoVehiculo;

        public Vehiculo() { }
        public Vehiculo(string marca, string modelo, string matricula, string plaza, double precio, string bastidor, int deposito, int km, bool alquilado, DateTimeOffset caducidadITV, String tipoVehiculo)
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

        public string Marca 
        {
            get
            { 
                return marca;
            }
            set
            {
                this.marca = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("marca"));
            }

        }
        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                this.modelo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("modelo"));
            }

        }
        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                this.matricula = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("matricula"));
            }

        }
        public string Plaza
        {
            get
            {
                return plaza;
            }
            set
            {
                this.plaza = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("plaza"));
            }

        }
        public double Precio
        {
            get
            {
                return precio;
            }
            set
            {
                this.precio = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("precio"));
            }

        }
        public string Bastidor
        {
            get
            {
                return bastidor;
            }
            set
            {
                this.bastidor = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("bastidor"));
            }

        }
        public int Deposito
        {
            get
            {
                return deposito;
            }
            set
            {
                this.deposito = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("deposito"));
            }

        }
        public int Km
        {
            get
            {
                return km;
            }
            set
            {
                this.km = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("km"));
            }

        }
        public Boolean Alquilado
        {
            get
            {
                return alquilado;
            }
            set
            {
                this.alquilado = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("alquilado"));
            }

        }
        public DateTimeOffset CaducidadITV
        {
            get
            {
                return caducidadITV;
            }
            set
            {
                this.caducidadITV = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("caducidadITV"));
            }

        }
        public String TipoVehiculo 
        {
            get
            {
                return tipoVehiculo;
            }
            set
            {
                this.tipoVehiculo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("tipoVehiculo"));
            }
        }

        public string Error { get { return ""; } }
        public string this[string columnName] {
            get
            {
                string result = "";
                if (columnName == "Matricula")
                {
                    if (string.IsNullOrEmpty(Matricula) || new Regex("[0-9]{4}-[BCDFGHJKLMNPRSTVWXYZ]{3}").IsMatch(Matricula))
                        result = "Debe introducir la matrícula con formato 0000-XXX";
                }
                if (columnName == "Modelo")
                {
                    if (string.IsNullOrEmpty(Modelo))
                        result = "Debe introducir el modelo del coche";
                }
                if (columnName == "Marca")
                {
                    if (string.IsNullOrEmpty(Matricula))
                        result = "Debe introducir la marca del vehículo";
                }
                if (columnName == "Plaza")
                {
                    if (string.IsNullOrEmpty(Modelo))
                        result = "Introduce la plaza del vehículo";
                }
                if (columnName == "Precio")
                {
                    if (string.IsNullOrEmpty(Matricula))
                        result = "Debe introducir el PVP del alquiler";
                }
                if (columnName == "Bastidor")
                {
                    if (string.IsNullOrEmpty(Modelo))
                        result = "Debe introducir el número de bastidor";
                }
                if (columnName == "Deposito")
                {
                    if (string.IsNullOrEmpty(Modelo))
                        result = "Debe introducir la capacidad del depósito en litros";
                }
                if (columnName == "Km")
                {
                    if (string.IsNullOrEmpty(Modelo))
                        result = "Debe introducir el número de Km del vehículo";
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
