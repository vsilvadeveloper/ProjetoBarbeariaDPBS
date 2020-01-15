//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DPBSv11.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TB_SERVICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SERVICO()
        {
            this.TB_AGENDAMENTO = new HashSet<TB_AGENDAMENTO>();
            this.TB_CATEGORIA = new HashSet<TB_CATEGORIA>();
            this.TB_PROMOCAO = new HashSet<TB_PROMOCAO>();
            this.TB_AGENDA = new HashSet<TB_AGENDA>();
        }

        public int COD_SERVICO { get; set; }
        [Display(Name = "Servi�o")]
        public string SERVICO { get; set; }
        [Display(Name = "Valor")]
        public decimal VALOR { get; set; }
        public Nullable<int> COD_PROMOCAO { get; set; }
        public Nullable<int> COD_FUNCIONARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_AGENDAMENTO> TB_AGENDAMENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_CATEGORIA> TB_CATEGORIA { get; set; }
        public virtual TB_FUNCIONARIO TB_FUNCIONARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PROMOCAO> TB_PROMOCAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_AGENDA> TB_AGENDA { get; set; }
    }
}