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
    
    public partial class C_promociones_g
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_promociones_g()
        {
            this.C_campañas = new HashSet<C_campañas>();
            this.C_promociones_d = new HashSet<C_promociones_d>();
            this.C_promociones_sucursales = new HashSet<C_promociones_sucursales>();
        }
    
        public int id_promocion { get; set; }
        public string nombre { get; set; }
        public string fecha_registro { get; set; }
        public string descripcion { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_final { get; set; }
        public string restricciones { get; set; }
        public string status { get; set; }
        public string banner_pantalla { get; set; }
        public string banner_pos { get; set; }
        public Nullable<decimal> prec_io_unico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_campañas> C_campañas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_promociones_d> C_promociones_d { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_promociones_sucursales> C_promociones_sucursales { get; set; }
    }
}
