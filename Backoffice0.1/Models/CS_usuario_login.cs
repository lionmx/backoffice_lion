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
    
    public partial class CS_usuario_login
    {
        public decimal ID_LOGIN { get; set; }
        public string ID_USUARIO { get; set; }
        public string PASS { get; set; }
        public string FECHA_LOGIN { get; set; }
    
        public virtual CS_usuarios CS_usuarios { get; set; }
    }
}
