using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhachSan.Models
{
    public partial class TrangThaiDat
    {
        public TrangThaiDat()
        {
            DatPhongs = new HashSet<DatPhong>();
        }

        public int MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }

        public virtual ICollection<DatPhong> DatPhongs { get; set; }
    }
}
