using System;
using System.ComponentModel.DataAnnotations;

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
    }
}