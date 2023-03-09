using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhachSan.Models
{
    public partial class TinhTrangPhong
    {
        public TinhTrangPhong()
        {
            Phongs = new HashSet<Phong>();
        }

        public int MaTinhTrang { get; set; }
        public string TenTinhTrang { get; set; }

        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
