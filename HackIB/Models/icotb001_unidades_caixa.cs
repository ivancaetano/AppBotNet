namespace HackIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class icotb001_unidades_caixa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public icotb001_unidades_caixa()
        {

        }

        [Key]
        [StringLength(4)]
        public string nu_unidade { get; set; }

        public int dv_unidade { get; set; }

        [Required]
        [StringLength(70)]
        public string no_unidade { get; set; }

        [StringLength(10)]
        public string ed_alias { get; set; }

        [StringLength(100)]
        public string ed_email_interno { get; set; }

        [StringLength(100)]
        public string ed_email_externo { get; set; }

        [StringLength(4)]
        public string no_situacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dt_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dt_fim { get; set; }

        public int? nu_tipo { get; set; }

        [StringLength(10)]
        public string no_tipo { get; set; }

        [StringLength(5)]
        public string sg_unidade { get; set; }

        [StringLength(7)]
        public string co_ibge { get; set; }

        [StringLength(2)]
        public string co_uf { get; set; }

    }
}
