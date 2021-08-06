﻿// <auto-generated />
using System;
using HealthApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthApi.Data.Migrataions
{
    [DbContext(typeof(HealthContext))]
    [Migration("20200208132650_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthApi.Models.Ailment", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("PatientId");

                    b.ToTable("Ailments");
                });

            modelBuilder.Entity("HealthApi.Models.Medication", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Doses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("PatientId");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("HealthApi.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HealthApi.Models.Ailment", b =>
                {
                    b.HasOne("HealthApi.Models.Patient", null)
                        .WithMany("Ailments")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("HealthApi.Models.Medication", b =>
                {
                    b.HasOne("HealthApi.Models.Patient", null)
                        .WithMany("Medications")
                        .HasForeignKey("PatientId");
                });
#pragma warning restore 612, 618
        }
    }
}