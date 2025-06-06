﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_App.Entities
{
    [Index("Name", IsUnique = true)]
    class Warehouse
    {
        //
        //  Properties
        //
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }
        
        public string Manager { get; set; }
        
        public string Street { get; set; }

        public string City { get; set; }

        //
        //  Relations
        //
        public virtual ICollection<WarehouseProduct> WarehouseProducts { get; set; }
        public virtual ICollection<Import> Imports { get; set; }
        public virtual ICollection<Export> Exports { get; set; }
        public virtual ICollection<Transfer> OutboundTransfers { get; set; }
        public virtual ICollection<Transfer> InboundTransfers { get; set; }
    }
}
