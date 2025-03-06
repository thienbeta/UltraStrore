using UltraStrore.Data;
using UltraStrore.Helper;
using UltraStrore.Models.EditModels;
using UltraStrore.Models.ViewModels;

namespace UltraStrore.Repository
{
    public interface ISanPhamServices
    {
        Task<List<SanPhamView>> ListSanPham(string? id);
        Task<List<SanPham>> SanPhamByID(string? id);
        Task<List<SanPhamByIDSorted>> SanPhamByIDSorteds(string? id);
        Task<APIResponse> EditSanPham(List<SanPhamEdit> data);
    }
}
