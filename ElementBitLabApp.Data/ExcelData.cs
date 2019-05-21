using ElementBitLabApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElementBitLabApp.Data
{
   public class ExcelData
    {
        public int Id { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public string Value { get; set; }
        public string ExcelTitle { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Boolean Edited { get; set; }
        public Boolean ReadOnly { get; set; }
    }
}
