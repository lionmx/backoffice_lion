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
    
    public partial class C_tipo_empaque
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_tipo_empaque()
        {
            this.C_insumo_cat = new HashSet<C_insumo_cat>();
        }
    
        public int id_tipo_empaque { get; set; }
        public string nombre { get; set; }
        public string largo { get; set; }
        public string ancho { get; set; }
        public string alto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_insumo_cat> C_insumo_cat { get; set; }
    }
}