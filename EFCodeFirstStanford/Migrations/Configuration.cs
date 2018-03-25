using System;
using EFCodeFirstStanford.Models;

namespace EFCodeFirstStanford.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirstStanford.Models.QuanLyNhanSuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFCodeFirstStanford.Models.QuanLyNhanSuDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // Thêm dữ liệu cho table PhongBan

            context.PhongBans.AddOrUpdate(
                p => p.MaPhong,
                new PhongBan
                {
                    MaPhong = "CNTT",
                    TenPhong = "Công nghệ thông tin"
                },
                new PhongBan
                {
                    MaPhong = "DT",
                    TenPhong = "Điện tử"
                }
            );

            // Thêm dữ liệu mẫu cho table NhanVien
            context.NhanViens.AddOrUpdate(
                p => p.MaNv,
                new NhanVien
                {
                    MaNv = "SF001",
                    HoTen = "Nguyễn Văn A",
                    NgaySinh = DateTime.Now,
                    Email = "nguyenvana@gmail.com",
                    DiaChi = "Quảng Ninh"
                },
                new NhanVien
                {
                    MaNv = "SF002",
                    HoTen = "Trần Thị B",
                    NgaySinh = DateTime.Now,
                    Email = "tranthib@gmail.com",
                    DiaChi = "Hải Phòng"
                },
                new NhanVien
                {
                    MaNv = "SF003",
                    HoTen = "Nguyễn Hoàng C",
                    NgaySinh = DateTime.Now,
                    Email = "nguyenhoangc@gmail.com",
                    DiaChi = "Hà Nội"
                }

            );
            context.SaveChanges();

        }
    }
}
