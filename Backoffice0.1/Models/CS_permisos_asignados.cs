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
    
    public partial class CS_permisos_asignados
    {
        public Nullable<int> ID_USUARIO { get; set; }
        public string CODIGO_USUARIO { get; set; }
        public Nullable<int> ID_ROL { get; set; }
        public string ID_PERMISO { get; set; }
        public decimal ID_PERMISO_ASIGNADOS { get; set; }
        public Nullable<int> ID_SERVICIOS_MODULOS { get; set; }
        public Nullable<bool> ACTIVO { get; set; }
        public Nullable<int> ID_MODULO { get; set; }
    
        public virtual CS_usuarios CS_usuarios { get; set; }
    }
}
