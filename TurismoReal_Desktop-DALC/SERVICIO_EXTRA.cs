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
    
    public partial class SERVICIO_EXTRA
    {
        public SERVICIO_EXTRA()
        {
            this.DISPONIBILIDAD_SERVICIO = new HashSet<DISPONIBILIDAD_SERVICIO>();
            this.SERVICIO_CONTRATADO = new HashSet<SERVICIO_CONTRATADO>();
        }
    
        public decimal ID_SERVICIO { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal COSTO_ACTUAL { get; set; }
    
        public virtual ICollection<DISPONIBILIDAD_SERVICIO> DISPONIBILIDAD_SERVICIO { get; set; }
        public virtual ICollection<SERVICIO_CONTRATADO> SERVICIO_CONTRATADO { get; set; }
    }
}
