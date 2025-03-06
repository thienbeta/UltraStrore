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
            new BinhLuan { MaBinhLuan = 1, MaSanPham = "SP001", MaNguoiDung = 1, NoiDungBinhLuan = "Sản phẩm rất tuyệt vời!", SoTimBinhLuan = 5, DanhGia = 4.5 },
            new BinhLuan { MaBinhLuan = 2, MaSanPham = "SP002", MaNguoiDung = 2, NoiDungBinhLuan = "Chất lượng kém hơn tôi nghĩ.", SoTimBinhLuan = 2, DanhGia = 2.0 },
            new BinhLuan { MaBinhLuan = 3, MaSanPham = "SP003", MaNguoiDung = 3, NoiDungBinhLuan = "Giá trị tuyệt vời!", SoTimBinhLuan = 8, DanhGia = 5.0 }
        };

        public async Task<List<BinhLuanView>> ListBinhLuan()
        {
            var result = binhluan.Select(bl => new BinhLuanView
            {
                MaBinhLuan = bl.MaBinhLuan,
                MaSanPham = bl.MaSanPham,
                MaNguoiDung = bl.MaNguoiDung,
                NoiDungBinhLuan = bl.NoiDungBinhLuan,
                SoTimBinhLuan = bl.SoTimBinhLuan,
                DanhGia = bl.DanhGia
            }).ToList();

            return await Task.FromResult(result);
        }

        public async Task<BinhLuan> AddBinhLuan(BinhLuan binhLuan)
        {
            binhluan.Add(binhLuan);
            return await Task.FromResult(binhLuan);
        }

        public async Task<BinhLuan> UpdateBinhLuan(int maBinhLuan, BinhLuan binhLuan)
        {
            var existingBinhLuan = binhluan.FirstOrDefault(bl => bl.MaBinhLuan == maBinhLuan);
            if (existingBinhLuan == null)
            {
                return null;
            }

            existingBinhLuan.MaSanPham = binhLuan.MaSanPham;
            existingBinhLuan.MaNguoiDung = binhLuan.MaNguoiDung;
            existingBinhLuan.NoiDungBinhLuan = binhLuan.NoiDungBinhLuan;
            existingBinhLuan.SoTimBinhLuan = binhLuan.SoTimBinhLuan;
            existingBinhLuan.DanhGia = binhLuan.DanhGia;

            return await Task.FromResult(existingBinhLuan);
        }

        public async Task<bool> DeleteBinhLuan(int maBinhLuan)
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