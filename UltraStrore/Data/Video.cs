using System;
using System.Collections.Generic;

namespace UltraStrore.Data;

public partial class Video
{
    public string MaVideo { get; set; } = null!;

    public string? TenVideo { get; set; }

    public string? MaSanPham { get; set; }

    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
