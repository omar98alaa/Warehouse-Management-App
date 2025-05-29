using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_App.Entities
{
    class ItemUnit
    {
        //
        //  Properties
        //
        public string Name { get; set; }


        //
        //  Relations
        //
        public ICollection<Item> Items { get; set; }
    }
}
