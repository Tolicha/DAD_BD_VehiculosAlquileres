using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_2._1.Dto;

namespace Tarea_2._1.Logica
{
    internal class LogicaCarnet
    {
        public ObservableCollection<Carnet> listaCarnets;
        public Carnet arrayCarnet;
        public LogicaCarnet()
        {
            listaCarnets = new ObservableCollection<Carnet>();
            listaCarnets.Add(new Carnet("42112233A", Carnet.Tipo.B, new DateTime(1995, 02, 02), new DateTime(2005, 02, 02)));
        }

        public void addCarnet(Carnet carnet)
        {
            listaCarnets.Add(carnet);
        }

        public void updateCarnet(Carnet carnet, int posicion)
        {
            listaCarnets[posicion] = carnet;
        }

        public void deleteCarnet(Carnet carnet)
        {
            listaCarnets.Remove(carnet);
        }
    }
}
