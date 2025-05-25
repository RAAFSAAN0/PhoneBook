using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.DAL.EF.Tables
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Type { get; set; } // e.g. Personal, Work, Temporary

        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
