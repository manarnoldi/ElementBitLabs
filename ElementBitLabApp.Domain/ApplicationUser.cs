using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElementBitLabApp.Domain
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}
