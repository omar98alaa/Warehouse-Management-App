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
    [Index("WarehouseID", "ProductCode", "ProductionDate", "AddedDate", IsUnique = true)]
    class WarehouseProduct
    {
        //
        //  Properties
        //
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public DateTime ProductionDate { get; set; }

        public int Quantity { get; set; }

        public DateTime AddedDate { get; set; }

        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }

        [ForeignKey("Product")]
        public int ProductCode { get; set; }


        //
        //  Relations
        //
        public virtual Warehouse Warehouse { get; set; }
        public virtual Product Product { get; set; }
    }
}
