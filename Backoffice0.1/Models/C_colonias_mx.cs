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
    
    public partial class C_colonias_mx
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_colonias_mx()
        {
            this.C_direcciones_mx = new HashSet<C_direcciones_mx>();
            this.C_sucursales_colonias = new HashSet<C_sucursales_colonias>();
        }
    
        public int id { get; set; }
        public string d_codigo { get; set; }
        public string d_asenta { get; set; }
        public string d_tipo_asenta { get; set; }
        public string d_mnpio { get; set; }
        public string d_estado { get; set; }
        public string d_ciudad { get; set; }
        public string d_cp { get; set; }
        public string c_estado { get; set; }
        public string c_oficina { get; set; }
        public string c_cp { get; set; }
        public string c_tipo_asenta { get; set; }
        public string c_mnpio { get; set; }
        public string id_asenta_cpcons { get; set; }
        public string d_zona { get; set; }
        public string c_cve_ciudad { get; set; }
        public string version { get; set; }
        public string codigo_sucursal { get; set; }
        public Nullable<decimal> costo_envio { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_direcciones_mx> C_direcciones_mx { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_sucursales_colonias> C_sucursales_colonias { get; set; }
    }
}