//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TurismoReal_Desktop_DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class MANTENCION
    {
        public decimal ID_MANTENCION { get; set; }
        public decimal ID_DPTO { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public System.DateTime FECHA_FIN { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal COSTO { get; set; }
    
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
    }
}
