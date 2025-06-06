﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Warehouse_Management_App.Entities;

#nullable disable

namespace Warehouse_Management_App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250602210123_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Warehouse_Management_App.Entities.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Mobile")
                        .IsUnique();

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Export", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ContactID")
                        .HasColumnType("int");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ContactID");

                    b.HasIndex("WarehouseID");

                    b.ToTable("Exports");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.ExportedProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ExportID")
                        .HasColumnType("int");

                    b.Property<int>("ProductCode")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProductCode");

                    b.HasIndex("ExportID", "ProductCode")
                        .IsUnique();

                    b.ToTable("ExportedProducts");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Import", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ContactID")
                        .HasColumnType("int");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ContactID");

                    b.HasIndex("WarehouseID");

                    b.ToTable("Imports");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.ImportedProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ImportID")
                        .HasColumnType("int");

                    b.Property<int>("ProductCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProductCode");

                    b.HasIndex("ImportID", "ProductCode", "ProductionDate")
                        .IsUnique();

                    b.ToTable("ImportedProducts");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Product", b =>
                {
                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<int>("ExpiryPeriod")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Code");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.ProductUnit", b =>
                {
                    b.Property<int>("ProductCode")
                        .HasColumnType("int");

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProductCode", "UnitName");

                    b.HasIndex("UnitName");

                    b.ToTable("ProductUnits");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Transfer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ContactID")
                        .HasColumnType("int");

                    b.Property<int>("DestinationWarehouseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SourceWarehouseID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ContactID");

                    b.HasIndex("DestinationWarehouseID");

                    b.HasIndex("SourceWarehouseID");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.TransferedProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ProductCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TransferID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProductCode");

                    b.HasIndex("TransferID", "ProductCode", "ProductionDate")
                        .IsUnique();

                    b.ToTable("TransferedProducts");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Unit", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Warehouse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.WarehouseProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProductCode");

                    b.HasIndex("WarehouseID", "ProductCode", "ProductionDate", "AddedDate")
                        .IsUnique();

                    b.ToTable("WarehouseProducts");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Export", b =>
                {
                    b.HasOne("Warehouse_Management_App.Entities.Contact", "Contact")
                        .WithMany("Exports")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse_Management_App.Entities.Warehouse", "Warehouse")
                        .WithMany("Exports")
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.ExportedProduct", b =>
                {
                    b.HasOne("Warehouse_Management_App.Entities.Export", "Export")
                        .WithMany("ExportedProducts")
                        .HasForeignKey("ExportID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse_Management_App.Entities.Product", "Product")
                        .WithMany("ExportedProduct")
                        .HasForeignKey("ProductCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Export");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Import", b =>
                {
                    b.HasOne("Warehouse_Management_App.Entities.Contact", "Contact")
                        .WithMany("Imports")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse_Management_App.Entities.Warehouse", "Warehouse")
                        .WithMany("Imports")
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.ImportedProduct", b =>
                {
                    b.HasOne("Warehouse_Management_App.Entities.Import", "Import")
                        .WithMany("ImportedProducts")
                        .HasForeignKey("ImportID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse_Management_App.Entities.Product", "Product")
                        .WithMany("ImportedProduct")
                        .HasForeignKey("ProductCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Import");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.ProductUnit", b =>
                {
                    b.HasOne("Warehouse_Management_App.Entities.Product", "Product")
                        .WithMany("ProductUnits")
                        .HasForeignKey("ProductCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse_Management_App.Entities.Unit", "Unit")
                        .WithMany("ProductUnits")
                        .HasForeignKey("UnitName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Transfer", b =>
                {
                    b.HasOne("Warehouse_Management_App.Entities.Contact", "Contact")
                        .WithMany("Transfers")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse_Management_App.Entities.Warehouse", "DestinationWarehouse")
                        .WithMany("InboundTransfers")
                        .HasForeignKey("DestinationWarehouseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Warehouse_Management_App.Entities.Warehouse", "SourceWarehouse")
                        .WithMany("OutboundTransfers")
                        .HasForeignKey("SourceWarehouseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("DestinationWarehouse");

                    b.Navigation("SourceWarehouse");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.TransferedProduct", b =>
                {
                    b.HasOne("Warehouse_Management_App.Entities.Product", "Product")
                        .WithMany("TransferedProduct")
                        .HasForeignKey("ProductCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse_Management_App.Entities.Transfer", "Transfer")
                        .WithMany("TransferedProducts")
                        .HasForeignKey("TransferID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Transfer");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.WarehouseProduct", b =>
                {
                    b.HasOne("Warehouse_Management_App.Entities.Product", "Product")
                        .WithMany("WarehouseProducts")
                        .HasForeignKey("ProductCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse_Management_App.Entities.Warehouse", "Warehouse")
                        .WithMany("WarehouseProducts")
                        .HasForeignKey("WarehouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Contact", b =>
                {
                    b.Navigation("Exports");

                    b.Navigation("Imports");

                    b.Navigation("Transfers");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Export", b =>
                {
                    b.Navigation("ExportedProducts");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Import", b =>
                {
                    b.Navigation("ImportedProducts");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Product", b =>
                {
                    b.Navigation("ExportedProduct");

                    b.Navigation("ImportedProduct");

                    b.Navigation("ProductUnits");

                    b.Navigation("TransferedProduct");

                    b.Navigation("WarehouseProducts");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Transfer", b =>
                {
                    b.Navigation("TransferedProducts");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Unit", b =>
                {
                    b.Navigation("ProductUnits");
                });

            modelBuilder.Entity("Warehouse_Management_App.Entities.Warehouse", b =>
                {
                    b.Navigation("Exports");

                    b.Navigation("Imports");

                    b.Navigation("InboundTransfers");

                    b.Navigation("OutboundTransfers");

                    b.Navigation("WarehouseProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
