using _22_23.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace _22_23.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {
           
        }
        public DbSet<ChuyenBay> ChuyenBay { get; set; }
        public DbSet<CT_CB> CT_CB { get; set; }
        public DbSet<HanhKhach> HanhKhach { get; set; }
        public DbSet<MayBay> MayBay { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<ChuyenBay>().HasKey(c => c.MaCH);
            modelBuilder.Entity<HanhKhach>().HasKey(c => c.MaHK);
            modelBuilder.Entity<MayBay>().HasKey(c => c.MaMB);
            modelBuilder.Entity<CT_CB>().HasKey(ct => new {ct.MaCH, ct.MaHK});
        }
    }
}
