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
            gedtb001_demanda = new HashSet<gedtb001_demanda>();
            gedtb004_servico = new HashSet<gedtb004_servico>();
        }

        [Key]
        public int co_tipo_demanda { get; set; }

        [Required]
        [StringLength(200)]
        public string no_tipo_demanda { get; set; }

        public bool ic_multiplo { get; set; }

        public byte nu_prioridade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gedtb001_demanda> gedtb001_demanda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gedtb004_servico> gedtb004_servico { get; set; }
    }
}
