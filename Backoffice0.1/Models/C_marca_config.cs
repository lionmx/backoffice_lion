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
    
    public partial class C_marca_config
    {
        public int id_marca_config { get; set; }
        public Nullable<int> id_marca { get; set; }
        public string logo { get; set; }
        public string color_plantilla { get; set; }
        public string correo { get; set; }
        public string pagina_web { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
    
        public virtual C_marcas C_marcas { get; set; }
    }
}
