using System;
using System.Collections.Generic;

namespace UltraStrore.Data
{
    public partial class ThuongHieu
    {
        public ThuongHieu()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaThuongHieu { get; set; } = null!;
        public string? TenThuongHieu { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
