using System.ComponentModel.DataAnnotations;

namespace CRUD2.Models
{
    public class Departments
    {
        [Key]
        public int ID { get; set; }

        public string Department { get; set; }


    }
}
