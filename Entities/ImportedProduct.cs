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
    [Index("ImportID", "ProductCode", "ProductionDate", IsUnique = true)]
    class ImportedProduct
    {
        //
        //  Properties
        //
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public DateTime ProductionDate { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("Import")]
        public int ImportID { get; set; }

        [ForeignKey("Product")]
        public int ProductCode { get; set; }


        //
        //  Relations
        //
        public virtual Product Product { get; set; }
        public virtual Import Import { get; set; }
    }
}
