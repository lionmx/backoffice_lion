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
    
    public partial class C_campaña_medios
    {
        public string id_campaña_medio { get; set; }
        public Nullable<int> id_campaña { get; set; }
        public Nullable<int> id_medio { get; set; }
    
        public virtual C_campañas C_campañas { get; set; }
        public virtual C_medios C_medios { get; set; }
    }
}
