﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _22_23.Data;

#nullable disable

namespace _22_23.Migrations
{
    [DbContext(typeof(MVCDbContext))]
    [Migration("20240115155927_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_22_23.Models.ChuyenBay", b =>
                {
                    b.Property<string>("MaCH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Chuyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DDen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DDi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GBay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GDen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaMB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ngay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thuong")
                        .HasColumnType("int");

                    b.Property<int>("Vip")
                        .HasColumnType("int");

                    b.HasKey("MaCH");

                    b.ToTable("ChuyenBay");
                });

            modelBuilder.Entity("_22_23.Models.CT_CB", b =>
                {
                    b.Property<string>("MaCH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaHK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("LoaiGhe")
                        .HasColumnType("bit");

                    b.Property<string>("SoGhe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaCH", "MaHK");

                    b.ToTable("CT_CB");
                });

            modelBuilder.Entity("_22_23.Models.HanhKhach", b =>
                {
                    b.Property<string>("MaHK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaHK");

                    b.ToTable("HanhKhach");
                });

            modelBuilder.Entity("_22_23.Models.MayBay", b =>
                {
                    b.Property<string>("MaMB")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HangMB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoCho")
                        .HasColumnType("int");

                    b.HasKey("MaMB");

                    b.ToTable("MayBay");
                });
#pragma warning restore 612, 618
        }
    }
}
