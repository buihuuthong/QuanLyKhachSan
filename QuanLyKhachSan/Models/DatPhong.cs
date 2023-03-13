using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace QuanLyKhachSan.Models
{
    public partial class DatPhong
    {
        public int MaDatPhong { get; set; }
        public int MaKhachHang { get; set; }
        public int MaPhong { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime NgayBatDau { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime NgayKetThuc { get; set; }
        public int SoNgayThue { get; set; }
        public int ThanhTien { get; set; }
        public int MaNhanVien { get; set; }
        public int MaTrangThai { get; set; }

        public virtual KhachHang MaKhachHangNavigation { get; set; }
        public virtual NhanVien MaNhanVienNavigation { get; set; }
        public virtual Phong MaPhongNavigation { get; set; }
        public virtual TrangThaiDat MaTrangThaiNavigation { get; set; }
    }
}
