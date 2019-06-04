using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ElementBitLabApp.Domain
{
    public class ExcelUpload
    {
        public int Id { get; set; }
        public string ExcelName { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
        public int DisciplineId { get; set; }
        public Discipline Discipline { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Boolean Edited { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string ExcelData { get; set; }
    }
}
