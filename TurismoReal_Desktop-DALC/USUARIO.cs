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
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.ARRIENDO = new HashSet<ARRIENDO>();
        }
    
        public decimal ID_USUARIO { get; set; }
        public short ID_TIPOUSUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string APE_PAT { get; set; }
        public string APE_MAT { get; set; }
        public int RUT { get; set; }
        public string DV { get; set; }
        public string DIRECCION { get; set; }
        public string CIUDAD { get; set; }
        public string TELEFONO { get; set; }
        public string EMAIL { get; set; }
        public string AREA_FUNCIONARIO { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
    
        public virtual ICollection<ARRIENDO> ARRIENDO { get; set; }
        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
    }
}
