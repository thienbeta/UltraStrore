using System;
using System.Collections.Generic;

namespace UltraStrore.Data;

public partial class LoaiSanPham
{
    public string MaLoaiSanPham { get; set; } = null!;

    public string? TenLoaiSanPham { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
