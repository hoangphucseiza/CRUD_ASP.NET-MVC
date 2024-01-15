using System.ComponentModel.DataAnnotations;

namespace CRUD2.Models._21_22
{
    public class NguoiNghe
    {
        [Key]
        public String MaNguoiNghe { get; set; }

        public String TenNN { get; set; }

        public Boolean GioiTinh { get; set; }
    }
}
