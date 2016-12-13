namespace FinalExam
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DefaultConnectionNew")
        {
           
    }
        public String Index()
        {
            return "Division";
        }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Division>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.Teams)
                .WithRequired(e => e.Division)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Logo)
                .IsUnicode(false);
        }
    }
}
