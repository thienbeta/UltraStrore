using UltraStrore.Data;
using UltraStrore.Models.ViewModels;

namespace UltraStrore.Repository
{
    public interface ICommetServices
    {
        Task<List<BinhLuanView>> ListBinhLuan();
        Task<BinhLuan> AddBinhLuan(BinhLuan binhLuan);
        Task<BinhLuan> UpdateBinhLuan(string maBinhLuan, BinhLuan binhLuan);
        Task<bool> DeleteBinhLuan(string maBinhLuan);
    }
}