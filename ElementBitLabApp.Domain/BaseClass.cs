using System;
using System.Collections.Generic;
using System.Text;

namespace ElementBitLabApp.Domain
{
    public class BaseClass
    {
        public DateTime DateRegistered { get; set; }
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
