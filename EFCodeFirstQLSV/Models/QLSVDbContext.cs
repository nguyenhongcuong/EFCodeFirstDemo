using System.Data.Entity;

namespace EFCodeFirstQLSV.Models
{
    public class QlsvDbContext : DbContext
    {
        public QlsvDbContext() : base("QlsvDbContextTuanNguyen")
        {

        }
        public DbSet<KetQuaThi> KetQuaThis { get; set; }
        public DbSet<LopHoc> LopHocs { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
    }
}