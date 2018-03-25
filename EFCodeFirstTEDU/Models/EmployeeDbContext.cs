using System.Data.Entity;

namespace EFCodeFirstTEDU.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("EmployeeDbContextTEDU")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}