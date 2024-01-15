using CRUD2.Data;
using CRUD2.Models;
using CRUD2.Models._21_22;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUD2.Controllers
{
    public class PlayListController : Controller
    {
        private readonly MVCDemoDbContext _context;

        public PlayListController(MVCDemoDbContext mvcDemoDbContext)
        {
            this._context = mvcDemoDbContext;
        }

        public IActionResult LietKePlayList(List<PlayList> lietkeplayList)
        {
           
            if (lietkeplayList == null)
            {
                loadNN();
                return View();
            } else
            {
                loadNN();
                return View(lietkeplayList);
            }    
        }

        [HttpGet]
        public IActionResult LietKePlayList(String mann)
        {
            var lietkeplayList = _context.PlayList.Where(u => u.MaNN == mann).ToList();
            return View("LietKePlayList", lietkeplayList);
        }

        public IActionResult Delete(string maplaylist)
        {
            var playlist = _context.PlayList.Find(maplaylist);

            // Lấy danh sách các bài hát thuộc playlist
            var baihat = _context.BaiHat
                .Where(b => _context.PlayList_BaiHat
                    .Any(pb => pb.MaBaiHat == b.MaBaiHat && pb.MaPlayList == playlist.MaPlayList))
                .ToList();

            // Xóa các bài hát thuộc playlist trong bảng PlayList_BaiHat
            var playlistBaiHatEntries = _context.PlayList_BaiHat
                .Where(pb => pb.MaPlayList == playlist.MaPlayList);

            _context.PlayList_BaiHat.RemoveRange(playlistBaiHatEntries);

            // Xóa các bài hát thuộc playlist
            _context.BaiHat.RemoveRange(baihat);

            // Xóa playlist
            _context.PlayList.Remove(playlist);

            // Lưu các thay đổi vào cơ sở dữ liệu
            _context.SaveChanges();

            return RedirectToAction("LietKePlayList");
        }


        private void loadNN()
        {
            List<NguoiNghe> listNguoiNghe = _context.NguoiNghe.ToList();
            ViewBag.nguoinghelist = listNguoiNghe;
        }

        public IActionResult XemChiTiet(string maplaylist)
        {
            var query = from baihat in _context.BaiHat
                        join playlist_baihat in _context.PlayList_BaiHat
                        on baihat.MaBaiHat equals playlist_baihat.MaBaiHat
                        join casi_baihat in _context.CaSi_BaiHat
                        on playlist_baihat.MaBaiHat equals casi_baihat.MaBaiHat
                        join casi in _context.CaSi
                        on casi_baihat.MaCaSi equals casi.MaCaSi
                        where playlist_baihat.MaPlayList == maplaylist
                        select new
                        {        
                            TenBaiHat = baihat.TenBaiHat,                         
                            TenCaSi = casi.TenCaSi,
                        };
            ViewBag.list = query.ToList();
            return View();
        }
       

    }
}
