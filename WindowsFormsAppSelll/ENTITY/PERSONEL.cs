namespace WindowsFormsAppSelll.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PERSONEL")]
    public partial class PERSONEL
    {
        [StringLength(25)]
        public string PersonelAdi { get; set; }

        [StringLength(25)]
        public string PersonelSoyadi { get; set; }

        [StringLength(25)]
        public string PersonelGorev { get; set; }

        public int PERSONELID { get; set; }
    }
}
