using CRUD2.Models;
using CRUD2.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CRUD2.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> tbl_Student { get; set; }
        public DbSet<Departments> tbl_Departments { get; set; }

    }
}
