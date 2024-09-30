namespace Database.Entity
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
            HASTALAR = new HashSet<HASTALAR>();
        }

        [Key]
        public int DOKTORID { get; set; }

        [StringLength(50)]
        public string DoktorAdi { get; set; }

        [StringLength(50)]
        public string DoktorSoyadi { get; set; }

        [StringLength(50)]
        public string DoktorunBransi { get; set; }

        public int? Doktorun_kati { get; set; }

        public int? PERSONELID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HASTALAR> HASTALAR { get; set; }

        public virtual PERSONEL PERSONEL { get; set; }
    }
}
