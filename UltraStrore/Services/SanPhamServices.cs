using System;
using System.Collections.Generic;
using UltraStrore.Data.Temp;
using UltraStrore.Models.ViewModels;
using UltraStrore.Repository;

namespace UltraStrore.Services
{
    public class SanPhamServices : ISanPhamServices
    {
        public List<SanPham> sanpham = new List<SanPham>
        {
            new SanPham
            {
                ID = "A00001_ff0000_XL",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "XL",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1,
                Example = true,
            },
             new SanPham
            {
                ID = "A00001_0000ff_XL",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "XL",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1,
                Example = false,
            },
              new SanPham
            {
                ID = "A00001_00ff00_XL",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "XL",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1,
                Example = false,
            },
               new SanPham
            {
                ID = "A00001_000000_XL",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "XL",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1,
                Example = false,
            },
            new SanPham
            {
                ID = "A00001_ffffff_XL",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "XL",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1, 
                Example = false,
            },
             new SanPham
            {
                ID = "A00001_ff00ff_XL",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "XL",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1, 
                Example = false,
            },
              new SanPham
            {
                ID = "A00001_ffff00_XL",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "XL",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1,
                Example = false,
            },
               new SanPham
            {
                ID = "A00001_00ffff_XL",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "XL",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1,
                Example = false,
            },
               new SanPham
            {
                ID = "A00001_000000_X",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "X",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1, 
                Example = false,
            },
                new SanPham
            {
                ID = "A00001_000000_XXL",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "XXL",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1,
                Example = false,
            },
                new SanPham
            {
                ID = "A00001_000000_XXXL",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "XXXL",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1,
                Example = false,
            },
                new SanPham
            {
                ID = "A00001_000000_M",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "M",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1,
                Example = false,
            },
                new SanPham
            {
                ID = "A00001_000000_S",
                Name = "Áo thun nam",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "S",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1,
                Example = false,
            },new SanPham
            {
                ID = "A00002_00ffff_XL",
                Name = "Áo thun nữ",
                MaThuongHieu = 1,
                LoaiSanPham = 1,
                KichThuoc = "XL",
                SoLuong = 100,
                DonGia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1,
                Example = false,
            },
        };
        public List<HinhAnhSanPham> HinhAnhSanPhams = new List<HinhAnhSanPham>
        {
            new HinhAnhSanPham
            {
                ID=1,
                MaSanPham = "A00001_ff0000_XL",
                Link = "https://media3.coolmate.me/cdn-cgi/image/quality=80,format=auto/uploads/June2024/33333.5.jpg"
            },
            new HinhAnhSanPham
            {
                ID=2,
                MaSanPham = "A00001_00ff00_XL",
                Link = "https://media3.coolmate.me/cdn-cgi/image/quality=80,format=auto/uploads/June2024/33333.5.jpg"
            },
            new HinhAnhSanPham
            {
                ID=3,
                MaSanPham = "A00001_0000ff_XL",
                Link = "https://media3.coolmate.me/cdn-cgi/image/quality=80,format=auto/uploads/June2024/33333.5.jpg"
            },
            new HinhAnhSanPham
            {
                ID=4,
                MaSanPham = "A00002_00ffff_XL",
                Link = "https://content.pancake.vn/2-23/s2550x3600/2023/12/14/98a33459624269938a7797823e29e9bb04979da5.jpg"
            }
        };

        public async Task<List<SanPhamView>> ListSanPham(string id)
        {
            List<SanPhamView> listsp = new List<SanPhamView>();
            var nhomSanPham = sanpham.GroupBy(s => s.ID.Substring(0, 6)).ToList();

            foreach (var nhom in nhomSanPham)
            {
                var sanPhamDauTien = nhom.First();
                var HinhAnhSanPhamList = HinhAnhSanPhams.Where(g => g.MaSanPham.Substring(0,6) == sanPhamDauTien.ID.Substring(0, 6)).Select(g => g.Link).ToList();
                var listMauSac = nhom.Select(sp => sp.ID.Split('_')[1]).Distinct().ToList();
                var listKichThuoc = nhom.Select(sp => sp.ID.Split('_')[2]).Distinct().ToList();
                var tongSoLuong = nhom.Sum(sp => sp.SoLuong);
                listsp.Add(new SanPhamView
                {
                    ID = sanPhamDauTien.ID.Substring(0,6),
                    Name = sanPhamDauTien.Name,
                    MauSac = listMauSac,
                    KichThuoc = listKichThuoc,
                    Hinh = HinhAnhSanPhamList,
                    SoLuong = tongSoLuong,
                    DonGia = sanPhamDauTien.DonGia,
                    LoaiSanPham = "Áo thun",
                    ThuongHieu = "Gucci",
                    NgayTao = sanPhamDauTien.NgayTao
                });
            }
            if(string.IsNullOrEmpty(id))
            {
                return listsp.OrderByDescending(g => g.NgayTao).ToList();
            }
            return listsp.Where(g => g.ID.Trim() == id.Trim()).ToList();
        }
    }
}
