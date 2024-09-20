namespace WindowsFormsAppSelll.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIRIS")]
     public partial class GIRIS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIRIS()
        {
           PERSONELFORMYETKILERI = new HashSet<PERSONELFORMYETKILERI>();
        }

        [StringLength(25)]
        public string KullaniciAdi { get; set; }

        [StringLength(25)]
        public string Parola { get; set; }

    
        [Key]
        public int KULLANICIID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONELFORMYETKILERI> PERSONELFORMYETKILERI { get; set; }



     }
}
