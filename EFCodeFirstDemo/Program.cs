using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyContext())
            {
                // Create and save a new Students
                //Console.WriteLine("Adding new students");

                //var student = new Student
                //{
                //    FirstMidName = "Alain",
                //    LastName = "Bomer",
                //    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                //};

                //context.Students.Add(student);

                //var student1 = new Student
                //{
                //    FirstMidName = "Mark",
                //    LastName = "Upston",
                //    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                //};

                //context.Students.Add(student1);
                //context.SaveChanges();

                //Display all Students from the database
                var students = (from s in context.Students
                                orderby s.FirstMidName
                                select s).ToList<Student>();

                Console.WriteLine("Retrieve all Students from the database:");

                foreach (var stdnt in students)
                {
                    string name = stdnt.FirstMidName + " " + stdnt.LastName;
                    Console.WriteLine("ID: {0}, Name: {1}", stdnt.StdntID, name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
    public enum Grade
    {
        A, B, C, D, F
    }
    public class DrivingLicense
    {
        // Xét khóa cho column và đặt thứ tự nếu có nhiều hơn 1 column làm khóa
        [Key, Column(Order = 1)]
        public int LicenseNumber { get; set; }
        [Key, Column(Order = 2)]
        public string IssuingCountry { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expires { get; set; }
    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        // Tên khóa phải trùng với thuộc tính tương tự

        //[ForeignKey("CourseID")]
        // Nếu có 2 trường trỏ tới cùng 1 object nhưng lại khác tên nhau
        // Qua  bảng Chính thêm thuộc tính InverseProperty
        public virtual Course CurrCourse { get; set; }
        public virtual Course PrevCourse { get; set; }
        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }
    }

    // Đặt tên cho table
    [Table("StudentsInfo")]
    public class Student
    {
        // Xét column làm khóa
        // Nếu tên column là Id thì mặc định sẽ chọn column đó làm khóa
        [Key]
        public int StdntID { get; set; }

        [Required]
        public string LastName { get; set; }

        // Xét thuộc tính not null cho column
        [Required]

        // Đặt tên cho column
        [Column("FirstName")]
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Không tạo column này trong table
        [NotMapped]
        public int FatherName { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    public class Course
    {
        public int CourseID { get; set; }

        // Đặt độ dài cho column
        //[MaxLength(24), MinLength(5)]
        [StringLength(24)]
        public string Title { get; set; }
        public int Credits { get; set; }

        [Timestamp]
        public byte[] TStamp { get; set; }

        [InverseProperty("CurrCourse")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }


        [InverseProperty("PrevCourse")]
        public virtual ICollection<Enrollment> PrevEnrollments { get; set; } 

    }

    public class MyContext : DbContext
    {
        public MyContext() : base()
        {
            Database.SetInitializer<MyContext>(new DropCreateDatabaseIfModelChanges<MyContext>());
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Student>().Property(s => s.FirstMidName)
        //    //   .HasColumnName("FirstName");
        //}
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<DrivingLicense> DrivingLicenses { get; set; }
    }
}
