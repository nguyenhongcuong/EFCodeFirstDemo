using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstTLD.Models.Entities
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }

        // 1 Employee có thể có nhiều ProjectJoin
        public virtual ICollection<ProjectJoin> ProjectJoins { get; set; }

    }
}