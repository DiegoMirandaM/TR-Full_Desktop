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
    
    public partial class TIPO_USUARIO
    {
        public TIPO_USUARIO()
        {
            this.USUARIO = new HashSet<USUARIO>();
        }
    
        public short ID_TIPOUSUARIO { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<USUARIO> USUARIO { get; set; }
    }
}
