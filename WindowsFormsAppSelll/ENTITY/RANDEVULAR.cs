namespace WindowsFormsAppSelll.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RANDEVULAR")]
    public partial class RANDEVULAR
    {
        [Key]
        public int RANDEVUID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Randevu_Tarihi { get; set; }

        public TimeSpan? Randevu_Saati { get; set; }

        public int? DOKTORID { get; set; }

        [StringLength(400)]
        public string Bulgu { get; set; }

        public int? HASTAID { get; set; }

        public virtual DOKTORLAR DOKTORLAR { get; set; }

        public virtual HASTALAR HASTALAR { get; set; }
    }
}
