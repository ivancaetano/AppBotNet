namespace HackIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gedtb008_tipo_demanda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gedtb008_tipo_demanda()
        {
        }

        [Key]
        public int co_tipo_demanda { get; set; }

        [Required]
        [StringLength(200)]
        public string no_tipo_demanda { get; set; }

        public bool ic_multiplo { get; set; }

        public byte nu_prioridade { get; set; }

    }
}
