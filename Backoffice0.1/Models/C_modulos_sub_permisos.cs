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
    
    public partial class C_modulos_sub_permisos
    {
        public int id_modulos_sub_permiso { get; set; }
        public Nullable<int> id_modulos_sub { get; set; }
        public Nullable<int> id_permiso { get; set; }
        public Nullable<int> id_rol { get; set; }
        public Nullable<bool> estatus { get; set; }
    
        public virtual C_modulos_sub C_modulos_sub { get; set; }
        public virtual C_modulos_tipo_permisos C_modulos_tipo_permisos { get; set; }
        public virtual C_usuarios_roles C_usuarios_roles { get; set; }
    }
}
