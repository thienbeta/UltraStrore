using UltraStrore.Models.ViewModels;

namespace UltraStrore.Repository
{
    public interface ISanPhamServices
    {
        Task<List<SanPhamView>> ListSanPham(string? id);
    }
}
