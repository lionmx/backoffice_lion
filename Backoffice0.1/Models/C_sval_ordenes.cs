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
    
    public partial class C_sval_ordenes
    {
        public Nullable<int> id_empresa { get; set; }
        public Nullable<int> id_destinos_entrega { get; set; }
        public Nullable<System.DateTime> fecha_entrega { get; set; }
        public string folio { get; set; }
        public Nullable<int> id_contrato { get; set; }
        public Nullable<int> id_sval_facturar { get; set; }
        public Nullable<decimal> importe_moneda_nacional { get; set; }
        public Nullable<decimal> importe_moneda_extranjera { get; set; }
        public Nullable<decimal> tipo_cambio { get; set; }
        public Nullable<decimal> importe_equivalente { get; set; }
        public string documentos_descripcion { get; set; }
        public string otros_anexos { get; set; }
        public Nullable<decimal> importe_total { get; set; }
        public Nullable<int> id_sval_tipo_servicio { get; set; }
        public Nullable<int> id_remitente_cliente { get; set; }
        public Nullable<int> id_firma_setravalsa { get; set; }
        public Nullable<System.DateTime> fecha_setravalsa { get; set; }
        public Nullable<int> id_firma_consignatario { get; set; }
        public Nullable<System.DateTime> fecha_consignatario { get; set; }
        public string notas_documento { get; set; }
        public Nullable<bool> activo { get; set; }
        public int id_sval_orden { get; set; }
    }
}