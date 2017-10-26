namespace HackIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gedtb004_servico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gedtb004_servico()
        {

        }

        [Key]
        public int co_servico { get; set; }

        [Required]
        [StringLength(200)]
        public string no_servico { get; set; }

        public int? co_grupo { get; set; }

        public int co_tipo_demanda { get; set; }

        public bool ic_sict2 { get; set; }

        [Column(TypeName = "text")]
        public string tx_descricao { get; set; }

        public bool ic_exclusivo_cegov { get; set; }

        public bool ic_upload { get; set; }

        public byte nu_prioridade { get; set; }

        public bool ic_ativo { get; set; }


        public virtual gedtb008_tipo_demanda gedtb008_tipo_demanda { get; set; }
    }
}
