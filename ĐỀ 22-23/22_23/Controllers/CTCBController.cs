using _22_23.Data;
using _22_23.Models;
using Microsoft.AspNetCore.Mvc;

namespace _22_23.Controllers
{
    public class CTCBController : Controller
    {
        private readonly MVCDbContext _context;

        public CTCBController(MVCDbContext context)
        {
            _context = context;
        }

        private void loadTenHK()
        {
            ViewBag.listhanhkhach = _context.HanhKhach.ToList();

        }
        public IActionResult ThemHanhKhachChuyenBay(string macb)
        {
            var chuyenbay = _context.ChuyenBay.FirstOrDefault(c => c.MaCH == macb);
            ViewBag.ChuyenBay = chuyenbay;

            ViewBag.sochovip = _context.CT_CB.Where(ct => ct.MaCH == macb && ct.LoaiGhe == true).Count();

            ViewBag.sochothuong = _context.CT_CB.Where(ct => ct.MaCH == macb && ct.LoaiGhe == false).Count();
            
            loadTenHK();

            return View();
        }
        [HttpPost]
        public IActionResult ThemHanhKhachChuyenBay( string macb, string mahk, Boolean loaighe, string soghe )
        {
            _context.CT_CB.Add(new CT_CB()
            {
                MaCH = macb,
                MaHK = mahk,
                LoaiGhe = loaighe,
                SoGhe = soghe
            });
            _context.SaveChanges();
            return RedirectToAction("XemThongTinChuyenBay","ChuyenBay", new {macb = macb});
        }

        public IActionResult SuaHanhKhachChuyenBay(string macb, string mahk)
        {
            ViewBag.CT_CB = _context.CT_CB.FirstOrDefault(ct => ct.MaCH == macb && ct.MaHK == mahk);
            ViewBag.hanhkhach = _context.HanhKhach.FirstOrDefault(hk => hk.MaHK == mahk);
            return View();
        }
        [HttpPost]
        public IActionResult SuaHanhKhachChuyenBay(string macb, string mahk, Boolean loaighe, string soghe)
        {
            var ctcb = _context.CT_CB.FirstOrDefault(ct => ct.MaCH == macb && ct.MaHK == mahk);
            ctcb.LoaiGhe = loaighe;
            ctcb.SoGhe = soghe;
           
            _context.SaveChanges();
            return RedirectToAction("XemThongTinChuyenBay","ChuyenBay", new {macb = macb});
        }
        public IActionResult XoaHanhKhachChuyenBay(string macb, string mahk)
        {
            
            var ctcb = _context.CT_CB.FirstOrDefault(ct => ct.MaCH == macb && ct.MaHK == mahk);
            _context.CT_CB.Remove(ctcb);
            _context.SaveChanges();
            return RedirectToAction("XemThongTinChuyenBay", "ChuyenBay", new { macb = macb });
        }


    }
}
