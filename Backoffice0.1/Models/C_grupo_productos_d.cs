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
    
    public partial class C_grupo_productos_d
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_grupo_productos_d()
        {
            this.C_grupo_productos_prods = new HashSet<C_grupo_productos_prods>();
            this.C_grupo_productos_prods1 = new HashSet<C_grupo_productos_prods>();
            this.C_grupo_productos_prods2 = new HashSet<C_grupo_productos_prods>();
        }
    
        public int id_grupo_productos_det { get; set; }
        public Nullable<int> id_grupo_productos { get; set; }
        public Nullable<bool> combina_prod { get; set; }
        public Nullable<int> no_prod_seleccion { get; set; }
    
        public virtual C_grupo_productos_g C_grupo_productos_g { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_grupo_productos_prods> C_grupo_productos_prods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_grupo_productos_prods> C_grupo_productos_prods1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_grupo_productos_prods> C_grupo_productos_prods2 { get; set; }
        public virtual C_grupo_productos_g C_grupo_productos_g1 { get; set; }
    }
}