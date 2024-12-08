﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrungTamTinHoc_BE.Data;

#nullable disable

namespace TrungTamTinHoc_BE.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231105091533_Update_KhoaHocModel")]
    partial class Update_KhoaHocModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.CTKhoaHoc", b =>
                {
                    b.Property<string>("maKH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maHV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HocVienmaHV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("KhoaHocmaKH")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("maKH", "maHV");

                    b.HasIndex("HocVienmaHV");

                    b.HasIndex("KhoaHocmaKH");

                    b.ToTable("CTKhoaHocs");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.GiangVien", b =>
                {
                    b.Property<string>("maGV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("maGV");

                    b.ToTable("GiangViens");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.HocVien", b =>
                {
                    b.Property<string>("maHV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenHV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("maHV");

                    b.ToTable("HocViens");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.KhoaHoc", b =>
                {
                    b.Property<string>("maKH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GiangVienmaGV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("luaTuoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<int>("rate")
                        .HasColumnType("int");

                    b.Property<string>("tenKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("maKH");

                    b.HasIndex("GiangVienmaGV");

                    b.ToTable("KhoaHocs");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.LichHoc", b =>
                {
                    b.Property<string>("maKH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ngay")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiaDiem")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("maKH", "ngay", "DiaDiem");

                    b.ToTable("LichHocs");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.PhanQuyen", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TaiKhoanAccount")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RoleId", "Account");

                    b.HasIndex("TaiKhoanAccount");

                    b.ToTable("PhanQuyen");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.TaiKhoan", b =>
                {
                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Account");

                    b.ToTable("TaiKhoans");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.ThongBao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoiTuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDang")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ThongBaos");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.CTKhoaHoc", b =>
                {
                    b.HasOne("TrungTamTinHoc_BE.Models.HocVien", "HocVien")
                        .WithMany("CTKhoaHocs")
                        .HasForeignKey("HocVienmaHV");

                    b.HasOne("TrungTamTinHoc_BE.Models.KhoaHoc", "KhoaHoc")
                        .WithMany("CTKhoaHocs")
                        .HasForeignKey("KhoaHocmaKH");

                    b.Navigation("HocVien");

                    b.Navigation("KhoaHoc");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.KhoaHoc", b =>
                {
                    b.HasOne("TrungTamTinHoc_BE.Models.GiangVien", "GiangVien")
                        .WithMany("khoaHocs")
                        .HasForeignKey("GiangVienmaGV");

                    b.Navigation("GiangVien");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.PhanQuyen", b =>
                {
                    b.HasOne("TrungTamTinHoc_BE.Models.Role", "Role")
                        .WithMany("phanQuyens")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrungTamTinHoc_BE.Models.TaiKhoan", "TaiKhoan")
                        .WithMany("phanQuyens")
                        .HasForeignKey("TaiKhoanAccount");

                    b.Navigation("Role");

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.GiangVien", b =>
                {
                    b.Navigation("khoaHocs");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.HocVien", b =>
                {
                    b.Navigation("CTKhoaHocs");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.KhoaHoc", b =>
                {
                    b.Navigation("CTKhoaHocs");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.Role", b =>
                {
                    b.Navigation("phanQuyens");
                });

            modelBuilder.Entity("TrungTamTinHoc_BE.Models.TaiKhoan", b =>
                {
                    b.Navigation("phanQuyens");
                });
#pragma warning restore 612, 618
        }
    }
}
