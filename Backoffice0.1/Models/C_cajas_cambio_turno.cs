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
    
    public partial class C_cajas_cambio_turno
    {
        public int id_cajas_cambio_turno { get; set; }
        public Nullable<int> id_usuario_corp_entrega { get; set; }
        public Nullable<int> id_usuario_corp_recibe { get; set; }
        public Nullable<System.DateTime> fecha_cambio { get; set; }
        public Nullable<int> id_caja { get; set; }
        public Nullable<decimal> monto { get; set; }
        public string notas { get; set; }
    
        public virtual C_cajas_g C_cajas_g { get; set; }
    }
}