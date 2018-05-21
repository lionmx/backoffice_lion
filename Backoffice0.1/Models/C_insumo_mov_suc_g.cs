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
    
    public partial class C_insumo_mov_suc_g
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_insumo_mov_suc_g()
        {
            this.C_insumo_mov_suc_d = new HashSet<C_insumo_mov_suc_d>();
        }
    
        public int id_insumo_mov { get; set; }
        public string fuente_origen { get; set; }
        public string fuente_destino { get; set; }
        public string usuario_solicitante { get; set; }
        public string usuario_receptor { get; set; }
        public string usuario_autorizacion { get; set; }
        public string firma_usuario_sol { get; set; }
        public string firma_usuario_rec { get; set; }
        public string firma_usuario_autorizacion { get; set; }
        public string fecha { get; set; }
        public string id_usuario { get; set; }
        public Nullable<int> id_tipo_mov { get; set; }
        public string observaciones { get; set; }
        public Nullable<int> id_insumo_mov_status { get; set; }
    
        public virtual C_insumo_mov_status C_insumo_mov_status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C_insumo_mov_suc_d> C_insumo_mov_suc_d { get; set; }
        public virtual C_insumo_tipo_mov C_insumo_tipo_mov { get; set; }
    }
}
