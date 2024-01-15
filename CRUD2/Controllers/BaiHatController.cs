using CRUD2.Data;
using CRUD2.Models._21_22;
using Microsoft.AspNetCore.Mvc;

namespace CRUD2.Controllers
{
    public class BaiHatController : Controller
    {
        private readonly MVCDemoDbContext _context;

        public BaiHatController(MVCDemoDbContext mvcDemoDbContext)
        {
            this._context = mvcDemoDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ThemBaiHat()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> ThemBaiHat(BaiHat obj)
        {
         
            await _context.BaiHat.AddAsync(obj);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "BaiHat");
           
        }
    }
}
