﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2._1.Dto
{
    public class Cliente : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private String nif;
        private Carnet carnet;
        private String nombre;
        private String telefono;
        private String email;
        private DateTime fechaNacimiento; 
        public Cliente()
        {

        }
        public Cliente(string nif, Carnet carnet, string nombre, String telefono, string email, DateTime fechaNacimiento)
        {
            this.nif = nif;
            this.carnet = carnet;
            this.nombre = nombre;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
        }
        public string this[string columnName] => throw new NotImplementedException();
        public String Nif
        {
            get
            {
                return nif; 
            }
            set
            {
                this.nif = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("nif"));
            }
        }
        public Carnet Carnet
        {
            get
            {
                return carnet;
            }
            set
            {
                this.carnet = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("arrayCarnet"));
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("nombre"));
            }
        }
        public String Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                this.telefono = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("telefono"));
            }
        }
        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                this.email = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("email"));
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("fechaNacimiento"));
            }
        }
        public string Error => throw new NotImplementedException();

        public event PropertyChangedEventHandler? PropertyChanged;
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}