using System;
using System.Collections.Generic;

namespace UltraStrore.Data;

public partial class NhanVien
{
    public string MaNhanVien { get; set; } = null!;

    public string? TenNhanVien { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public string? MaLa { get; set; }

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
}
