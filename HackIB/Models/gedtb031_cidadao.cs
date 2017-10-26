namespace HackIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gedtb031_cidadao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gedtb031_cidadao()
        {
            gedtb001_demanda = new HashSet<gedtb001_demanda>();
        }

        [Key]
        public int co_cidadao { get; set; }

        [StringLength(11)]
        public string co_nis { get; set; }

        [StringLength(11)]
        public string co_cpf { get; set; }

        [StringLength(200)]
        public string no_cidadao { get; set; }

        [StringLength(50)]
        public string nu_identificacao { get; set; }

        public int? co_tipo_identificacao { get; set; }

        public int? co_orgao_identificacao { get; set; }

        [StringLength(2)]
        public string co_uf_identificacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dt_emissao_identificacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dt_nascimento { get; set; }

        public int? co_grau_instrucao { get; set; }

        [StringLength(155)]
        public string no_mae { get; set; }

        [StringLength(12)]
        public string nu_telefone { get; set; }

        [StringLength(7)]
        public string co_matricula { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gedtb001_demanda> gedtb001_demanda { get; set; }
    }
}
