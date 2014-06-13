using Microsoft.AspNet.Identity.EntityFramework;

namespace VStorm.Models
{
    public class VStormEntities : IdentityDbContext<ApplicationUser>
    {
        public VStormEntities()
            : base("VStormDBConnection")
        {
            
        }
    }
}