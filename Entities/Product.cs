using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_App.Entities
{
    [Index("Name", IsUnique = true)]
    class Product
    {
        //
        //  Properties
        //
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }
        
        public string Name { get; set; }
        
        public int ExpiryPeriod { get; set; }

        //
        //  Relations
        //
        public virtual ICollection<ProductUnit> ProductUnits { get; set; }
        public virtual ICollection<WarehouseProduct> WarehouseProducts { get; set; }
        public virtual ICollection<ImportedProduct> ImportedProduct { get; set; }
        public virtual ICollection<ExportedProduct> ExportedProduct { get; set; }
        public virtual ICollection<TransferedProduct> TransferedProduct { get; set; }
    }
}
