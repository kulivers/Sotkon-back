// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace SotkonTestProject.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220707113515_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Ban", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BanType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("ControlSaleTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("DropTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Bans");

                    b.HasDiscriminator<string>("BanType").HasValue("Ban");
                });

            modelBuilder.Entity("Entities.Baget", b =>
                {
                    b.HasBaseType("Entities.Ban");

                    b.HasDiscriminator().HasValue("Baget");
                });

            modelBuilder.Entity("Entities.Crendel", b =>
                {
                    b.HasBaseType("Entities.Ban");

                    b.HasDiscriminator().HasValue("Crendel");
                });

            modelBuilder.Entity("Entities.Croissant", b =>
                {
                    b.HasBaseType("Entities.Ban");

                    b.HasDiscriminator().HasValue("Croissant");
                });

            modelBuilder.Entity("Entities.Smetannik", b =>
                {
                    b.HasBaseType("Entities.Ban");

                    b.HasDiscriminator().HasValue("Smetannik");
                });
#pragma warning restore 612, 618
        }
    }
}
