using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using VStorm.Models;
using VStorm.Models.ContactsModel;
using VStorm.Models.UsersModel;

namespace VStorm
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            

            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Database.SetInitializer(new VStormDbInitializer());
            Database.SetInitializer(new ContactsDatabaseInitializer());
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }

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
                    Description = "Contact1",
                    Value = "Value1"
                },
                new ContactItem()
                {
                    Description = "Contact2",
                    Value = "Value2"
                },
            };

            contacts.ForEach(c=> context.Contacts.Add(c));

            context.SaveChanges();
        }
    }
}