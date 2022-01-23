﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tarea_2._1
{
    /// <summary>
    /// Lógica de interacción para WindowCliente.xaml
    /// </summary>
    public partial class WindowCliente : Window
    {
        private LogicaCliente logicaCliente;
        public WindowCliente()
        {
            InitializeComponent();
            logicaCliente = new LogicaCliente();
            DatagridCliente.DataContext = logicaCliente;
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
