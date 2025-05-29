using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_App.Entities
{
    public enum UserType { 
        Client, 
        Supplier 
    }

    class User
    {
        //
        //  Properties
        //
        public int ID { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Fax { get; set; }
        public UserType Type { get; set; }


        //
        //  Relations
        //
        public ICollection<Import> Imports { get; set; }
        public ICollection<Export> Exports { get; set; }
        public ICollection<Transfer> Transfers { get; set; }
    }
}
