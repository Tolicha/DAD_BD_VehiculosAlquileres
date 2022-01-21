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


        public TipoVehiculo(string nombreTipo, int plazas) 
        {
            this.NombreTipo = nombreTipo;
            this.Plazas = plazas;
        }

        public TipoVehiculo(string nombreTipo, int plazas, int cargaKg)
        {
            this.NombreTipo = nombreTipo;
            this.Plazas = plazas;
            this.CargaKg = cargaKg;
        }

        public String NombreTipo { 
            get { return nombreTipo; }
            set { nombreTipo = value; }
        }

        public int Plazas
        {
            get { return plazas; }
            set { plazas = value; }
        }

        public int CargaKg
        {
            get { return cargaKg; }
            set { cargaKg = value; }
        }

        public override string ToString()
        {
            return nombreTipo;
        }
    }
}
