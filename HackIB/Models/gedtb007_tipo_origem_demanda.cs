namespace HackIB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gedtb007_tipo_origem_demanda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gedtb007_tipo_origem_demanda()
        {
            gedtb001_demanda = new HashSet<gedtb001_demanda>();
        }

        [Key]
        public byte co_tipo_origem_demanda { get; set; }

        [Required]
        [StringLength(200)]
        public string no_tipo_origem_demanda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gedtb001_demanda> gedtb001_demanda { get; set; }
    }
}
