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
    
    public partial class C_clientes_direccion
    {
        public int id_clientes_direccion { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<int> id_direccion { get; set; }
    
        public virtual C_clientes C_clientes { get; set; }
        public virtual C_direcciones C_direcciones { get; set; }
    }
}
