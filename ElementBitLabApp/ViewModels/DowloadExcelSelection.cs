using ElementBitLabApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElementBitLabApp.ViewModels
{
    public class DowloadExcelSelectionViewModel
    {
        public DowloadExcelSelectionViewModel()
        {
            ExcelDatas = new List<ExcelData>();
        }
        public string Customer { get; set; }
        public string Product { get; set; }
        public string ExcelName { get; set; }
        public List<ExcelData> ExcelDatas { get; set; }
    }
}
