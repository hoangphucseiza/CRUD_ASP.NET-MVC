using _22_23.Data;
using _22_23.Models;
using Microsoft.AspNetCore.Mvc;

namespace _22_23.Controllers
{
    public class HanhKhachController : Controller
    {
        private readonly MVCDbContext _context;

        public HanhKhachController(MVCDbContext context)
        {
            _context = context;
        }

        public IActionResult ThemHanhKhach()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ThemHanhKhach(HanhKhach hk)
        {
            _context.HanhKhach.Add(hk);
            _context.SaveChanges();
            return RedirectToAction("ThemHanhKhach");
        }
    }
}
