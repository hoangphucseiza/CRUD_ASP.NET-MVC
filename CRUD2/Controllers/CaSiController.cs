using CRUD2.Data;
using CRUD2.Models._21_22;
using Microsoft.AspNetCore.Mvc;

namespace CRUD2.Controllers
{
    public class CaSiController : Controller
    {
        private readonly MVCDemoDbContext _context;

        public CaSiController(MVCDemoDbContext mvcDemoDbContext)
        {
            this._context = mvcDemoDbContext;
        }
        public IActionResult LietKeCaSi(List<dynamic> lietkecasi)
        {
            if (lietkecasi == null)
            {
               return View();
            }else
            {
              return View(lietkecasi);
            }
        }

        [HttpGet]
        public IActionResult LietKeCaSi(DateTime ngay)
        {
           var lietkecasi =  _context.CaSi.Where(u => u.NamSinh == ngay).ToList();
 

            return View("LietKeCaSi",lietkecasi);
        }

       
    }
}
