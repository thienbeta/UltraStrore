using System;
using System.Collections.Generic;

namespace UltraStrore.Data;

public partial class NguoiDung
{
    public string MaNguoiDung { get; set; } = null!;

    public string? HoTen { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? Sdt { get; set; }

    public string? Cccd { get; set; }

    public string? Email { get; set; }

    public string? DiaChi { get; set; }
    public string? TaiKhoan { get; set; }

    public string? MatKhau { get; set; }

    public bool? TrangThai { get; set; }

    public string? HinhAnh { get; set; }

    public DateOnly? NgayDangKy { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<DanhSachDiaChi> DanhSachDiaChis { get; set; } = new List<DanhSachDiaChi>();

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();

    public virtual ICollection<GioHang> GioHangs { get; set; } = new List<GioHang>();
}
