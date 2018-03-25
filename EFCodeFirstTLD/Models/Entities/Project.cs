using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstTLD.Models.Entities
{
    [Table("Project")]
    public class Project
    {
        [Key]
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Description { get; set; }

        // 1 Project có nhiều bảng ProjectJoin
        public virtual ICollection<ProjectJoin> ProjectJoins { get; set; }
    }
}