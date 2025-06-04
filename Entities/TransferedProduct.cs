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
    [Index("TransferID", "ProductCode", "ProductionDate", IsUnique = true)]
    class TransferedProduct
    {
        //
        //  Properties
        //
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public DateTime ProductionDate { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("Transfer")]
        public int TransferID { get; set; }

        [ForeignKey("Product")]
        public int ProductCode { get; set; }


        //
        //  Relations
        //
        public virtual Product Product { get; set; }
        public virtual Transfer Transfer{ get; set; }
    }
}
