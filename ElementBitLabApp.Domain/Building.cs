using System;
using System.Collections.Generic;
using System.Text;

namespace ElementBitLabApp.Domain
{
   public class Building
    {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public string BuildingNumber { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
