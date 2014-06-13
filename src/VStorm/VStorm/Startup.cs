using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(VStorm.API.Startup))]
namespace VStorm.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}