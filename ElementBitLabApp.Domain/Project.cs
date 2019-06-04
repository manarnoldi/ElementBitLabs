using System;
using System.Collections.Generic;
using System.Text;

namespace ElementBitLabApp.Domain
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNumber { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List<Building> Buildings { get; set; }
    }
}