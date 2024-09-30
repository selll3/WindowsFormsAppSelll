namespace Database.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RANDEVULAR")]
    public partial class RANDEVULAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RANDEVULAR()
        {
            MUAYENE = new HashSet<MUAYENE>();
        }

        [Key]
        public int RANDEVUID { get; set; }

        public DateTime? Randevu_Tarihi { get; set; }

        public TimeSpan? Randevu_Saati { get; set; }

        public int? DOKTORID { get; set; }

        [StringLength(400)]
        public string Bulgu { get; set; }

        public int? HASTAID { get; set; }

        public virtual HASTALAR HASTALAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUAYENE> MUAYENE { get; set; }
    }
}
