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
    
    public partial class Acta_v1
    {
        public string Folio { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Empresa { get; set; }
        public string Destino { get; set; }
        public string No_Sello { get; set; }
        public Nullable<decimal> Diferencia { get; set; }
        public Nullable<int> id_sval_orden1 { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public Nullable<decimal> Importe_Faltante { get; set; }
        public Nullable<decimal> Sin_Valor { get; set; }
        public Nullable<decimal> Sobrante_Fisico { get; set; }
        public Nullable<decimal> Presuntamente_Falso { get; set; }
        public int id_sval_actas { get; set; }
    }
}