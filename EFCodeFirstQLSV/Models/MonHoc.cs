using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstQLSV.Models
{
    public class MonHoc
    {
        [Key]
        [StringLength(10)]
        public string MaMon { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMon { get; set; }

        public virtual ICollection<KetQuaThi> KetQuaThis { get; set; }
    }
}