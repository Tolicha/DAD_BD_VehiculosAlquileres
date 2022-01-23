using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2._1.Dto
{
    public class Carnet : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private String titular;
        public enum Tipo { AM, A1, A2, A, B, C1, C, D1, D };
        private Tipo tipo;
        private DateTime fechaExpedicion;
        private DateTime fechaCaducidad;
        public Carnet()
        {

        }
        public Carnet(String titular,  Tipo tipo, DateTime fechaExpedicion, DateTime fechaCaducidad)
        {
            this.titular = titular;
            this.tipo = tipo;
            this.fechaExpedicion = fechaExpedicion;
            this.fechaCaducidad = fechaCaducidad;
        }

        public string this[string columnName] => throw new NotImplementedException();

        public String Titular
        {
            get
            {
                return titular;
            }
            set
            {
                this.titular = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("titular"));
            }
        }
        public DateTime FechaExpedicion
        {
            get
            {
                return fechaExpedicion;
            }
            set
            {
                this.fechaExpedicion = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("fechaExpedicion"));
            }
        }
        public DateTime FechaCaducidad
        {
            get
            {
                return fechaCaducidad;
            }
            set
            {
                this.fechaCaducidad = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("fechaCaducidad"));
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
