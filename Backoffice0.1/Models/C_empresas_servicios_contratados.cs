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
    
    public partial class C_empresas_servicios_contratados
    {
        public int id_empresa_servicios { get; set; }
        public Nullable<int> id_empresa { get; set; }
        public Nullable<int> id_servicio { get; set; }
        public Nullable<System.DateTime> fecha_contrato { get; set; }
        public string notas { get; set; }
        public Nullable<bool> activo { get; set; }
    
        public virtual C_empresas C_empresas { get; set; }
        public virtual C_servicios C_servicios { get; set; }
    }
}
