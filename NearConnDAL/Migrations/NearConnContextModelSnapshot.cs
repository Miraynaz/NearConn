﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NearConnDAL.Concrete.EFCore;

namespace NearConnDAL.Migrations
{
    [DbContext(typeof(NearConnContext))]
    partial class NearConnContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("NearConnEL.tbl_Etkinlik", b =>
                {
                    b.Property<int>("EtkinlikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EtkinlikAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EtkinlikAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EtkinlikAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EtkinlikDurum")
                        .HasColumnType("bit");

                    b.Property<string>("EtkinlikResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EtkinlikTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("EtkinlikId");

                    b.ToTable("tbl_Etkinlik");
                });

            modelBuilder.Entity("NearConnEL.tbl_Kullanici", b =>
                {
                    b.Property<int>("KullaniciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciSifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciSoyadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KullaniciId");

                    b.ToTable("tbl_Kullanici");
                });

            modelBuilder.Entity("NearConnEL.tbl_KullaniciEtkinlik", b =>
                {
                    b.Property<int>("EtkinlikId")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.HasKey("EtkinlikId", "KullaniciId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("tbl_KullaniciEtkinlik");
                });

            modelBuilder.Entity("NearConnEL.tbl_KullaniciEtkinlik", b =>
                {
                    b.HasOne("NearConnEL.tbl_Etkinlik", "Etkinlik")
                        .WithMany("KullaniciEtkinliks")
                        .HasForeignKey("EtkinlikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NearConnEL.tbl_Kullanici", "Kullanici")
                        .WithMany("KullaniciEtkinliks")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Etkinlik");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("NearConnEL.tbl_Etkinlik", b =>
                {
                    b.Navigation("KullaniciEtkinliks");
                });

            modelBuilder.Entity("NearConnEL.tbl_Kullanici", b =>
                {
                    b.Navigation("KullaniciEtkinliks");
                });
#pragma warning restore 612, 618
        }
    }
}
