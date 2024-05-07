﻿// <auto-generated />
using System;
using ChamCong_BackEnd.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChamCong_BackEnd.Server.Migrations
{
    [DbContext(typeof(NhanDienDbContext))]
    [Migration("20240416032833_newdata")]
    partial class newdata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChamCong_BackEnd.Server.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Base_Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("ChamCong_BackEnd.Server.Models.FaceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("FaceModel");
                });

            modelBuilder.Entity("ChamCong_BackEnd.Server.Models.Time", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeOnly?>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeOnly?>("LunchBreak")
                        .HasColumnType("time");

                    b.Property<TimeOnly?>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Time");
                });

            modelBuilder.Entity("ChamCong_BackEnd.Server.Models.Timekeeping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("TimeKeeping");
                });

            modelBuilder.Entity("ChamCong_BackEnd.Server.Models.Unknown", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CaptureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Unknown");
                });

            modelBuilder.Entity("ChamCong_BackEnd.Server.Models.FaceModel", b =>
                {
                    b.HasOne("ChamCong_BackEnd.Server.Models.Employee", null)
                        .WithMany("FaceModels")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("ChamCong_BackEnd.Server.Models.Timekeeping", b =>
                {
                    b.HasOne("ChamCong_BackEnd.Server.Models.Employee", null)
                        .WithMany("Timekeepings")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChamCong_BackEnd.Server.Models.Employee", b =>
                {
                    b.Navigation("FaceModels");

                    b.Navigation("Timekeepings");
                });
#pragma warning restore 612, 618
        }
    }
}
