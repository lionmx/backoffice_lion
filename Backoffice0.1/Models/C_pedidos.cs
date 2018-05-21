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
    
    public partial class C_pedidos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_pedidos()
        {
            this.C_pedidos_pagos = new HashSet<C_pedidos_pagos>();
            this.C_pedidos_d = new HashSet<C_pedidos_d>();
        }
    
        public int id_pedido { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public string fecha_pedido { get; set; }
        public string fecha_entrega { get; set; }
        public Nullable<int> id_telefono { get; set; }
        public Nullable<int> id_direccion { get; set; }
        public string monto { get; set; }
        public Nullable<int> id_pago_tipo { get; set; }
        public string pago_cantidad { get; set; }
        public string id_pedido_tipo { get; set; }
        public Nullable<int> id_tracking_status { get; set; }
        public Nullable<int> id_pedido_status { get; set; }
        public Nullable<int> id_evento { get; set; }
        public Nullable<int> id_bo_g { get; set; }
    
        public virtual C_clientes C_clientes { get; set; }
        public virtual C_eventos C_eventos { get; set; }
        public virtual C_pago_tipo C_pago_tipo { get; set; }
        public virtual C_pedido_status C_pedido_status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_pedidos_pagos> C_pedidos_pagos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_pedidos_d> C_pedidos_d { get; set; }
        public virtual C_pedidos_tipo C_pedidos_tipo { get; set; }
        public virtual C_tracking_status C_tracking_status { get; set; }
    }
}