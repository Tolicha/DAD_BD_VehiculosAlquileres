﻿#pragma checksum "..\..\..\..\Vista\CrearAlquiler.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33E5809219B8E7EB0D15F27C58B452B42E401DE6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Tarea_2._1.Vista;


namespace Tarea_2._1.Vista {
    
    
    /// <summary>
    /// CrearAlquiler
    /// </summary>
    public partial class CrearAlquiler : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Vista\CrearAlquiler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboVehiculos;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Vista\CrearAlquiler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboClientes;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Vista\CrearAlquiler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton todoRiesgo;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Vista\CrearAlquiler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton terceros;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Vista\CrearAlquiler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker calendarioFin;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Vista\CrearAlquiler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker calendarioInicio;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Vista\CrearAlquiler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button anadirBoton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tarea 2.1;component/vista/crearalquiler.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vista\CrearAlquiler.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.comboVehiculos = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\..\Vista\CrearAlquiler.xaml"
            this.comboVehiculos.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 2:
            this.comboClientes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\..\Vista\CrearAlquiler.xaml"
            this.comboClientes.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 29 "..\..\..\..\Vista\CrearAlquiler.xaml"
            ((System.Windows.Controls.TextBox)(target)).AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 32 "..\..\..\..\Vista\CrearAlquiler.xaml"
            ((System.Windows.Controls.TextBox)(target)).AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 5:
            this.todoRiesgo = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.terceros = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            
            #line 41 "..\..\..\..\Vista\CrearAlquiler.xaml"
            ((System.Windows.Controls.TextBox)(target)).AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 44 "..\..\..\..\Vista\CrearAlquiler.xaml"
            ((System.Windows.Controls.TextBox)(target)).AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 47 "..\..\..\..\Vista\CrearAlquiler.xaml"
            ((System.Windows.Controls.TextBox)(target)).AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 10:
            this.calendarioFin = ((System.Windows.Controls.DatePicker)(target));
            
            #line 50 "..\..\..\..\Vista\CrearAlquiler.xaml"
            this.calendarioFin.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 11:
            this.calendarioInicio = ((System.Windows.Controls.DatePicker)(target));
            
            #line 53 "..\..\..\..\Vista\CrearAlquiler.xaml"
            this.calendarioInicio.AddHandler(System.Windows.Controls.Validation.ErrorEvent, new System.EventHandler<System.Windows.Controls.ValidationErrorEventArgs>(this.Validation_Error));
            
            #line default
            #line hidden
            return;
            case 12:
            this.anadirBoton = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Vista\CrearAlquiler.xaml"
            this.anadirBoton.Click += new System.Windows.RoutedEventHandler(this.anadirBoton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

