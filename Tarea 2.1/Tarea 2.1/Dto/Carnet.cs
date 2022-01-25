using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2._1.Dto
{
    public class Carnet : INotifyPropertyChanged, ICloneable
    {
        public String tipoCarnet;
        private DateTimeOffset fechaExpedicion;
        private DateTimeOffset fechaCaducidad;
        public Carnet()
        {

        }
        public Carnet(String tipoCarnet, DateTimeOffset fechaExpedicion, DateTimeOffset fechaCaducidad)
        {
            this.tipoCarnet = tipoCarnet;
            this.fechaExpedicion = fechaExpedicion;
            this.fechaCaducidad = fechaCaducidad;
        }
        
        public string TipoCarnet
        {
            get
            {
                return tipoCarnet;
            }

            set
            {
                this.tipoCarnet = value;
            }
        }

        public DateTimeOffset FechaExpedicion
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
        public DateTimeOffset FechaCaducidad
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
        

        public event PropertyChangedEventHandler? PropertyChanged;

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return tipoCarnet;
        }
    }
}
