﻿#pragma checksum "..\..\Dpto.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "778A51E2354B8DFA1F7C3C9C9AEECA2F32585FFD949A047AE1ABBD55ED5EB791"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using TurismoReal_Desktop;


namespace TurismoReal_Desktop {
    
    
    /// <summary>
    /// Dpto
    /// </summary>
    public partial class Dpto : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\Dpto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_retroceder;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Dpto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_barraBusqueda;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Dpto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sp_inv_mant;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Dpto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_gestInventario;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Dpto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_gestMantenciones;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Dpto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sp_datosDepto;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\Dpto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_nuevoDpto;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TurismoReal_Desktop;component/dpto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Dpto.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btn_retroceder = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Dpto.xaml"
            this.btn_retroceder.Click += new System.Windows.RoutedEventHandler(this.btn_retroceder_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_barraBusqueda = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.sp_inv_mant = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.btn_gestInventario = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btn_gestMantenciones = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.sp_datosDepto = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.btn_nuevoDpto = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\Dpto.xaml"
            this.btn_nuevoDpto.Click += new System.Windows.RoutedEventHandler(this.btn_nuevoDpto_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

