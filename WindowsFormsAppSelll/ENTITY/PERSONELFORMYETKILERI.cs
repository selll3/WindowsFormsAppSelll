

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
        [Key]
        public int YetkiID { get; set; }

        public int? FormID { get; set; }

        public bool Yetki { get; set; }

        public int? KULLANICIID { get; set; }

        public virtual FORMLAR FORMLAR { get; set; }

        public virtual GIRIS GIRIS { get; set; }
    }

}
