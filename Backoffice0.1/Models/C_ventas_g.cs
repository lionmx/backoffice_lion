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
    
    public partial class C_ventas_g
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_ventas_g()
        {
            this.C_ventas_d = new HashSet<C_ventas_d>();
        }
    
        public int id_venta_g { get; set; }
        public Nullable<int> id_sucursal { get; set; }
        public Nullable<int> id_caja { get; set; }
        public string folio { get; set; }
        public string fecha { get; set; }
        public Nullable<int> id_venta_tipo { get; set; }
        public string id_usuario { get; set; }
        public string subtotal { get; set; }
        public string id_impuesto { get; set; }
        public string total { get; set; }
        public string id_factura { get; set; }
        public string status { get; set; }
        public Nullable<int> id_codigo { get; set; }
        public Nullable<int> id_pedido { get; set; }
    
        public virtual C_sucursales C_sucursales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_ventas_d> C_ventas_d { get; set; }
        public virtual C_ventas_tipo C_ventas_tipo { get; set; }
    }
}
