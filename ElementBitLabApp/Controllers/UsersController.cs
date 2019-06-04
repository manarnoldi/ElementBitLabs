using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElementBitLabApp.Data;
using ElementBitLabApp.Domain;
using ElementBitLabApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ElementBitLabApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UsersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllUsers()
        {
            List<UserRolesViewModel> uservms = new List<UserRolesViewModel>();
            var users = _userManager.Users;
            foreach (ApplicationUser user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var role = roles.FirstOrDefault();
                UserRolesViewModel uservw = new UserRolesViewModel() {
                    
                UserName = user.UserName,
                    Email = user.Email,
                    Address = user.Address,
                    Company = user.Company,
                    Country = user.Country,
                    PhoneNumber = user.PhoneNumber,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    RoleName = role,
                    Description = user.Description
                };
                uservms.Add(uservw);
            }            
            return Json(uservms.ToList());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = _roleManager.Roles;
            return Json(roles.ToList());
        }        
    }
}