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
    
    public partial class C_cajas_g
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_cajas_g()
        {
            this.C_cajas_cambio_turno = new HashSet<C_cajas_cambio_turno>();
            this.C_cajas_movimientos = new HashSet<C_cajas_movimientos>();
            this.C_cajas_sucursales = new HashSet<C_cajas_sucursales>();
        }
    
        public int id_caja { get; set; }
        public string codigo_caja { get; set; }
        public Nullable<System.DateTime> fecha_alta { get; set; }
        public string marca_caja { get; set; }
        public string no_serie { get; set; }
        public string modelo { get; set; }
        public Nullable<int> id_proveedor { get; set; }
        public Nullable<bool> estatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_cajas_cambio_turno> C_cajas_cambio_turno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_cajas_movimientos> C_cajas_movimientos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_cajas_sucursales> C_cajas_sucursales { get; set; }
    }
}
