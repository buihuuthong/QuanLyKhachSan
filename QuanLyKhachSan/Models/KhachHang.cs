using System;
using System.Collections.Generic;

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
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }

        public virtual ICollection<DatPhong> DatPhongs { get; set; }
    }
}
