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
    
    public partial class C_sucursales_colonias
    {
        public int id_sucursal_colonias { get; set; }
        public string codigo_sucursal { get; set; }
        public Nullable<int> id_colonia { get; set; }
        public Nullable<decimal> costo_envio { get; set; }
    
        public virtual C_colonias_mx C_colonias_mx { get; set; }
        public virtual C_sucursales C_sucursales { get; set; }
    }
}