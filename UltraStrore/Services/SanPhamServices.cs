using System;
using System.Collections.Generic;
using UltraStrore.Data;
using UltraStrore.Helper;
using UltraStrore.Models.EditModels;
using UltraStrore.Models.ViewModels;
using UltraStrore.Repository;

namespace UltraStrore.Services
{
    public class SanPhamServices : ISanPhamServices
    {
        private readonly ApplicationDbContext _context;

        public SanPhamServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SanPhamView>> ListSanPham(string id)
        {
            List<SanPhamView> listsp = new List<SanPhamView>();
            var nhomSanPham = _context.SanPhams.GroupBy(s => s.MaSanPham.Substring(0, 6)).ToList();

            foreach (var nhom in nhomSanPham)
            {
                var sanPhamDauTien = nhom.First();
                var HinhAnhSanPhamList = _context.HinhAnhs.Where(g => g.MaSanPham.Substring(0, 6) == sanPhamDauTien.MaSanPham.Substring(0, 6)).Select(g => g.Link).ToList();
                var listMauSac = nhom.Select(sp => sp.MaSanPham.Split('_')[1]).Distinct().ToList();
                var listKichThuoc = nhom.Select(sp => sp.MaSanPham.Split('_')[2]).Distinct().ToList();
                var tongSoLuong = nhom.Sum(sp => sp.SoLuong);
                var TenLoai = _context.LoaiSanPhams.Where(g => g.MaLoaiSanPham == sanPhamDauTien.MaLoaiSanPham).Select(g => g.TenLoaiSanPham).FirstOrDefault();
                var ThuongHieu = _context.ThuongHieus.Where(g => g.MaThuongHieu == sanPhamDauTien.MaThuongHieu).Select(g => g.TenThuongHieu).FirstOrDefault();
                listsp.Add(new SanPhamView
                {
                    ID = sanPhamDauTien.MaSanPham.Substring(0, 6),
                    Name = sanPhamDauTien.TenSanPham,
                    MauSac = listMauSac,
                    KichThuoc = listKichThuoc,
                    Hinh = HinhAnhSanPhamList,
                    SoLuong = tongSoLuong ?? 0,
                    DonGia = sanPhamDauTien.Gia ?? 0,
                    LoaiSanPham = TenLoai,
                    ThuongHieu = ThuongHieu,
                    NgayTao = sanPhamDauTien.NgayTao,
                    TrangThai = sanPhamDauTien.TrangThai,
                });
            }
            if (string.IsNullOrEmpty(id))
            {
                return listsp.OrderByDescending(g => g.NgayTao).ToList();
            }
            return listsp.Where(g => g.ID.Trim() == id.Trim()).ToList();
        }
    

        public async Task<List<SanPham>> SanPhamByID(string? id)
        {
           
            var ListSanPham = _context.SanPhams.Where(g => g.MaSanPham.Contains(id)).ToList();
            return ListSanPham;
            
        }
        public async Task<List<SanPhamByIDSorted>> SanPhamByIDSorteds (string? id)
        {
            List<SanPhamByIDSorted> listsp = new List<SanPhamByIDSorted>();
            var nhomSanPham = _context.SanPhams.Where(g=>g.MaSanPham.Contains(id)).GroupBy(s => s.MaSanPham.Substring(0, 13)).ToList();
            foreach (var nhom in nhomSanPham)
            {
                var sanPhamDauTien = nhom.First();
                var HinhAnhSanPhamList = _context.HinhAnhs.Where(g => g.MaSanPham.Substring(0, 6) == sanPhamDauTien.MaSanPham.Substring(0, 6)).Select(g => g.Link).ToList();
                var listMauSac = sanPhamDauTien.MaSanPham.Split('_')[1];
                List<SanPhamEditDetail> detailedit = new List<SanPhamEditDetail>();
                foreach(var item in nhom)
                {
                    SanPhamEditDetail ed = new SanPhamEditDetail();
                    ed.KichThuoc = item.KichThuoc;
                    ed.SoLuong = item.SoLuong??0;
                    ed.Gia = item.Gia?? 0;
                    detailedit.Add(ed);
                }    
                var tongSoLuong = nhom.Sum(sp => sp.SoLuong);
                var MaLoai = sanPhamDauTien.MaLoaiSanPham;
                var ThuongHieu = sanPhamDauTien.MaThuongHieu;
                listsp.Add(new SanPhamByIDSorted
                {
                    ID = sanPhamDauTien.MaSanPham.Substring(0, 13),
                    TenSanPham = sanPhamDauTien.TenSanPham,
                    MauSac = listMauSac,                   
                    LoaiSanPham = MaLoai,
                    MaThuongHieu = ThuongHieu,
                    Details = detailedit,
                });
            }
            return listsp;

        }
        public async Task<APIResponse> EditSanPham(List<SanPhamEdit> data)
        {
            APIResponse response = new APIResponse();
            return response;
        }
    }
}
