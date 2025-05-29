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
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemUnit> ItemUnits { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<WarehouseItem> WarehouseItems { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<Export> Exports { get; set; }
        public DbSet<Transfer> Transfers { get; set; }


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
    }
}
