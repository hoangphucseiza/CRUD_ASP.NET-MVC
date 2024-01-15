using _22_23.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _22_23.Controllers
{
    public class ChuyenBayController : Controller
    {
        private readonly MVCDbContext _context;

        public ChuyenBayController(MVCDbContext context)
        {
            _context = context;
        }
        public IActionResult LietKe()
        {
            return View();
        }

        public IActionResult XemThongTinChuyenBay(string macb)
        {
            var chuyenbay = _context.ChuyenBay.FirstOrDefault(c => c.MaCH == macb);

            ViewBag.ChuyenBay = chuyenbay;

            ViewBag.sochovip = _context.CT_CB.Where(ct => ct.MaCH == macb && ct.LoaiGhe == true).Count();

            ViewBag.sochothuong = _context.CT_CB.Where(ct => ct.MaCH == macb && ct.LoaiGhe == false).Count();

            ViewBag.dslietke = from ct in _context.CT_CB
                join hk in _context.HanhKhach on ct.MaHK equals hk.MaHK
                where ct.MaCH == macb
                select new {
                    MaHK = hk.MaHK,
                    HoTen = hk.HoTen,
                    DienThoai = hk.DienThoai,
                    SoGhe = ct.SoGhe,
                    LoaiGhe = ct.LoaiGhe
                };

          
            return View();
        }


    }
}
