using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstStanford.Models
{
    [Table("PhongBan")]
    public class PhongBan
    {
        [Key]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }

    }
}