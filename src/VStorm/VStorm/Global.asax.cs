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
}