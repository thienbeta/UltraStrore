using System;
using System.Collections.Generic;

namespace UltraStrore.Data
{
    public partial class NguoiDung
    {


        public int? MaNguoiDung { get; set; }
        public string? HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? Sdt { get; set; }
        public string? Cccd { get; set; }
        public string? Email { get; set; }
        public string? TaiKhoan { get; set; }
        public string? DiaChi { get; set; }
        public string? MatKhau { get; set; }
        public int? TrangThai { get; set; }
        public string? HinhAnh { get; set; }
        public DateTime? NgayTao { get; set; }
        public string? MoTa { get; set; }

        public virtual ICollection<DanhSachDiaChi> DanhSachDiaChis { get; set; }
        public virtual ICollection<DonHang> DonHangMaNguoiDungNavigations { get; set; }
        public virtual ICollection<DonHang> DonHangMaNhanVienNavigations { get; set; }
        public virtual ICollection<GioHang> GioHangs { get; set; }
    }
}
