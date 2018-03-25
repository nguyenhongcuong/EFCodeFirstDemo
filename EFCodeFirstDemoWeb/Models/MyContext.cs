using System.Data.Entity;

namespace EFCodeFirstDemoWeb.Models
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyDbContextWeb")
        {

        }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        // Dùng Fluent API để cấu hình cho database
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(s=> s.FirstMidName)
            .HasColumnName("FirstName");
        }
    }
}