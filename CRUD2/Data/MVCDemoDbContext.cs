using CRUD2.Models;
using CRUD2.Models._19_20;
using CRUD2.Models._21_22;
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

        // Đề 21-22
        public DbSet<BaiHat> BaiHat { get; set; }
        public DbSet<CaSi_BaiHat> CaSi_BaiHat { get; set; }
        public DbSet<CaSi> CaSi { get; set; }

        public DbSet<NguoiNghe> NguoiNghe { get; set; }
        public DbSet<PlayList_BaiHat> PlayList_BaiHat { get; set; }
        public DbSet<PlayList> PlayList { get; set; }

        // Đề 19-20
        public DbSet<CongNhan> CongNhan { get; set; }
        public DbSet<DiemCachLy> DiemCachLy { get; set; }
        public DbSet<TrieuChung> TrieuChung { get; set; }
        public DbSet<CN_TC> CN_TC { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayList_BaiHat>()
                .HasKey(c => new { c.MaPlayList, c.MaBaiHat });
            modelBuilder.Entity<CaSi_BaiHat>()
                .HasKey(c => new { c.MaCaSi, c.MaBaiHat });
        }

    }
}
