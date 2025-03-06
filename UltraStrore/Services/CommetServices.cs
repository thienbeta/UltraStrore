using UltraStrore.Data;
using UltraStrore.Models.ViewModels;
using UltraStrore.Repository;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace UltraStrore.Services
{
    public class CommetServices : ICommetServices
    {
        // Danh sách bình luận tĩnh (giả lập cơ sở dữ liệu)
        public static List<BinhLuan> binhluan = new List<BinhLuan>
        {
            new BinhLuan { MaBinhLuan = "BL001", MaSanPham = "SP001", MaNguoiDung = "ND001", NoiDungBinhLuan = "Sản phẩm rất tuyệt vời!", SoBinhLuan = 5, DanhGia = 4.5 },
            new BinhLuan { MaBinhLuan = "BL002", MaSanPham = "SP002", MaNguoiDung = "ND002", NoiDungBinhLuan = "Chất lượng kém hơn tôi nghĩ.", SoBinhLuan = 2, DanhGia = 2.0 },
            new BinhLuan { MaBinhLuan = "BL003", MaSanPham = "SP003", MaNguoiDung = "ND003", NoiDungBinhLuan = "Giá trị tuyệt vời!", SoBinhLuan = 8, DanhGia = 5.0 }
        };

        public async Task<List<BinhLuanView>> ListBinhLuan()
        {
            var result = binhluan.Select(bl => new BinhLuanView
            {
                MaBinhLuan = bl.MaBinhLuan,
                MaSanPham = bl.MaSanPham,
                MaNguoiDung = bl.MaNguoiDung,
                NoiDungBinhLuan = bl.NoiDungBinhLuan,
                SoBinhLuan = bl.SoBinhLuan,
                DanhGia = bl.DanhGia
            }).ToList();

            return await Task.FromResult(result);
        }

        public async Task<BinhLuan> AddBinhLuan(BinhLuan binhLuan)
        {
            binhluan.Add(binhLuan);
            return await Task.FromResult(binhLuan);
        }

        public async Task<BinhLuan> UpdateBinhLuan(string maBinhLuan, BinhLuan binhLuan)
        {
            var existingBinhLuan = binhluan.FirstOrDefault(bl => bl.MaBinhLuan == maBinhLuan);
            if (existingBinhLuan == null)
            {
                return null;
            }

            existingBinhLuan.MaSanPham = binhLuan.MaSanPham;
            existingBinhLuan.MaNguoiDung = binhLuan.MaNguoiDung;
            existingBinhLuan.NoiDungBinhLuan = binhLuan.NoiDungBinhLuan;
            existingBinhLuan.SoBinhLuan = binhLuan.SoBinhLuan;
            existingBinhLuan.DanhGia = binhLuan.DanhGia;

            return await Task.FromResult(existingBinhLuan);
        }

        public async Task<bool> DeleteBinhLuan(string maBinhLuan)
        {
            var binhLuanToRemove = binhluan.FirstOrDefault(bl => bl.MaBinhLuan == maBinhLuan);
            if (binhLuanToRemove == null)
            {
                return false;
            }

            binhluan.Remove(binhLuanToRemove);
            return await Task.FromResult(true);
        }
    }
}