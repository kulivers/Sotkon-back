using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Record> Records { get; set; }
        public DbSet<Ban> Bans { get; set; }
        
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

            modelBuilder.Entity<Ban>().Property("BanType").HasColumnType("nvarchar(20)");

        }
    }
}