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
    
    public partial class C_productos_sucursal
    {
        public int id_productos_sucursal { get; set; }
        public Nullable<int> id_producto { get; set; }
        public Nullable<int> id_sucursal { get; set; }
        public string cantidad { get; set; }
    
        public virtual C_productos_cat C_productos_cat { get; set; }
        public virtual C_sucursales C_sucursales { get; set; }
    }
}
