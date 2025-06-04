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
    [PrimaryKey("ProductCode", "UnitName")]
    class ProductUnit
    {
        //
        //  Properties
        //
        [ForeignKey("Product")]
        public int ProductCode { get; set; }

        [ForeignKey("Unit")]
        public string UnitName { get; set; }


        //
        //  Relations
        //
        public virtual Product Product { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
