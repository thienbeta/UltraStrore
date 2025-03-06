using UltraStrore.Data.Temp;
using UltraStrore.Models.ViewModels;

namespace UltraStrore.Repository
{
    public interface ISanPhamServices
    {
        Task<List<SanPhamView>> ListSanPham(string? id);
        Task<List<SanPham>> SanPhamByID(string? id);
    }
}
