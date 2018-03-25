using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstStanford.Models
{
    // Gen từ class NhanVien thành table có tên là NhanVien trong Database
    [Table("NhanVien")]
    public class NhanVien
    {
        /* [Key]: Đặt thuộc tính khóa chính cho column MaNv 
         * => trong bảng NhanVien column MaNv là khóa chính
         *  [StringLength(10)]: Đặt độ dài cho column MaNv là 10 kí tự
         */
        [Key]
        [StringLength(10)]
        public string MaNv { get; set; }

        [StringLength(30)]
        public string HoTen { get; set; }


        /*  [DataType(DataType.Date)]: Đặt type cho column NgaySinh là datetime
         */
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(10)]
        public string PhongBanId { get; set; }

        [ForeignKey("PhongBanId")]
        public virtual PhongBan PhongBan { get; set; }

    }
}