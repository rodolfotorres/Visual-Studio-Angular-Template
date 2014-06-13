using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(VStorm.Startup))]
namespace VStorm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}