using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_App.Entities
{
    class Warehouse
    {
        //
        //  Properties
        //
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        //
        //  Relations
        //
        public ICollection<WarehouseItem> warehouseItems { get; set; }
        public ICollection<Import> Imports { get; set; }
        public ICollection<Export> Exports { get; set; }
        public ICollection<Transfer> Transfers{ get; set; }
    }
}
