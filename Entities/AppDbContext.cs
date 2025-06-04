using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_App.Entities
{
    class AppDbContext : DbContext
    {
        //
        //  Properties
        //
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<ProductUnit> ProductUnits { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<WarehouseProduct> WarehouseProducts { get; set; }
        public virtual DbSet<Import> Imports { get; set; }
        public virtual DbSet<Export> Exports { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<ImportedProduct> ImportedProducts { get; set; }
        public virtual DbSet<ExportedProduct> ExportedProducts { get; set; }
        public virtual DbSet<TransferedProduct> TransferedProducts { get; set; }


        //
        //  Methods
        //
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = ".\\SqlExpress";
            connectionStringBuilder.InitialCatalog = "Warehouse_Management_DB";
            connectionStringBuilder.TrustServerCertificate = true;
            connectionStringBuilder.IntegratedSecurity = true;

            optionsBuilder.UseSqlServer(connectionStringBuilder.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Transfer>()
                .HasOne(x => x.SourceWarehouse)
                .WithMany(x => x.OutboundTransfers)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Transfer>()
                .HasOne(x => x.DestinationWarehouse)
                .WithMany(x => x.InboundTransfers)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
