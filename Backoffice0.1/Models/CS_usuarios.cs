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
    
    public partial class CS_usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CS_usuarios()
        {
            this.CS_permisos_asignados = new HashSet<CS_permisos_asignados>();
            this.CS_usuario_login = new HashSet<CS_usuario_login>();
        }
        public ICollection<CS_usuarios> usuarios { get; set; }
        public string ID_USUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string REF { get; set; }
        public string PASS { get; set; }
        public string ID_PERFIL { get; set; }
        public string ID_ROL { get; set; }
        public string TARJETA_EMPLEADO { get; set; }
        public string ESTADO_ACTUAL { get; set; }
        public string GAFETE_IDENTIFICACION { get; set; }
    
        public virtual CS_perfiles CS_perfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CS_permisos_asignados> CS_permisos_asignados { get; set; }
        public virtual CS_roles CS_roles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CS_usuario_login> CS_usuario_login { get; set; }
    }
}