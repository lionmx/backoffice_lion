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
    
    public partial class C_compras_mov_almacen
    {
        public int id_compras_mov_almacen { get; set; }
        public Nullable<int> id_compra_orden { get; set; }
        public Nullable<int> id_bo_semanas_c { get; set; }
        public string codigo_sucursal { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string sku_insumo { get; set; }
        public Nullable<double> cantidad { get; set; }
        public Nullable<bool> entrada_salida { get; set; }
        public Nullable<bool> activo { get; set; }
        public string observaciones { get; set; }
    }
}