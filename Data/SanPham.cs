using System;
using System.Collections.Generic;

namespace UltraStrore.Data;

public partial class SanPham
{
    public string MaSanPham { get; set; } = null!;

    public string? TenSanPham { get; set; }

    public int? SoLuong { get; set; }

    public int? Gia { get; set; }

    public string? MaComBo { get; set; }

    public string? MaThuongHieu { get; set; }

    public string? MaLoaiSanPham { get; set; }

    public string? KichThuoc { get; set; }

    public DateOnly? NgayTao { get; set; }

    public bool? Example { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<BinhLuan> BinhLuans { get; set; } = new List<BinhLuan>();

    public virtual ICollection<ChiTietComBo> ChiTietComBos { get; set; } = new List<ChiTietComBo>();

    public virtual ICollection<HinhAnh> HinhAnhs { get; set; } = new List<HinhAnh>();

    public virtual LoaiSanPham? MaLoaiSanPhamNavigation { get; set; }

    public virtual ThuongHieu? MaThuongHieuNavigation { get; set; }

    public virtual ICollection<Video> Videos { get; set; } = new List<Video>();

    public virtual ICollection<YeuThich> YeuThiches { get; set; } = new List<YeuThich>();
}
