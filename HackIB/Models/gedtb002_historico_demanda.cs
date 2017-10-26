namespace HackIB.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gedtb002_historico_demanda
    {
        [Key]
        public int co_historico { get; set; }

        public int co_demanda { get; set; }

        public int? co_situacao { get; set; }

        public DateTime? dh_historico { get; set; }

        [StringLength(7)]
        public string co_empregado { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string tx_apontamento { get; set; }

        public int? co_equipe { get; set; }

        public byte co_tipo_historico { get; set; }
        [JsonIgnore]
        public virtual gedtb006_situacao gedtb006_situacao { get; set; }
    }
}
