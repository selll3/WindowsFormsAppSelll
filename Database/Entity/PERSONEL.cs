namespace Database.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PERSONEL")]
    public partial class PERSONEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONEL()
        {
            DOKTORLAR = new HashSet<DOKTORLAR>();
        }

        [StringLength(25)]
        public string PersonelAdi { get; set; }

        [StringLength(25)]
        public string PersonelSoyadi { get; set; }

        [StringLength(25)]
        public string PersonelGorev { get; set; }

        public int PERSONELID { get; set; }

        public int? KULLANICIID { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOKTORLAR> DOKTORLAR { get; set; }

        public virtual GIRIS GIRIS { get; set; }
    }
}
