using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace VStorm.Models.UsersModel
{
    public class VStormDbInitializer : DropCreateDatabaseIfModelChanges<VStormEntities>
    {
        protected override void Seed(VStormEntities context)
        {
            try
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                userManager.UserValidator = new UserValidator<ApplicationUser>(userManager)
                {
                    AllowOnlyAlphanumericUserNames = false
                };
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

                if (!roleManager.RoleExists("Admin"))
                {
                    roleManager.Create(new IdentityRole("Admin"));
                }

                if (!roleManager.RoleExists("Member"))
                {
                    roleManager.Create(new IdentityRole("Member"));
                }

                var user = new ApplicationUser();
                //user.FirstName = "Admin";
                //user.LastName = "Marlabs";
                user.Email = "admin@itorres.com";
                user.UserName = "admin@itorres.com";

                var userResult = userManager.Create(user, "itorres");

                if (userResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user.Id, "Admin");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}