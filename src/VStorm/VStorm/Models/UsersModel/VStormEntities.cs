using Microsoft.AspNet.Identity.EntityFramework;

namespace VStorm.Models.UsersModel
{
    public class VStormEntities : IdentityDbContext<ApplicationUser>
    {
        public VStormEntities()
            : base("VStormDBConnection")
        {
            
        }
    }
}