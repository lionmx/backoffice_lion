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
    
    public partial class C_bo_semanas_trans_c3
    {
        public int id_bo_semanas_calculo_t3 { get; set; }
        public Nullable<int> id_empresa { get; set; }
        public Nullable<int> id_semana_de_calculo { get; set; }
        public string codigo_sucursal { get; set; }
        public string sku_insumo { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<decimal> venta_total_calculada { get; set; }
        public Nullable<decimal> existencia { get; set; }
        public Nullable<decimal> necesidad { get; set; }
    }
}