using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhachSan.Models
{
    public partial class LoaiPhong
    {
        public LoaiPhong()
        {
            Phongs = new HashSet<Phong>();
        }

        public int MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public int DonGia { get; set; }

        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
