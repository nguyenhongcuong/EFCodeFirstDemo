using System.Data.Entity;

namespace EFCodeFirstStanford.Models
{
    public class QuanLyNhanSuDbContext : DbContext
    {
        public QuanLyNhanSuDbContext():base("QuanLyNhanSuDbContextStanford")
        {
            
        }

        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhongBan> PhongBans { get; set; }
        /* Sử dụng Migrations để create, update, delete database khi dùng Code First
         * Mở Package Manager Console
         * Gõ Enable-Migrations. Đợi .NET tạo Migrations
         * Tìm đến Folder Migrations mở file Configuration.cs
         * Thêm dữ liệu hay cấu hình, tùy chỉnh gì trong hàm Seed
         * Sau khi cấu hình, cài đặt, thay đổi...
         * Gõ Add-Migration 'Tên Migrations'
         * VD: Add-Migration 'FirstMigrations'
         * Đợi khi tạo xong sẽ có 1 flie .css trong Folder Migrations với tên tương ứng
         * Có thể sửa chữa, cập nhật, delete trong file này.
         * Cuối cùng Gõ Update-Database để kết thúc
         */
    }
}