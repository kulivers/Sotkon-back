using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        // public DbSet<Record> Records { get; set; }
        public DbSet<Ban> Bans { get; set; }

        public RepositoryContext()
        {
        }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>().Property(b => b.ExistsTime).HasConversion(new TimeSpanToTicksConverter());
            modelBuilder.Entity<Ban>().Property(b => b.ControlSaleTime).HasConversion(new TimeSpanToTicksConverter());
            modelBuilder.Entity<Ban>().Property(b => b.DropTime).HasConversion(new TimeSpanToTicksConverter());

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