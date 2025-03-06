namespace UltraStrore.Models.ViewModels
{
    public class GioHangView
    {
        public int ID { get; set; }
        public int IDNguoiDung { get; set; }
        public List<ChiTietGioHangSanPhamView>  CTGHSanPhamView {get;set; }
        public List<ChiTietGioHangComboView> CTGHComboView {get; set; }
    }
}
