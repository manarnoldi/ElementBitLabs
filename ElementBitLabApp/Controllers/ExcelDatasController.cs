using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ElementBitLabApp.Data;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using Microsoft.AspNetCore.Hosting;
using System.Security.Claims;
using ElementBitLabApp.ViewModels;

namespace ElementBitLabApp.Controllers
{
    public class ExcelDatasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _hostingEnvironment;
        List<ExcelData> excelDatas;
        public ExcelDatasController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        public ActionResult GetCustomers()
        {
            var list = _context.ExcelDatas.Select(c => c.CustomerName).Distinct().ToList();
            return Json(list);
        }

        public ActionResult GetProducts()
        {
            return Json(_context.ExcelDatas.Select(c => c.ProductName).Distinct());
        }

        public ActionResult GetExcelTitles()
        {
            return Json(_context.ExcelDatas.Select(c => c.ExcelTitle).Distinct());
        }

        // GET: ExcelDatas
        public IActionResult Index()
        {
            DowloadExcelSelectionViewModel model = new DowloadExcelSelectionViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateExcelDataToDatabase(IFormCollection FormData)
        {
            //var datatables = viewmodel.ExcelDatas.ToList();
            var dataTable = excelDatas;
            return RedirectToAction("Index");
        }

        public ActionResult UpdateExcelData(string excelName)
        {
            List<ExcelData> excelDatas = _context.ExcelDatas.Where(t => t.ExcelTitle == excelName)
                .OrderBy(p => p.Column).OrderBy(r => r.Row).ToList();            
            return Json(excelDatas);
        }

        public IActionResult DownLoadExcelData()
        {
            excelDatas = _context.ExcelDatas.ToList();
            ViewData["Customers"] = new SelectList(_context.ExcelDatas.Select(c => c.CustomerName).Distinct());
            ViewData["Products"] = new SelectList(_context.ExcelDatas.Select(c => c.ProductName).Distinct());
            ViewData["ExcelNames"] = new SelectList(_context.ExcelDatas.Select(c => c.ExcelTitle).Distinct());
            return View("Details");
        }

        [HttpPost]
        public async Task<IActionResult> DownLoadExcelData(DowloadExcelSelectionViewModel selectionData)
        {
            excelDatas = _context.ExcelDatas
                .Where(p => p.ExcelTitle == selectionData.ExcelName).ToList();

            string sWebRootFolder = _hostingEnvironment.WebRootPath;

            string sFileName = selectionData.ExcelName;
            string URL = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, sFileName);

            var memory = new MemoryStream();
            
            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                excelDatas = excelDatas.OrderBy(p => p.Column).OrderBy(p => p.Row).ToList();

                IWorkbook workbook;
                workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet("SheetName");
                IRow row = excelSheet.CreateRow(0);

                int maxRow = excelDatas.Max(p => p.Row);
                int maxCol = excelDatas.Max(p => p.Column);

                foreach (var item in excelDatas)
                {
                    if (item.Column == 0)
                    {
                        row = excelSheet.CreateRow(item.Row);
                        row.CreateCell(item.Column).SetCellValue(item.Value);
                    }
                    else
                    {
                        row.CreateCell(item.Column).SetCellValue(item.Value);
                    }
                }
                workbook.Write(fs);
            }
            using (var stream = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", sFileName);
        }

        [HttpPost]
        public ActionResult LoadUploadedData(IFormFile file)
        {
            if (file == null)
            {
                return View("Index");
            }
            string folderName = "ExcelUploads";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);
            string currentTimeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string[] currentName = file.FileName.Split(".");
            string fileName = currentName[currentName.Length - 2] + '_' + currentTimeStamp + '.' + currentName[currentName.Length - 1];
            StringBuilder sb = new StringBuilder();
            excelDatas = new List<ExcelData>();
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }
            if (file.Length > 0)
            {
                string sFileExtension = Path.GetExtension(fileName).ToLower();
                ISheet sheet;
                string fullPath = Path.Combine(newPath, fileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                    stream.Position = 0;
                    if (sFileExtension == ".xls")
                    {
                        HSSFWorkbook hssfwb = new HSSFWorkbook(stream);
                        sheet = hssfwb.GetSheetAt(0);
                    }
                    else
                    {
                        XSSFWorkbook hssfwb = new XSSFWorkbook(stream);
                        sheet = hssfwb.GetSheetAt(0);
                    }

                    IRow headerRow = sheet.GetRow(0);
                    int cellCount = headerRow.LastCellNum;

                    for (int i = sheet.FirstRowNum; i <= sheet.LastRowNum; i++)
                    {
                        IRow row = sheet.GetRow(i);
                        for (int j = row.FirstCellNum; j < cellCount; j++)
                        {
                            var exceldt = new ExcelData()
                            {
                                Row = i,
                                Column = j,
                                Value = GetCellValue(row.GetCell(j)),
                                ExcelTitle = fileName,
                                ProductName = "Product",
                                CustomerName = "Customer",
                                ApplicationUserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier),
                                ModifiedDate = DateTime.Now,
                                Edited = false,
                                ReadOnly = Convert.ToBoolean(sheet.GetRow(2).GetCell(j).ToString().ToLower())
                            };
                            excelDatas.Add(exceldt);
                            _context.Add(exceldt);
                        }
                    }
                    _context.SaveChanges();                    
                }
            }
            var vm = new DowloadExcelSelectionViewModel();
            vm.ExcelDatas = excelDatas.OrderBy(p => p.Row).ToList();
            
            return View("Index", vm);
        }

        // GET: ExcelDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var excelData = await _context.ExcelDatas
                .Include(e => e.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (excelData == null)
            {
                return NotFound();
            }

            return View(excelData);
        }

        // GET: ExcelDatas/Create
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: ExcelDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Row,Column,Value,ExcelTitle,ProductName,CustomerName,ApplicationUserId,ModifiedDate,Edited")] ExcelData excelData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(excelData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", excelData.ApplicationUserId);
            return View(excelData);
        }

        // GET: ExcelDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var excelData = await _context.ExcelDatas.FindAsync(id);
            if (excelData == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", excelData.ApplicationUserId);
            return View(excelData);
        }

        // POST: ExcelDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Row,Column,Value,ExcelTitle,ProductName,CustomerName,ApplicationUserId,ModifiedDate,Edited")] ExcelData excelData)
        {
            if (id != excelData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(excelData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExcelDataExists(excelData.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", excelData.ApplicationUserId);
            return View(excelData);
        }

        // GET: ExcelDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var excelData = await _context.ExcelDatas
                .Include(e => e.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (excelData == null)
            {
                return NotFound();
            }

            return View(excelData);
        }

        // POST: ExcelDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var excelData = await _context.ExcelDatas.FindAsync(id);
            _context.ExcelDatas.Remove(excelData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExcelDataExists(int id)
        {
            return _context.ExcelDatas.Any(e => e.Id == id);
        }

        private static string GetCellValue(ICell cell)
        {
            if (cell == null)
                return string.Empty;
            switch (cell.CellType)
            {
                case CellType.Blank:
                    return string.Empty;
                case CellType.Boolean:
                    return cell.BooleanCellValue.ToString();
                case CellType.Error:
                    return cell.ErrorCellValue.ToString();
                case CellType.Numeric:
                case CellType.Unknown:
                default:
                    return cell.ToString();//This is a trick to get the correct value of the cell. NumericCellValue will return a numeric value no matter the cell value is a date or a number
                case CellType.String:
                    return cell.StringCellValue;
                case CellType.Formula:
                    try
                    {
                        HSSFFormulaEvaluator e = new HSSFFormulaEvaluator(cell.Sheet.Workbook);
                        e.EvaluateInCell(cell);
                        return cell.ToString();
                    }
                    catch
                    {
                        return cell.NumericCellValue.ToString();
                    }
            }
        }
    }
}
