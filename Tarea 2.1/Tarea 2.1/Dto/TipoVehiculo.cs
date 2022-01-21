using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2._1.Dto
{   
    public class TipoVehiculo
    {
        private String nombreTipo;
        private int plazas;
        private int cargaKg;

        public String NombreTipo { 
            get { return nombreTipo; }
            set { nombreTipo = value; }
        }
    }
}
