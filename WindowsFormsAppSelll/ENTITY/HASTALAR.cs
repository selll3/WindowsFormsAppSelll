namespace WindowsFormsAppSelll.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HASTALAR")]
    public partial class HASTALAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HASTALAR()
        {
            RANDEVULAR = new HashSet<RANDEVULAR>();
        }

        [StringLength(25)]
        public string HastaAdi { get; set; }

        [StringLength(25)]
        public string HastaSoyadi { get; set; }

        public int? HastaYasi { get; set; }

        [Key]
        public int HASTAID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RANDEVULAR> RANDEVULAR { get; set; }
    }
}
