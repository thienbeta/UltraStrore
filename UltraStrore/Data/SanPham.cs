using System;
using System.Collections.Generic;

namespace UltraStrore.Data
{
    public partial class SanPham
    {

            
        public string MaSanPham { get; set; } = null!;
        public string? TenSanPham { get; set; }
        public int? SoLuong { get; set; }
        public int? Gia { get; set; }
        public string? MaComBo { get; set; }
        public int? MaThuongHieu { get; set; }
        public int? MaLoaiSanPham { get; set; }
        public string? KichThuoc { get; set; }
        public DateTime? NgayTao { get; set; }
        public string? ChatLieu { get; set; }
        public string? MoTa { get; set; }
        public int? TrangThai { get; set; }

        public virtual LoaiSanPham? MaLoaiSanPhamNavigation { get; set; }
        public virtual ThuongHieu? MaThuongHieuNavigation { get; set; }
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        public virtual ICollection<ChiTietComBo> ChiTietComBos { get; set; }
        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
        public virtual ICollection<HinhAnh> HinhAnhs { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
        public virtual ICollection<YeuThich> YeuThichs { get; set; }
    }
}
