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
    
    public partial class C_sucursales_config
    {
        public string codigo_sucursal { get; set; }
        public string ip { get; set; }
        public string ubicacion { get; set; }
        public string proximidad { get; set; }
        public string version_startup { get; set; }
        public string version_pv { get; set; }
        public string version_eventos { get; set; }
        public string version_web { get; set; }
        public string version_app { get; set; }
        public string version_mesas { get; set; }
        public string resolucion_pantalla { get; set; }
        public string geo_localizacion_lat { get; set; }
        public string geo_localizacion_ing { get; set; }
        public int id_sucursal_config { get; set; }
    
        public virtual C_sucursales C_sucursales { get; set; }
    }
}