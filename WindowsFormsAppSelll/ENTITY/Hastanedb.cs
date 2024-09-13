using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsAppSelll.ENTITY
{
    public partial class Hastanedb : DbContext
    {
        public Hastanedb()
            : base("name=Hastanedb")
        {
        }

        public virtual DbSet<DOKTORLAR> DOKTORLAR { get; set; }
        public virtual DbSet<HASTALAR> HASTALAR { get; set; }
        public virtual DbSet<PERSONEL> PERSONEL { get; set; }
        public virtual DbSet<RANDEVULAR> RANDEVULAR { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DOKTORLAR>()
                .HasMany(e => e.RANDEVULAR)
                .WithOptional(e => e.DOKTORLAR)
                .WillCascadeOnDelete();
        }
    }
}
