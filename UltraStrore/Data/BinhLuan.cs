using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace UltraStrore.Data
{
    public partial class BinhLuan
    {
        public BinhLuan()
        {
            HinhAnhs = new HashSet<HinhAnh>();
        }

        public string? MaBinhLuan { get; set; }
        public string? MaSanPham { get; set; }
        public string? MaNguoiDung { get; set; }
        public string? NoiDungBinhLuan { get; set; }
        public int? SoBinhLuan { get; set; }
        public double? DanhGia { get; set; }

        [JsonIgnore]
        public virtual SanPham? MaSanPhamNavigation { get; set; }
        [JsonIgnore]
        public virtual ICollection<HinhAnh> HinhAnhs { get; set; }
    }
}
