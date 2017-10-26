namespace HackIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gedtb006_situacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gedtb006_situacao()
        {
            gedtb001_demanda = new HashSet<gedtb001_demanda>();
            gedtb002_historico_demanda = new HashSet<gedtb002_historico_demanda>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int co_situacao { get; set; }

        [Required]
        [StringLength(200)]
        public string no_situacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gedtb001_demanda> gedtb001_demanda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gedtb002_historico_demanda> gedtb002_historico_demanda { get; set; }
    }
}
