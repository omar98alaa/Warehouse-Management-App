using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Warehouse_Management_App.Entities
{
    [Index("ExportID", "ProductCode", IsUnique = true)]
    class ExportedProduct
    {
        //
        //  Properties
        //
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("Product")]
        public int ProductCode { get; set; }

        [ForeignKey("Export")]
        public int ExportID { get; set; }


        //
        //  Relations
        //
        public virtual Product Product { get; set; }
        public virtual Export Export { get; set; }
    }
}
