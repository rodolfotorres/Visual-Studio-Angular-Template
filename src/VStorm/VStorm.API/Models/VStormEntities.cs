using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace VStorm.API.Models
{
    public class VStormEntities : IdentityDbContext<ApplicationUser>
    {
        public VStormEntities()
            : base("VStormDBConnection")
        {
            
        }
    }
}