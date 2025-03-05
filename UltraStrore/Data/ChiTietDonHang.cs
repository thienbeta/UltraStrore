using System;
using System.Collections.Generic;

namespace UltraStrore.Data;

public partial class ChiTietDonHang
{
    public string MaCtdh { get; set; } = null!;

    public string? MaDonHang { get; set; }

    public string? MaSanPham { get; set; }

    public int? SoLuong { get; set; }

    public int? Gia { get; set; }

    public int? ThanhTien { get; set; }

    public int? MaCombo { get; set; }

    public virtual ComBoSanPham? MaComboNavigation { get; set; }
}
