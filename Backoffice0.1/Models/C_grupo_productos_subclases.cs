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
    
    public partial class C_grupo_productos_subclases
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_grupo_productos_subclases()
        {
            this.C_grupo_productos_g = new HashSet<C_grupo_productos_g>();
        }
    
        public int id_grupo_producto_subclase { get; set; }
        public Nullable<int> id_grupo_producto_tipo { get; set; }
        public string nombre_subclase { get; set; }
        public string icono_web { get; set; }
        public string icono_app { get; set; }
        public Nullable<int> activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_grupo_productos_g> C_grupo_productos_g { get; set; }
    }
}
