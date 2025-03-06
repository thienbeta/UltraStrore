namespace UltraStrore.Models.ViewModels
{
    public class SanPhamView
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string? ThuongHieu { get; set; }
        public string? LoaiSanPham { get; set; }
        public List<string>? KichThuoc { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public List<string>? MauSac {  get; set; }
        public List<string>? Hinh { get; set; }
        public DateOnly? NgayTao { get; set; }
        public int? TrangThai { get; set; }
    }
}
