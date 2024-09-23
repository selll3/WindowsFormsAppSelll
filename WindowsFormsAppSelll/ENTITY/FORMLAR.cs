

namespace WindowsFormsAppSelll.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FORMLAR")]
    public partial class FORMLAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORMLAR()
        {
            PERSONELFORMYETKILERI = new HashSet<PERSONELFORMYETKILERI>();
        }

        [Key]
        public int FormID { get; set; }

        [Required]
        [StringLength(100)]
        public string FormAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONELFORMYETKILERI> PERSONELFORMYETKILERI { get; set; }
    }


}
