﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiMotorcicles;

#nullable disable

namespace WebApiMotorcicles.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApiMotorcicles.Entities.Motor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MotorcicleId")
                        .HasColumnType("int");

                    b.Property<string>("Tamaño")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Turbo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MotorcicleId");

                    b.ToTable("Motores");
                });

            modelBuilder.Entity("WebApiMotorcicles.Entities.Motorcicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Piel")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Motocicletas");
                });

            modelBuilder.Entity("WebApiMotorcicles.Entities.Motor", b =>
                {
                    b.HasOne("WebApiMotorcicles.Entities.Motorcicle", "Motorcicle")
                        .WithMany("Motor")
                        .HasForeignKey("MotorcicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Motorcicle");
                });

            modelBuilder.Entity("WebApiMotorcicles.Entities.Motorcicle", b =>
                {
                    b.Navigation("Motor");
                });
#pragma warning restore 612, 618
        }
    }
}
