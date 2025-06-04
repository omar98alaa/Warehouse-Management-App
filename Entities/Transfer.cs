using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_App.Entities
{
    class Transfer
    {
        //
        //  Properties
        //
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public DateTime IssueDate { get; set; }

        [ForeignKey("SourceWarehouse")]
        public int SourceWarehouseID { get; set; }

        [ForeignKey("DestinationWarehouse")]
        public int DestinationWarehouseID { get; set; }

        [ForeignKey("Contact")]
        public int ContactID { get; set; }

        //
        //  Relations
        //
        public virtual Warehouse SourceWarehouse { get; set; }
        public virtual Warehouse DestinationWarehouse { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual ICollection<TransferedProduct> TransferedProducts { get; set; }
    }
}
