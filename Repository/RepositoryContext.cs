using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        // public DbSet<Baget> Bagets { get; set; }
        // public DbSet<Crendel> Crendels { get; set; }
        // public DbSet<Croissant> Croissants { get; set; }
        // public DbSet<Smetannik> Smetanniks { get; set; }
        //
        // public DbSet<Record> Records { get; set; }

        public RepositoryContext()
        {
        }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .ToTable("Bans")
                .HasDiscriminator<string>("BanType")
                .HasValue<Baget>("Baget")
                .HasValue<Crendel>("Crendel")
                .HasValue<Croissant>("Croissant")
                .HasValue<Smetannik>("Smetannik");
        }
    }
}