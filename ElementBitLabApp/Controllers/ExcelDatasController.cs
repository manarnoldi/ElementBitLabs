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

        // GET: ExcelDatas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ExcelDatas.Include(e => e.ApplicationUser);
            return View(await applicationDbContext.ToListAsync());
        }

        [HttpPost]
        public IActionResult UpdateExcelDataToDatabase(DowloadExcelSelectionViewModel exceldatas)
        {
            //var datatables = viewmodel.ExcelDatas.ToList();
            var dataTable = excelDatas;
            return RedirectToAction("Index");
        }

        public IActionResult UpdateExcelData()
        {           
            ViewData["Customers"] = new SelectList(_context.ExcelDatas.Select(c => c.CustomerName).Distinct());
            ViewData["Products"] = new SelectList(_context.ExcelDatas.Select(c => c.ProductName).Distinct());
            ViewData["ExcelNames"] = new SelectList(_context.ExcelDatas.Select(c => c.ExcelTitle).Distinct());
            DowloadExcelSelectionViewModel model = new DowloadExcelSelectionViewModel();
            return View("Create", model);
        }

        [HttpPost]
        public IActionResult UpdateExcelData(DowloadExcelSelectionViewModel exceldatas)
        {
            List<ExcelData> excelDatas = _context.ExcelDatas.Where(t => t.ExcelTitle == exceldatas.ExcelName)
                .OrderBy(p => p.Column).OrderBy(r => r.Row).ToList();

            ViewData["Customers"] = new SelectList(_context.ExcelDatas.Select(c => c.CustomerName).Distinct());
            ViewData["Products"] = new SelectList(_context.ExcelDatas.Select(c => c.ProductName).Distinct());
            ViewData["ExcelNames"] = new SelectList(_context.ExcelDatas.Select(c => c.ExcelTitle).Distinct());
            DowloadExcelSelectionViewModel model = new DowloadExcelSelectionViewModel();
            model.Product = exceldatas.Product;
            model.Customer = exceldatas.Customer;
            model.ExcelName = exceldatas.ExcelName;
            model.ExcelDatas = excelDatas;
            //ViewBag.HtmlStr = sb.ToString();
            return View("Create", model);
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
                    excelDatas = new List<ExcelData>();

                    for (int i = sheet.FirstRowNum; i <= sheet.LastRowNum; i++)
                    {

                        IRow row = sheet.GetRow(i);
                        for (int j = row.FirstCellNum; j < cellCount; j++)
                        {
                            ExcelData excelData = new ExcelData();
                            excelData.Row = i;
                            excelData.Column = j;
                            excelData.Value = GetCellValue(row.GetCell(j));
                            excelData.ExcelTitle = fileName;
                            excelData.ProductName = "Product";
                            excelData.CustomerName = "Customer";
                            excelData.ApplicationUserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                            excelData.ModifiedDate = DateTime.Now;
                            excelData.Edited = false;
                            string readonly1 = sheet.GetRow(2).GetCell(j).ToString().ToLower();
                            excelData.ReadOnly = Convert.ToBoolean(readonly1);
                            excelDatas.Add(excelData);
                        }
                    }
                }
            }
            sb.Append("<table class=\"table display nowrap table-striped table-bordered scroll-horizontal\">");
            excelDatas = excelDatas.OrderBy(p => p.Column).OrderBy(r => r.Row).ToList();
            int maxRow = excelDatas.Max(p => p.Row);
            int maxCol = excelDatas.Max(p => p.Column);

            foreach (var item in excelDatas)
            {
                if (item.Row == 0 || item.Row == 2) continue;
                if (item.Row == 1)
                {
                    if (item.Column == 0)
                    {
                        sb.Append("<thead><tr><th>" + item.Value + "</th>");
                    }
                    else if (item.Column == maxCol)
                    {
                        sb.Append("<th>" + item.Value + "</th></tr></thead><tbody><tr>");
                    }
                    else
                    {
                        sb.Append("<th>" + item.Value + "</th>");
                    }
                }
                else
                {
                    if (item.Column == maxCol)
                    {
                        sb.Append("<td>" + item.Value + "</td></tr><tr>");
                    }
                    else
                    {
                        sb.Append("<td>" + item.Value + "</td>");
                    }
                    //if (item.Column == maxCol)
                    //{
                    //    if (!item.ReadOnly)
                    //    {
                    //        sb.Append("<td>" + item.Value + "</td></tr><tr>");
                    //    } else
                    //    {
                    //        sb.Append("<td><input type='text' name='" + item.Row + item.Column + "' value='" + item.Value + "'></td></tr><tr>");
                    //    }                        
                    //}
                    //else
                    //{
                    //    if(!item.ReadOnly)
                    //    {
                    //        sb.Append("<td>" + item.Value + "</td>");
                    //    } else
                    //    {
                    //        sb.Append("<td><input type='text' name='" + item.Row + item.Column + "' value='" + item.Value + "'></td>");
                    //    }                        
                    //}
                }
            }
            sb.Remove(sb.ToString().Length - 4, 4);
            sb.Append("</tbody></table>");

            foreach (var item in excelDatas)
            {
                _context.Add(item);
            }
            _context.SaveChangesAsync();
            ViewBag.HtmlStr = sb.ToString();
            return View("Index", excelDatas);
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
