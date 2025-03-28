﻿// <auto-generated />
using System;
using CSharp5Nhom2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSharp5Nhom2.Migrations
{
    [DbContext(typeof(DBSach))]
    partial class DBSachModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CSharp5Nhom2.Models.GioHang", b =>
                {
                    b.Property<Guid>("IDGH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IDGH");

                    b.HasIndex("IDUser")
                        .IsUnique();

                    b.ToTable("gioHangs");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.GioHangChiTiet", b =>
                {
                    b.Property<Guid>("IDGHCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IDGH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSach")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TenSach")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserIDUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDGHCT");

                    b.HasIndex("IDGH");

                    b.HasIndex("IDSach");

                    b.HasIndex("UserIDUser");

                    b.ToTable("gioHangChiTiets");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.HoaDon", b =>
                {
                    b.Property<Guid>("IDHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("IDHoaDon");

                    b.HasIndex("IDUser");

                    b.ToTable("hoaDons");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IDHoaDonChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("IDHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSach")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IDHoaDonChiTiet");

                    b.HasIndex("IDHD");

                    b.HasIndex("IDSach");

                    b.ToTable("hoaDonChiTiets");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.NhaXuatBan", b =>
                {
                    b.Property<string>("IDNXB")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenNXB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDNXB");

                    b.ToTable("nhaXuatBans");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.Sach", b =>
                {
                    b.Property<Guid>("IDSach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDNXB")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IDTacGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IDTheLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSach")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDSach");

                    b.HasIndex("IDNXB");

                    b.HasIndex("IDTacGia");

                    b.HasIndex("IDTheLoai");

                    b.ToTable("sachs");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.TacGia", b =>
                {
                    b.Property<string>("IDTacGia")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenTacGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDTacGia");

                    b.ToTable("tacGias");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.TheLoai", b =>
                {
                    b.Property<string>("IDTheLoai")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenTheLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDTheLoai");

                    b.ToTable("theLoais");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.User", b =>
                {
                    b.Property<Guid>("IDUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IDUser");

                    b.ToTable("users");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.GioHang", b =>
                {
                    b.HasOne("CSharp5Nhom2.Models.User", "User")
                        .WithOne("GioHang")
                        .HasForeignKey("CSharp5Nhom2.Models.GioHang", "IDUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.GioHangChiTiet", b =>
                {
                    b.HasOne("CSharp5Nhom2.Models.GioHang", "GioHang")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("IDGH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharp5Nhom2.Models.Sach", "Sach")
                        .WithMany()
                        .HasForeignKey("IDSach")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CSharp5Nhom2.Models.User", null)
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("UserIDUser");

                    b.Navigation("GioHang");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.HoaDon", b =>
                {
                    b.HasOne("CSharp5Nhom2.Models.User", "User")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("CSharp5Nhom2.Models.HoaDon", "HoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IDHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharp5Nhom2.Models.Sach", "Sach")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IDSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.Sach", b =>
                {
                    b.HasOne("CSharp5Nhom2.Models.NhaXuatBan", "NhaXuatBan")
                        .WithMany("Sachs")
                        .HasForeignKey("IDNXB")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharp5Nhom2.Models.TacGia", "TacGia")
                        .WithMany("Sachs")
                        .HasForeignKey("IDTacGia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CSharp5Nhom2.Models.TheLoai", "TheLoai")
                        .WithMany("Sachs")
                        .HasForeignKey("IDTheLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhaXuatBan");

                    b.Navigation("TacGia");

                    b.Navigation("TheLoai");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.GioHang", b =>
                {
                    b.Navigation("GioHangChiTiets");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.NhaXuatBan", b =>
                {
                    b.Navigation("Sachs");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.Sach", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.TacGia", b =>
                {
                    b.Navigation("Sachs");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.TheLoai", b =>
                {
                    b.Navigation("Sachs");
                });

            modelBuilder.Entity("CSharp5Nhom2.Models.User", b =>
                {
                    b.Navigation("GioHang")
                        .IsRequired();

                    b.Navigation("GioHangChiTiets");

                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
