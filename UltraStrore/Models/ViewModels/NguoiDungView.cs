namespace UltraStrore.Models.ViewModels
{
    public class NguoiDungView
    {
        public int? MaNguoiDung { get; set; }
        public string? HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? Sdt { get; set; }
        public string? Cccd { get; set; }
        public string? Email { get; set; }
        public string? TaiKhoan { get; set; }
        public string? DiaChi { get; set; }
        public int? TrangThai { get; set; }
        public string? HinhAnh { get; set; }
        public DateTime? NgayTao { get; set; }
        public string? MoTa { get; set; }

        public List<string>? VaiTro { get; set; }

    }
}
