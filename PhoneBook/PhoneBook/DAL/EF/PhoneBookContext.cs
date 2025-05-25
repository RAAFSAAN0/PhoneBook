using PhoneBook.DAL.EF.Tables;
using System.Data.Entity;

namespace PhoneBook.DAL.EF
{
    public class PhonebookContext : DbContext // ✅ Inherit from DbContext
    {
        public PhonebookContext() : base("PhonebookDb") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
    }
}
