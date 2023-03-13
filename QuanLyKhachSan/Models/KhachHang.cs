using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace QuanLyKhachSan.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DatPhongs = new HashSet<DatPhong>();
        }

        public int MaKhachHang { get; set; }
        public string HoTen { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }

        public virtual ICollection<DatPhong> DatPhongs { get; set; }
    }
}
