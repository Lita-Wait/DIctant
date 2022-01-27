using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Диктант.MVVM.Model
{
    public partial class LiterateModel : DbContext
    {
        public LiterateModel()
            : base("name=LiterateModel")
        {
        }

        public virtual DbSet<Center> Center { get; set; }
        public virtual DbSet<Dictant> Dictant { get; set; }
        public virtual DbSet<Participant> Participant { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Center>()
                .HasMany(e => e.Participant)
                .WithRequired(e => e.Center)
                .HasForeignKey(e => e.Center_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dictant>()
                .HasMany(e => e.Participant)
                .WithRequired(e => e.Dictant)
                .HasForeignKey(e => e.Dictant_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
