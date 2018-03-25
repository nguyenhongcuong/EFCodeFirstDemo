using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstQLSV.Models
{
    public class SinhVien
    {
        [Key]
        [StringLength(10)]
        public string MaSv { get; set; }


        /*  [Required]: Tạo ra column HoTen với property là Not null
         */
        [StringLength(50)]
        [Required]
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }


        public string MaLop { get; set; }

        [ForeignKey("MaLop")]
        public virtual LopHoc LopHoc { get; set; }

        public virtual ICollection<KetQuaThi> KetQuaThis { get; set; }
    }
}