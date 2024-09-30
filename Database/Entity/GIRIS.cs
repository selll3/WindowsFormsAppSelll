namespace Database.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GIRIS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIRIS()
        {
            PERSONEL = new HashSet<PERSONEL>();
        }

        [Key]
        public int KULLANICIID { get; set; }

        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [StringLength(50)]
        public string Parola { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONEL> PERSONEL { get; set; }
    }
}
