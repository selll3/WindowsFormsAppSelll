
namespace WindowsFormsAppSelll.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUAYENE")]
    public partial class MUAYENE
    {
        public int MUAYENEID { get; set; }

        public int? DOKTORID { get; set; }

        public int? RANDEVUID { get; set; }

        public int? HASTAID { get; set; }


        [StringLength(500)]
        public string Aciklama { get; set; }


        [Column(TypeName = "date")]
        public DateTime? MuayeneTarihi { get; set; }

        public bool? islendiBilgisi { get; set; }



        public virtual DOKTORLAR DOKTORLAR { get; set; }

        public virtual HASTALAR HASTALAR { get; set; }

        public virtual RANDEVULAR RANDEVULAR { get; set; }



    }


}
