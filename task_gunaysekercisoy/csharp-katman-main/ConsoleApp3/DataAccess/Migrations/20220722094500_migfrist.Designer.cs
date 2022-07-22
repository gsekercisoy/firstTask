﻿// <auto-generated />
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220722094500_migfrist")]
    partial class migfrist
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entity.Entities.categories", b =>
                {
                    b.Property<int>("categoryid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("categoryid"), 1L, 1);

                    b.Property<string>("categoryname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("categoryid");

                    b.ToTable("kategoriler");
                });

            modelBuilder.Entity("Entity.Entities.product", b =>
                {
                    b.Property<int>("productid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("productid"), 1L, 1);

                    b.Property<int>("Kategorilercategoryid")
                        .HasColumnType("int");

                    b.Property<string>("productname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("stok")
                        .HasColumnType("int");

                    b.HasKey("productid");

                    b.HasIndex("Kategorilercategoryid");

                    b.ToTable("urunler");
                });

            modelBuilder.Entity("Entity.Entities.product", b =>
                {
                    b.HasOne("Entity.Entities.categories", "Kategoriler")
                        .WithMany("urunler")
                        .HasForeignKey("Kategorilercategoryid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategoriler");
                });

            modelBuilder.Entity("Entity.Entities.categories", b =>
                {
                    b.Navigation("urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
