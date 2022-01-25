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
        public enum Tipo { AM, A1, A2, A, B, C1, C, D1, D };
        private Tipo tipoCarnet;
        private DateTimeOffset fechaExpedicion;
        private DateTimeOffset fechaCaducidad;
        public Carnet()
        {

        }
        public Carnet(Tipo tipoCarnet, DateTimeOffset fechaExpedicion, DateTimeOffset fechaCaducidad)
        {
            this.tipoCarnet = tipoCarnet;
            this.fechaExpedicion = fechaExpedicion;
            this.fechaCaducidad = fechaCaducidad;
        }
        
        public Tipo TipoCarnet
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
        public string Error { get { return ""; } }
        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Tipo de Carnet")
                {
                    if (string.IsNullOrEmpty(tipoCarnet))
                        result = "Debe introducir el tipo del carnet";
                }
                if (columnName == "Fecha de Expedición")
                {
                    //if (string.IsNullOrEmpty())
                    //    result = "Debe introducir la fecha de expedición del carnet";
                }
                if (columnName == "Fecha de Caducidad")
                {
                    //if (string.IsNullOrEmpty())
                    //    result = "Debe introducir la fecha de caducidad del carnet";
                }
                return result;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
