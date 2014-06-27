using System.Collections.Generic;
using System.Data.Entity;

namespace VStorm.Models.ContactsModel
{
    public class ContactsDatabaseInitializer : DropCreateDatabaseAlways<ContactsContext>
    {
        protected override void Seed(ContactsContext context)
        {
            SeedDatabase(context);
        }

        private void SeedDatabase(ContactsContext context)
        {
            var contacts = new List<ContactItem>()
            {
                new ContactItem()
                {
                    Description = "Github",
                    Value = "https://github.com/rodolfotorres"
                },
                new ContactItem()
                {
                    Description = "Linkedin",
                    Value = "https://www.linkedin.com/pub/rodolfo-torres/4/616/a89"
                },
            };

            contacts.ForEach(c=> context.Contacts.Add(c));

            context.SaveChanges();
        }
    }
}