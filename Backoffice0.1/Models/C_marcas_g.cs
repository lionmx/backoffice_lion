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
    
    public partial class C_marcas_g
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_marcas_g()
        {
            this.C_marcas_direcciones = new HashSet<C_marcas_direcciones>();
            this.C_marcas_sociedades = new HashSet<C_marcas_sociedades>();
            this.C_pedidos = new HashSet<C_pedidos>();
            this.C_sucursales_marcas = new HashSet<C_sucursales_marcas>();
        }
    
        public int id_marca { get; set; }
        public string nombre_marca { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public string logo { get; set; }
        public string sitio_web { get; set; }
        public string color { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public Nullable<bool> status { get; set; }
        public string telefono { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_marcas_direcciones> C_marcas_direcciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_marcas_sociedades> C_marcas_sociedades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_pedidos> C_pedidos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_sucursales_marcas> C_sucursales_marcas { get; set; }
    }
}
