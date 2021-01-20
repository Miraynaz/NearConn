using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearConnWebUI.Identity
{
    public class SeedIdentity
    {
        public static async Task Seed(UserManager<ApplicationUser> userManager,RoleManager<IdentityRole> roleManager,IConfiguration configuration)
        {
            var username = configuration["Data:AdminUser:username"];
            var password = configuration["Data:AdminUser:password"];
            var email = configuration["Data:AdminUser:email"];
            var role = configuration["Data:AdminUser:role"];
            var user = await roleManager.CreateAsync(new IdentityRole(role));

        }
    }
}
