//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backoffice0._1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_marcas_direcciones
    {
        public int id_marca_direccion { get; set; }
        public Nullable<int> id_marca { get; set; }
        public string calle { get; set; }
        public string entre_calle1 { get; set; }
        public string entre_calle2 { get; set; }
        public string no_interior { get; set; }
        public string no_exterior { get; set; }
        public string colonia { get; set; }
        public Nullable<int> ciudad { get; set; }
        public Nullable<int> estado { get; set; }
        public Nullable<int> mpio { get; set; }
        public string cp { get; set; }
        public Nullable<int> pais { get; set; }
    
        public virtual C_marcas_g C_marcas_g { get; set; }
    }
}