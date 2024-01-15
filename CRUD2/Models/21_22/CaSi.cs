using System.ComponentModel.DataAnnotations;

namespace CRUD2.Models._21_22
{
    public class CaSi
    {
        [Key]
        public String MaCaSi { get; set; }
        public String TenCaSi { get; set; }
        public Boolean GioiTinh { get; set; }

        public DateTime NamSinh { get; set; }
    }
}
