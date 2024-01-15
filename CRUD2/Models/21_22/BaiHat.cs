using System.ComponentModel.DataAnnotations;

namespace CRUD2.Models._21_22
{
    public class BaiHat
    {
        [Key]
        public string MaBaiHat { get; set; }
        public string TenBaiHat { get; set; }
        public string TheLoai { get; set; }
    }
}
