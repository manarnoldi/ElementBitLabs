using ElementBitLabApp.Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElementBitLabApp.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
                          UserManager<ApplicationUser> userManager,
                          RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "User";
            string desc2 = "This is the users role";

            string password = "Admin@123";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("icesalt4@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "icesalt4@gmail.com",
                    Email = "icesalt4@gmail.com",
                    FirstName = "Ice",
                    LastName = "Salt",
                    PhoneNumber = "+99887747746",
                    Description = "Test Description for icesalt",
                    Company = "Element Bit Lab",
                    Country = "Kenya",
                    Address = "Dubai UAE"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("manarnoldi@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "manarnoldi@gmail.com",
                    Email = "manarnoldi@gmail.com",
                    FirstName = "Arnold",
                    LastName = "Mwadwaa",
                    PhoneNumber = "+254724924465",
                    Description = "Test Description for icesalt",
                    Company = "Element Bit Lab",
                    Country = "UAE",
                    Address = "Dubai UAE"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId2 = user.Id;
            }

        }
    }
}
