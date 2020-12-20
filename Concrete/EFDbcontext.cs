using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication1.Concrete
{
    public partial class EFDbcontext : DbContext
    {
        public EFDbcontext()
            : base("name=EFDbcontext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Actors> Actors { get; set; }
        public virtual DbSet<Films> Films { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actors>()
                .HasMany(e => e.Films)
                .WithMany(e => e.Actors)
                .Map(m => m.ToTable("FilmActors").MapLeftKey("Actor_actor_id").MapRightKey("Film_film_id"));
        }
    }
}
