namespace HackIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gedtb001_demanda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gedtb001_demanda()
        {
            gedtb002_historico_demanda = new HashSet<gedtb002_historico_demanda>();
        }

        [Key]
        public int co_demanda { get; set; }

        public int co_origem_demanda { get; set; }

        [StringLength(4)]
        public string co_unidade_origem { get; set; }

        public byte co_tipo_origem_demanda { get; set; }

        public int co_tipo_demanda { get; set; }

        public int co_servico { get; set; }

        public int co_situacao { get; set; }

        public int co_cidadao { get; set; }

        [StringLength(7)]
        public string co_empregado_responsavel { get; set; }

        [Required]
        [StringLength(7)]
        public string co_empregado_cadastro { get; set; }

        public bool ic_demanda_original { get; set; }

        [StringLength(7)]
        public string nu_identificador { get; set; }

        public int? co_demanda_pai { get; set; }

        [StringLength(200)]
        public string no_demandante { get; set; }

        [StringLength(200)]
        public string ed_email_demandante { get; set; }

        public int? co_demanda_dijur { get; set; }


        public virtual gedtb004_servico gedtb004_servico { get; set; }

        public virtual gedtb006_situacao gedtb006_situacao { get; set; }

        public virtual gedtb007_tipo_origem_demanda gedtb007_tipo_origem_demanda { get; set; }

        public virtual gedtb008_tipo_demanda gedtb008_tipo_demanda { get; set; }

        public virtual gedtb031_cidadao gedtb031_cidadao { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gedtb002_historico_demanda> gedtb002_historico_demanda { get; set; }
    }
}
