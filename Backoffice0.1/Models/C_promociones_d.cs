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
    
    public partial class C_promociones_d
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_promociones_d()
        {
            this.C_promociones_prods = new HashSet<C_promociones_prods>();
        }
    
        public int id_promocion_det { get; set; }
        public Nullable<int> id_promocion { get; set; }
        public Nullable<bool> combina_prod { get; set; }
        public Nullable<int> no_prod_seleccion { get; set; }
        public Nullable<int> aplica_mprecio { get; set; }
        public Nullable<int> aplica_desc { get; set; }
    
        public virtual C_promociones_g C_promociones_g { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_promociones_prods> C_promociones_prods { get; set; }
    }
}
