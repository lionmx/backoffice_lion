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
    
    public partial class C_ventas_i
    {
        public int id_ventas_i { get; set; }
        public Nullable<int> id_pedido { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string sku_insumo { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<decimal> costo_porcion { get; set; }
        public Nullable<decimal> costo_total { get; set; }
        public Nullable<bool> esatatus { get; set; }
    }
}
