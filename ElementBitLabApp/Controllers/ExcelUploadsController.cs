using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ElementBitLabApp.Data;
using ElementBitLabApp.Domain;
using System.Security.Claims;

namespace ElementBitLabApp.Controllers
{
    public class ExcelUploadsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExcelUploadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ExcelUploads
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ExcelUploads.Include(e => e.ApplicationUser).Include(e => e.Building).Include(e => e.Discipline);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> GetExcel()
        {
            var applicationDbContext = _context.ExcelUploads
                .Include(e => e.ApplicationUser)
                .Include(e => e.Building)
                .Include(e => e.Discipline);
            var returndata = await applicationDbContext.ToListAsync();
            return Json(returndata);
        }

        public async Task<IActionResult> GetDisciplines()
        {
            var returndata = await _context.Disciplines.ToListAsync();
            return Json(returndata);
        }

        public async Task<IActionResult> GetClients()
        {
            var returndata = await _context.Clients.ToListAsync();
            return Json(returndata);
        }

        public async Task<IActionResult> GetProjects(string clientName)
        {
            Client client = _context.Clients.Where(n => n.ClientName == clientName).FirstOrDefault();
            var returndata = await _context.Projects.Where(c => c.ClientId == client.Id).Select(c => new { c.Id, c.ProjectName, c.ProjectNumber }).ToListAsync();
            return Json(returndata);
        }

        public async Task<IActionResult> GetBuildings(string projectName)
        {
            Project project = _context.Projects.Where(p => p.ProjectName == projectName).FirstOrDefault();
            var returnData = await _context.Buildings.Where(b => b.ProjectId == project.Id).Select(c => new { c.Id, c.BuildingName, c.BuildingNumber }).ToListAsync();
            return Json(returnData);
        }



        [HttpPost]
        public async Task<IActionResult> PostExcelData([FromBody] ExcelUpload excelupload)
        {
            var excelNmArr = excelupload.ExcelName.Split('.');
            var excelNm = excelNmArr[0];
            var excelNmExt = excelNmArr[excelNmArr.Length - 1];
            excelupload.ExcelName = excelNm + DateTime.Now.ToString("yyyyMMddHHmmss") + '.' + excelNmExt;
            excelupload.ApplicationUserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            excelupload.CreatedDate = DateTime.Now;
            excelupload.Edited = false;
            excelupload.ModifiedDate = DateTime.Now;
            _context.ExcelUploads.Add(excelupload);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> PostExcelUpdatedData([FromBody] ExcelUpload excelupload)
        {
            ExcelUpload tableUploadExcel = _context.ExcelUploads.Find(excelupload.Id);
            tableUploadExcel.ApplicationUserId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            tableUploadExcel.Edited = true;
            tableUploadExcel.ModifiedDate = DateTime.Now;
            tableUploadExcel.ExcelData = excelupload.ExcelData;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteExcelData([FromBody] ExcelUpload excelupload)
        {
            ExcelUpload tableUploadExcel = _context.ExcelUploads.Find(excelupload.Id);
            _context.ExcelUploads.Remove(tableUploadExcel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        // GET: ExcelUploads/Details/5
        public async Task<IActionResult> Details()
        {
            return View();
        }

        public async Task<IActionResult> GetExcelDetails(string excelid)
        {
            ExcelUpload excelUpload = await _context.ExcelUploads.FindAsync(int.Parse(excelid));
            return Json(excelUpload);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
