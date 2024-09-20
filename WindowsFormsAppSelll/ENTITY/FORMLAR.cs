

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

        }

        [Key] // FormID'yi anahtar olarak belirtiyoruz
        public int FormID { get; set; }

        [StringLength(25)]
        public string FormAdi { get; set; }

        public virtual ICollection<PERSONELFORMYETKILERI> PERSONELFORMYETKILERIs { get; set; }

        //[StringLength(25)]
        //public string FormAdi { get; set; }


        //[Key]
        //public int FormID { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        //public virtual ICollection<PERSONELFORMYETKILERI> PERSONELFORMYETKILERIs { get; set; }



    }



    }
