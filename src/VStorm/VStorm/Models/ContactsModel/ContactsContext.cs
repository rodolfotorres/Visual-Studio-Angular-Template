using System.Data.Entity;

namespace VStorm.Models.ContactsModel
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