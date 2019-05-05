namespace Nakliye.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Müsteriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Müsteriler()
        {
            MusteriAdres = new HashSet<MusteriAdres>();
            Taşımalar = new HashSet<Taşımalar>();
        }

        [Key]
        public int MüsteriID { get; set; }

        public int AdresID { get; set; }

        [Required]
        [StringLength(50)]
        public string MüsteriAdı { get; set; }

        [Required]
        [StringLength(50)]
        public string MüsteriSoyadı { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        [StringLength(11)]
        public string TelNo { get; set; }

        [Required]
        [StringLength(50)]
        public string EMail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriAdres> MusteriAdres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taşımalar> Taşımalar { get; set; }
    }
}
