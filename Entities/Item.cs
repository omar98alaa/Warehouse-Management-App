using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_App.Entities
{
    class Item
    {
        //
        //  Properties
        //
        public int Code { get; set; }
        public string Name { get; set; }
        public int ExpiryPeriod { get; set; }


        //
        //  Relations
        //
        public ICollection<ItemUnit> ItemUnits { get; set; }
        public ICollection<WarehouseItem> WarehouseItems { get; set; }
        public ICollection<Import> Imports { get; set; }
        public ICollection<Export> Exports { get; set; }
        public ICollection<Transfer> Transfers { get; set; }
    }
}
