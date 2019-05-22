using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElementBitLabApp.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ElementBitLabApp.Areas.Identity.Pages.Account
{
    public class IndexModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public IndexModel(UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public List<ApplicationUser> Users { get; set; }
        public List<IdentityUserRole<string>> UserRoles { get; set; }
        public List<ApplicationRole> Roles { get; set; }
        public void OnGet()
        {
            Users = _userManager.Users.ToList();
            
            Roles = _roleManager.Roles.ToList();

            //Roles.
        }
    }
}