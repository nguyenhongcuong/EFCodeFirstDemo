using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstQLSV.Models
{
    public class KetQuaThi
    {
        /* Nếu có 2 trường làm khóa chính
         * Column(Order = 1): Chỉ thứ tự của từng cột
         */

        [Key,Column(Order = 1)]
        [StringLength(10)]
        public string MaSv { get; set; }


        [Key, Column(Order = 2)]
        [StringLength(10)]
        public string MaMon { get; set; }

        public float DiemThi { get; set; }

        [ForeignKey("MaSv")]
        public virtual SinhVien SinhVien { get; set; }

        [ForeignKey("MaMon")]
        public virtual MonHoc MonHoc { get; set; }

    }
}