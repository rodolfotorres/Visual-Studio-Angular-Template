using System.Data.Entity;

namespace VStorm.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext()
            : base("VStormDBConnection")
        {
            
        }
        public DbSet<ContactItem> Contacts { get; set; }

    }
}