using EFCodeFirstTEDU.Models;

namespace EFCodeFirstTEDU.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirstTEDU.Models.EmployeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFCodeFirstTEDU.Models.EmployeeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Employees.AddOrUpdate(
                p => p.Id,
                new Employee { Name = "Nguyễn Văn A", Salary = 35000, CreatedDate = DateTime.Now, Status = true },
                new Employee { Name = "Trần Thị B", Salary = 46000, CreatedDate = DateTime.Now, Status = true },
                new Employee { Name = "Vũ Ngọc C", Salary = 37500, CreatedDate = DateTime.Now, Status = false },
                new Employee { Name = "Lê Thị H", Salary = 33000, CreatedDate = DateTime.Now, Status = false },
                new Employee { Name = "Hoàng Văn K", Salary = 47000, CreatedDate = DateTime.Now, Status = false },
                new Employee { Name = "Nguyễn Khánh L", Salary = 39000, CreatedDate = DateTime.Now, Status = false },
                new Employee { Name = "Mạc Văn D", Salary = 41000, CreatedDate = DateTime.Now, Status = true },
                new Employee { Name = "Phùng Hạnh D", Salary = 41500, CreatedDate = DateTime.Now, Status = false },
                new Employee { Name = "Trần Công A", Salary = 33500, CreatedDate = DateTime.Now, Status = true },
                new Employee { Name = "Hoàng Mai K", Salary = 44000, CreatedDate = DateTime.Now, Status = false }

            );
        }
    }
}
