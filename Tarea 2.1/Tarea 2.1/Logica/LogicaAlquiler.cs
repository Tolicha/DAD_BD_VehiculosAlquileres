using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tarea_2._1.Dto;

namespace Tarea_2._1.Logica
{
    public partial class LogicaAlquiler : Window
    {
        public ObservableCollection<Alquiler> listaAlquileres { get; set; }

        public LogicaAlquiler()
        {
            listaAlquileres = new ObservableCollection<Alquiler>();
            listaAlquileres.Add(new Alquiler());
        }

        public void addAlquiler(Alquiler alquiler)
        {
            listaAlquileres.Add(alquiler);
        }

        public void updateAlquiler(Alquiler alquiler, int posicion)
        {
            listaAlquileres[posicion] = alquiler;
        }

        public void deleteCLiente(Alquiler alquiler)
        {
            listaAlquileres.Remove(alquiler);
        }
    }
}
