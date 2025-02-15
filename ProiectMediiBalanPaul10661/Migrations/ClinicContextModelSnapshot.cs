﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectMediiBalanPaul10661.Data;

#nullable disable

namespace ProiectMediiBalanPaul10661.Migrations
{
    [DbContext(typeof(ClinicContext))]
    partial class ClinicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Prenume")
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
                        .HasColumnType("date");

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

                    b.Property<DateTime>("DataProgramare")
                        .HasColumnType("datetime2");

                    b.Property<string>("Doctor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctoriId")
                        .HasColumnType("int");

                    b.Property<string>("Pacient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PacientId")
                        .HasColumnType("int");

                    b.Property<string>("Serviciu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Specializare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctoriId");

                    b.ToTable("Servicii");
                });

            modelBuilder.Entity("ProiectMediiBalanPaul10661.Models.Programare", b =>
                {
                    b.HasOne("ProiectMediiBalanPaul10661.Models.Doctori", null)
                        .WithMany("Programari")
                        .HasForeignKey("DoctoriId");

                    b.HasOne("ProiectMediiBalanPaul10661.Models.Pacient", null)
                        .WithMany("Programari")
                        .HasForeignKey("PacientId");
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
