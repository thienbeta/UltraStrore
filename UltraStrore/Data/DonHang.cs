using System;
using System.Collections.Generic;

namespace UltraStrore.Data
{
    public partial class DonHang
    {
        public int MaDonHang { get; set; }
        public int? MaNguoiDung { get; set; }
        public int? MaNhanVien { get; set; }
        public DateTime? NgayDat { get; set; }
        public string? TrangThaiDonHang { get; set; }
        public string? TrangThaiHang { get; set; }
        public string? LyDoHuy { get; set; }
        public string? TenNguoiNhan { get; set; }
        public string? Sdt { get; set; }
        public string? DiaChi { get; set; }

        public virtual NguoiDung? MaNguoiDungNavigation { get; set; }
        public virtual NguoiDung? MaNhanVienNavigation { get; set; }
    }
}
