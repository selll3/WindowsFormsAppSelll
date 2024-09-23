namespace WindowsFormsAppSelll.ENTITY
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
            PERSONELFORMYETKILERI = new HashSet<PERSONELFORMYETKILERI>();
        }

        [Key]
        public int KULLANICIID { get; set; }

        [StringLength(45)]
        public string KullaniciAdi { get; set; }

        [StringLength(40)]
        public string Parola { get; set; }

        public int? PERSONELID { get; set; }

        public virtual PERSONEL PERSONEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONELFORMYETKILERI> PERSONELFORMYETKILERI { get; set; }
    }


}
