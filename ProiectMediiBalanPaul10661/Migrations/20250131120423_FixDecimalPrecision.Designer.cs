﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectMediiBalanPaul10661.Data;

#nullable disable

namespace ProiectMediiBalanPaul10661.Migrations
{
    [DbContext(typeof(ClinicContext))]
    [Migration("20250131120423_FixDecimalPrecision")]
    partial class FixDecimalPrecision
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProiectMediiBalanPaul10661.Models.Doctori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specializare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctori");
                });

            modelBuilder.Entity("ProiectMediiBalanPaul10661.Models.Pacient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataNasterii")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pacienti");
                });

            modelBuilder.Entity("ProiectMediiBalanPaul10661.Models.Programare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctoriId")
                        .HasColumnType("int");

                    b.Property<int>("PacientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctoriId");

                    b.HasIndex("PacientId");

                    b.ToTable("Programari");
                });

            modelBuilder.Entity("ProiectMediiBalanPaul10661.Models.Servicii", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DoctoriId")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DoctoriId");

                    b.ToTable("Servicii");
                });

            modelBuilder.Entity("ProiectMediiBalanPaul10661.Models.Programare", b =>
                {
                    b.HasOne("ProiectMediiBalanPaul10661.Models.Doctori", "Doctori")
                        .WithMany("Programari")
                        .HasForeignKey("DoctoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectMediiBalanPaul10661.Models.Pacient", "Pacient")
                        .WithMany("Programari")
                        .HasForeignKey("PacientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctori");

                    b.Navigation("Pacient");
                });

            modelBuilder.Entity("ProiectMediiBalanPaul10661.Models.Servicii", b =>
                {
                    b.HasOne("ProiectMediiBalanPaul10661.Models.Doctori", null)
                        .WithMany("Servicii")
                        .HasForeignKey("DoctoriId");
                });

            modelBuilder.Entity("ProiectMediiBalanPaul10661.Models.Doctori", b =>
                {
                    b.Navigation("Programari");

                    b.Navigation("Servicii");
                });

            modelBuilder.Entity("ProiectMediiBalanPaul10661.Models.Pacient", b =>
                {
                    b.Navigation("Programari");
                });
#pragma warning restore 612, 618
        }
    }
}
