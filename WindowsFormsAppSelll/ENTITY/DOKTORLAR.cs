namespace WindowsFormsAppSelll.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOKTORLAR")]
    public partial class DOKTORLAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOKTORLAR()
        {
            RANDEVULAR = new HashSet<RANDEVULAR>();
        }

        [StringLength(25)]
        public string DoktorAdi { get; set; }

        [StringLength(25)]
        public string DoktorSoyadi { get; set; }

        [StringLength(25)]
        public string DoktorunBransi { get; set; }

        public int? Doktorun_kati { get; set; }

        [Key]
        public int DOKTORID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RANDEVULAR> RANDEVULAR { get; set; }
    }
}
