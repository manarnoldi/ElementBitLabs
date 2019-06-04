using System;
using System.Collections.Generic;
using System.Text;

namespace ElementBitLabApp.Domain
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public List<Project> Projects { get; set; }
    }
}
