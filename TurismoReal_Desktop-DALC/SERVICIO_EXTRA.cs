//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
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
