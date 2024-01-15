using CRUD2.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUD2.Controllers
{
    public class CongNhanController : Controller
    {
        private readonly MVCDemoDbContext _context;

        public CongNhanController(MVCDemoDbContext mvcDemoDbContext)
        {
            this._context = mvcDemoDbContext;
        }
        public IActionResult LietKeCongNhan(List<dynamic> list)
        {
            if(list == null)
            {
                return View();
            }
            return View(list);
        }

        [HttpGet]
        public IActionResult LietKeCongNhan(int lietke)
        {
            var query = from cn in _context.CongNhan
                        join cntc in _context.CN_TC on cn.MaCongNhan equals cntc.MaCongNhan
                        group new { cn, cntc } by new { cn.TenCongNhan, cn.NuocVe, cn.GioiTinh } into g
                        where g.Count() >= lietke
                        select new
                        {
                            TenCongNhan = g.Key.TenCongNhan,
                            NuocVe = g.Key.NuocVe,
                            GioiTinh = g.Key.GioiTinh,
                            SoTrieuChung = g.Count()
                        };

            var result = query.ToList();
            return View(result);
        }
    }
}
