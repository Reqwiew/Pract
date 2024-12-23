﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pract;

#nullable disable

namespace pract.Migrations
{
    [DbContext(typeof(PractDbContext))]
    [Migration("20241223093634_migrate2")]
    partial class migrate2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("pract.Models.Client", b =>
                {
                    b.Property<long>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ClientID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientID");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("pract.Models.Equipment", b =>
                {
                    b.Property<long>("EquipmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EquipmentID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ClientID")
                        .HasColumnType("bigint");

                    b.Property<string>("EquipmentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentID");

                    b.HasIndex("ClientID");

                    b.ToTable("equipment");
                });

            modelBuilder.Entity("pract.Models.Master", b =>
                {
                    b.Property<long>("MasterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MasterID"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MasterID");

                    b.ToTable("masters");
                });

            modelBuilder.Entity("pract.Models.Part", b =>
                {
                    b.Property<long>("PartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PartID"));

                    b.Property<string>("PartName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PartID");

                    b.ToTable("parts");
                });

            modelBuilder.Entity("pract.Models.Receptionist", b =>
                {
                    b.Property<long>("ReceptionistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ReceptionistID"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReceptionistID");

                    b.ToTable("receptionits");
                });

            modelBuilder.Entity("pract.Models.Repair", b =>
                {
                    b.Property<long>("RepairID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RepairID"));

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("EquipmentID")
                        .HasColumnType("bigint");

                    b.Property<long>("MasterID")
                        .HasColumnType("bigint");

                    b.Property<long>("ReceptionistID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RepairID");

                    b.HasIndex("EquipmentID");

                    b.HasIndex("MasterID");

                    b.HasIndex("ReceptionistID");

                    b.ToTable("repairs");
                });

            modelBuilder.Entity("pract.Models.RepairService", b =>
                {
                    b.Property<long>("RepairServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RepairServiceID"));

                    b.Property<long>("RepairID")
                        .HasColumnType("bigint");

                    b.Property<long>("ServiceID")
                        .HasColumnType("bigint");

                    b.HasKey("RepairServiceID");

                    b.HasIndex("RepairID");

                    b.HasIndex("ServiceID");

                    b.ToTable("repairServices");
                });

            modelBuilder.Entity("pract.Models.Service", b =>
                {
                    b.Property<long>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ServiceID"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceID");

                    b.ToTable("services");
                });

            modelBuilder.Entity("pract.Models.UsedPart", b =>
                {
                    b.Property<long>("UsedPartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UsedPartID"));

                    b.Property<long>("PartID")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<long>("RepairID")
                        .HasColumnType("bigint");

                    b.HasKey("UsedPartID");

                    b.HasIndex("PartID");

                    b.HasIndex("RepairID");

                    b.ToTable("usedParts");
                });

            modelBuilder.Entity("pract.Models.Equipment", b =>
                {
                    b.HasOne("pract.Models.Client", "Client")
                        .WithMany("Equipments")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("pract.Models.Repair", b =>
                {
                    b.HasOne("pract.Models.Equipment", "Equipment")
                        .WithMany("Repairs")
                        .HasForeignKey("EquipmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pract.Models.Master", "Master")
                        .WithMany("Repairs")
                        .HasForeignKey("MasterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pract.Models.Receptionist", "Receptionist")
                        .WithMany("Repairs")
                        .HasForeignKey("ReceptionistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("Master");

                    b.Navigation("Receptionist");
                });

            modelBuilder.Entity("pract.Models.RepairService", b =>
                {
                    b.HasOne("pract.Models.Repair", "Repair")
                        .WithMany("RepairServices")
                        .HasForeignKey("RepairID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pract.Models.Service", "Service")
                        .WithMany("RepairServices")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Repair");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("pract.Models.UsedPart", b =>
                {
                    b.HasOne("pract.Models.Part", "Part")
                        .WithMany("UsedParts")
                        .HasForeignKey("PartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pract.Models.Repair", "Repair")
                        .WithMany("UsedParts")
                        .HasForeignKey("RepairID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Part");

                    b.Navigation("Repair");
                });

            modelBuilder.Entity("pract.Models.Client", b =>
                {
                    b.Navigation("Equipments");
                });

            modelBuilder.Entity("pract.Models.Equipment", b =>
                {
                    b.Navigation("Repairs");
                });

            modelBuilder.Entity("pract.Models.Master", b =>
                {
                    b.Navigation("Repairs");
                });

            modelBuilder.Entity("pract.Models.Part", b =>
                {
                    b.Navigation("UsedParts");
                });

            modelBuilder.Entity("pract.Models.Receptionist", b =>
                {
                    b.Navigation("Repairs");
                });

            modelBuilder.Entity("pract.Models.Repair", b =>
                {
                    b.Navigation("RepairServices");

                    b.Navigation("UsedParts");
                });

            modelBuilder.Entity("pract.Models.Service", b =>
                {
                    b.Navigation("RepairServices");
                });
#pragma warning restore 612, 618
        }
    }
}