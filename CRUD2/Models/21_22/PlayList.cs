using System.ComponentModel.DataAnnotations;

namespace CRUD2.Models._21_22
{
    public class PlayList
    {
        [Key]
        public String MaPlayList { get; set; }

        public String TenPlayList { get; set; }

        public int SoLuong { get; set; }

        public String MaNN { get; set; }
    }
}
