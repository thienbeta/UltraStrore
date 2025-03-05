using System;
using System.Collections.Generic;

namespace UltraStrore.Data;

public partial class DonHang
{
    public string MaDonHang { get; set; } = null!;

    public string? MaNguoiDung { get; set; }

    public string? MaNhanVien { get; set; }

    public DateOnly? NgayDat { get; set; }

    public string? TrangThaiDonHang { get; set; }

    public string? TrangThaiHang { get; set; }

    public string? LyDoHuy { get; set; }

    public string? TenNguoiNhan { get; set; }

    public string? Sdt { get; set; }

    public string? DiaChi { get; set; }

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }

    public virtual NhanVien? MaNhanVienNavigation { get; set; }
}
