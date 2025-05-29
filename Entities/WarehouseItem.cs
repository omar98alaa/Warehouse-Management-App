using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_App.Entities
{
    class WarehouseItem
    {
        //
        //  Properties
        //
        public int ID { get; set; }
        public DateTime ProductionDate { get; set; }
        public int Quantity { get; set; }


        //
        //  Relations
        //
        public Warehouse Warehouse { get; set; }
        public Item Item { get; set; }
    }
}
