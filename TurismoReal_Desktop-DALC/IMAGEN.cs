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
    
    public partial class IMAGEN
    {
        public decimal ID_IMAGEN { get; set; }
        public decimal ID_DPTO { get; set; }
        public byte[] FOTO { get; set; }
    
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
    }
}
