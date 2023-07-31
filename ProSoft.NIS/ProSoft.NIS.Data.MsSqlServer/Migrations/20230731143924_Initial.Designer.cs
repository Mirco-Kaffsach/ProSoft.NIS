﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProSoft.NIS.Data.MsSqlServer;

#nullable disable

namespace ProSoft.NIS.Data.MsSqlServer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230731143924_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.6.23329.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CampusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CampusId");

                    b.ToTable("Buildings", "data");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Cable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PortAId")
                        .HasColumnType("int");

                    b.Property<int>("PortBId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PortAId")
                        .IsUnique();

                    b.HasIndex("PortBId")
                        .IsUnique();

                    b.ToTable("Cables", "data");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Cage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Cages", "data");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Campus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Campuses", "data");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Floor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Floors", "data");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Hallway", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FloorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FloorId");

                    b.ToTable("Hallways", "data");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Port", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CableAId")
                        .HasColumnType("int");

                    b.Property<int?>("CableBId")
                        .HasColumnType("int");

                    b.Property<int>("RackItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RackItemId");

                    b.ToTable("Ports", "data");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Rack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CageId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CageId");

                    b.HasIndex("RoomId");

                    b.ToTable("Racks", "data");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.RackItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RackId");

                    b.ToTable("RackItems", "data");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HallwayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HallwayId");

                    b.ToTable("Rooms", "data");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Switch", b =>
                {
                    b.HasBaseType("ProSoft.NIS.Contracts.DataModels.RackItem");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Switches", "data");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Building", b =>
                {
                    b.HasOne("ProSoft.NIS.Contracts.DataModels.Campus", "Campus")
                        .WithMany("Buildings")
                        .HasForeignKey("CampusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campus");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Cable", b =>
                {
                    b.HasOne("ProSoft.NIS.Contracts.DataModels.Port", "PortA")
                        .WithOne("CableA")
                        .HasForeignKey("ProSoft.NIS.Contracts.DataModels.Cable", "PortAId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ProSoft.NIS.Contracts.DataModels.Port", "PortB")
                        .WithOne("CableB")
                        .HasForeignKey("ProSoft.NIS.Contracts.DataModels.Cable", "PortBId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("PortA");

                    b.Navigation("PortB");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Cage", b =>
                {
                    b.HasOne("ProSoft.NIS.Contracts.DataModels.Room", "Room")
                        .WithMany("Cages")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Floor", b =>
                {
                    b.HasOne("ProSoft.NIS.Contracts.DataModels.Building", "Building")
                        .WithMany("Floors")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Hallway", b =>
                {
                    b.HasOne("ProSoft.NIS.Contracts.DataModels.Floor", "Floor")
                        .WithMany("Hallways")
                        .HasForeignKey("FloorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Floor");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Port", b =>
                {
                    b.HasOne("ProSoft.NIS.Contracts.DataModels.RackItem", "RackItem")
                        .WithMany("Ports")
                        .HasForeignKey("RackItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RackItem");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Rack", b =>
                {
                    b.HasOne("ProSoft.NIS.Contracts.DataModels.Cage", "Cage")
                        .WithMany("Racks")
                        .HasForeignKey("CageId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ProSoft.NIS.Contracts.DataModels.Room", "Room")
                        .WithMany("Racks")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cage");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.RackItem", b =>
                {
                    b.HasOne("ProSoft.NIS.Contracts.DataModels.Rack", "Rack")
                        .WithMany("RackItems")
                        .HasForeignKey("RackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rack");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Room", b =>
                {
                    b.HasOne("ProSoft.NIS.Contracts.DataModels.Hallway", "Hallway")
                        .WithMany("Rooms")
                        .HasForeignKey("HallwayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hallway");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Switch", b =>
                {
                    b.HasOne("ProSoft.NIS.Contracts.DataModels.RackItem", null)
                        .WithOne()
                        .HasForeignKey("ProSoft.NIS.Contracts.DataModels.Switch", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Building", b =>
                {
                    b.Navigation("Floors");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Cage", b =>
                {
                    b.Navigation("Racks");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Campus", b =>
                {
                    b.Navigation("Buildings");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Floor", b =>
                {
                    b.Navigation("Hallways");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Hallway", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Port", b =>
                {
                    b.Navigation("CableA")
                        .IsRequired();

                    b.Navigation("CableB")
                        .IsRequired();
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Rack", b =>
                {
                    b.Navigation("RackItems");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.RackItem", b =>
                {
                    b.Navigation("Ports");
                });

            modelBuilder.Entity("ProSoft.NIS.Contracts.DataModels.Room", b =>
                {
                    b.Navigation("Cages");

                    b.Navigation("Racks");
                });
#pragma warning restore 612, 618
        }
    }
}
