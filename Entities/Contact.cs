using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_App.Entities
{
    public enum ContactType { 
        Client, 
        Supplier 
    }

    [Index("Email", IsUnique = true)]
    [Index("Mobile", IsUnique = true)]
    class Contact
    {
        //
        //  Properties
        //
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        [Length(9, 9)]
        public string? Telephone { get; set; }
        
        [Length(11, 11)]
        public string Mobile { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        
        public string? Website { get; set; }
        
        [Length(9, 9)]
        public string? Fax { get; set; }

        [EnumDataType(typeof(ContactType))]
        public ContactType Type { get; set; }


        //
        //  Relations
        //
        public virtual ICollection<Import> Imports { get; set; }
        public virtual ICollection<Export> Exports { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
    }
}
