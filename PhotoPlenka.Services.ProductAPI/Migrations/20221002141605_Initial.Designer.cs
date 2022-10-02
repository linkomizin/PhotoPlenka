﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhotoPlenka.Services.ProductAPI.DbContexts;

#nullable disable

namespace PhotoPlenka.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221002141605_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PhotoPlenka.Services.ProductAPI.DbContexts.Models.SiteAddress", b =>
                {
                    b.Property<int>("SiteAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AddressItem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SiteDataSiteId")
                        .HasColumnType("int");

                    b.HasKey("SiteAddressId");

                    b.HasIndex("SiteDataSiteId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("PhotoPlenka.Services.ProductAPI.DbContexts.Models.SiteData", b =>
                {
                    b.Property<int>("SiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AddresSite")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NameSite")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("XpathName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("XpathOnSale")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("XpathPrice")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SiteId");

                    b.ToTable("SiteDatas");
                });

            modelBuilder.Entity("PhotoPlenka.Services.ProductAPI.DbContexts.Models.SiteAddress", b =>
                {
                    b.HasOne("PhotoPlenka.Services.ProductAPI.DbContexts.Models.SiteData", "SiteData")
                        .WithMany("Addresses")
                        .HasForeignKey("SiteDataSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SiteData");
                });

            modelBuilder.Entity("PhotoPlenka.Services.ProductAPI.DbContexts.Models.SiteData", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
