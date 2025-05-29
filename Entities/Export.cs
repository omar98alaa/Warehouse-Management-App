using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_App.Entities
{
    class Export
    {
        //
        //  Properties
        //
        public int ID { get; set; }
        public int Quantity { get; set; }
        public DateTime IssueDate { get; set; }


        //
        //  Relations
        //
        public Warehouse Warehouse { get; set; }
        public Item Item { get; set; }
        public User User { get; set; }
    }
}
