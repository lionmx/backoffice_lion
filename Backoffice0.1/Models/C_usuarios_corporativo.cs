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
    
    public partial class C_usuarios_corporativo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_usuarios_corporativo()
        {
            this.C_pedidos = new HashSet<C_pedidos>();
            this.C_usuarios_servicios = new HashSet<C_usuarios_servicios>();
            this.C_usuarios_sucursales = new HashSet<C_usuarios_sucursales>();
            this.C_usuarios_sucursales1 = new HashSet<C_usuarios_sucursales>();
        }
    
        public int id_usuario_corporativo { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public Nullable<int> id_empleado { get; set; }
        public Nullable<int> id_usuario_tipo { get; set; }
        public Nullable<int> id_rol { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> fecha_alta { get; set; }
        public Nullable<bool> Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_pedidos> C_pedidos { get; set; }
        public virtual C_usuarios_roles C_usuarios_roles { get; set; }
        public virtual C_usuarios_tipo C_usuarios_tipo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_usuarios_servicios> C_usuarios_servicios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_usuarios_sucursales> C_usuarios_sucursales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_usuarios_sucursales> C_usuarios_sucursales1 { get; set; }
    }
}