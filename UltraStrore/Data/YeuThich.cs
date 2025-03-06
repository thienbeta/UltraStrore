using System;
using System.Collections.Generic;

namespace UltraStrore.Data
{
    public partial class YeuThich
    {
        public string MaYeuThich { get; set; } = null!;
        public string? MaSanPham { get; set; }
        public string? MaNguoiDung { get; set; }
        public int? SoLuongYeuThich { get; set; }
        public DateTime? NgayYeuThich { get; set; }

        public virtual SanPham? MaSanPhamNavigation { get; set; }
    }
}
