

namespace WindowsFormsAppSelll.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PERSONELFORMYETKILERI")]
    public partial class PERSONELFORMYETKILERI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONELFORMYETKILERI()
        {

        }
        [Key] // YetkiID'yi anahtar olarak belirtiyoruz
        public int YetkiID { get; set; }

        public bool Yetki { get; set; }

        public int? KULLANICIID { get; set; }

        public int? FormID { get; set; }

        [ForeignKey("FormID")]
        public virtual FORMLAR Form { get; set; }
        //public Boolean Yetki { get; set; }


        //public int? KULLANICIID { get; set; }

        //public int?  FormID { get; set; }

        //[Key]
        //public int YetkiID { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        //[ForeignKey("FormID")]
        //public FORMLAR Form { get; set; }








    }
}
