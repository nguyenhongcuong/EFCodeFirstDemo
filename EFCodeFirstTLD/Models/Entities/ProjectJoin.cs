using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstTLD.Models.Entities
{
    [Table("ProjectJoin")]
    public class ProjectJoin
    {
        [Key]
        public  int ProjectJoinId { get; set; }

        // Xét khóa ngoại Cách 2
        //[ForeignKey("Employee")]
        public string EmployeeId { get; set; }

        //[ForeignKey("Project")]
        public string ProjectId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }

        // Navigate tới các thực thể liên quan
        // EmployeeId => lấy được thông tin Employee
        // ProjectId => lấy được thông tin của Project

        

       /* Xét khóa ngoại
        * Cách 1            
        */

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
    }
}