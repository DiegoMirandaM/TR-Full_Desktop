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
    
    public partial class SOLICITUD_TRANSPORTE
    {
        public SOLICITUD_TRANSPORTE()
        {
            this.TRANSPORTE_REALIZADO = new HashSet<TRANSPORTE_REALIZADO>();
        }
    
        public decimal ID_SOLICITUD { get; set; }
        public decimal ID_ARRIENDO { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public decimal PASAJEROS { get; set; }
        public string DIR_INICIO { get; set; }
        public string DIR_DESTINO { get; set; }
        public Nullable<decimal> KMS_DISTANCIA { get; set; }
        public string ACEPTADA { get; set; }
        public Nullable<decimal> COSTO { get; set; }
    
        public virtual ARRIENDO ARRIENDO { get; set; }
        public virtual ICollection<TRANSPORTE_REALIZADO> TRANSPORTE_REALIZADO { get; set; }
    }
}
