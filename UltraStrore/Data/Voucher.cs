using System;
using System.Collections.Generic;

namespace UltraStrore.Data;

public partial class Voucher
{
    public string MaVoucher { get; set; } = null!;

    public string? TenVoucher { get; set; }

    public double? GiamGia { get; set; }

    public string? MoTa { get; set; }

    public DateOnly? NgayBatDau { get; set; }

    public DateOnly? NgayKetThuc { get; set; }

    public string? DieuKien { get; set; }

    public int? SoLuong { get; set; }

    public bool? TrangThai { get; set; }
}
