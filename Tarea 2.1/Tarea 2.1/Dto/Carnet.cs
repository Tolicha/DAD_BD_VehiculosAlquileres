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
        private enum Tipo { A1, A2, A, B };
        private DateTime fechaExpedicion;
        private DateTime fechaCaducidad;
        public Carnet()
        {

        }
        public Carnet(/*char tipo,*/ DateTime fechaExpedicion, DateTime fechaCaducidad)
        {
            //this.tipo = tipo;
            this.fechaExpedicion = fechaExpedicion;
            this.fechaCaducidad = fechaCaducidad;
        }

        public string this[string columnName] => throw new NotImplementedException();

        /*public char Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                this.tipo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("tipo"));
            }
        }*/
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
