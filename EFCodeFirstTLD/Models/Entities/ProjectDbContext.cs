using System.Data.Entity;

namespace EFCodeFirstTLD.Models.Entities
{
    public class ProjectDbContext : DbContext
    {
        // Lưu Database vào Server Name: (localdb)\MSSQLLocalDB
        // Tên Database: ProjectDbContext
        public ProjectDbContext() : base("ProjectDbContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProjectDbContext>());
        }


        // Nếu tham số truyền vào có trong Web.cofig
        // Lưu Database vào Server Name: do cấu hình trong Web.config
        // Tên Database: do cấu hình trong Web.config
        //public ProjectDbContext() : base("ProjectDbConnectionString")
        //{

        //}
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectJoin> ProjectJoins { get; set; }

        /* Khi tạo ra 1 Databae bằng Code First đã lưu vào trong CSDL 
         * mà giờ muốn thay đổi, cập nhật các entity (class)
         * => có lỗi. Khắc phục
         * Cách 1: vào trong Application_Start trong file Global.asax.cs
         * Thêm code sau:
         * Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProjectDbContext>());
         * Cách 2: Trong contructor của file DbContext thêm dòng code tương tự
         * 
         */
    }
}