using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhachSan.Models
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public int MaChucVu { get; set; }
        public string TenChucVu { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
