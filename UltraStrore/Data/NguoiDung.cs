using System;
using System.Collections.Generic;

namespace UltraStrore.Data
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            DanhSachDiaChis = new HashSet<DanhSachDiaChi>();
            DonHangMaNguoiDungNavigations = new HashSet<DonHang>();
            DonHangMaNhanVienNavigations = new HashSet<DonHang>();
            GioHangs = new HashSet<GioHang>();

            MaNguoiDung = "ND001";
            HoTen = "Nguyễn Thanh Quang";
            NgaySinh = new DateTime(2005, 5, 15);
            Sdt = "0367219692";
            Cccd = "1066205015270";
            Email = "quang@gmail.com";
            DiaChi = "22 giải phóng, Buôn ma thuật";
            MatKhau = "khachhang123";
            TrangThai = 0;  // 0 Là khách hàng  1 là admin 2 là nhân viên
            HinhAnh = "";
            NgayTao = DateTime.Now;
            MoTa = "Khách hàng nhiều tiền.";

            var nguoiDung2 = new NguoiDung
            {
                MaNguoiDung = "ND002",
                HoTen = "Triệu Văn tuệ",
                NgaySinh = new DateTime(2001, 8, 10),
                Sdt = "0997219692",
                Cccd = "066205015290",
                Email = "tue@gmail.com",
                DiaChi = "22 tan an, Buôn ma thuat",
                MatKhau = "nhanvien123",
                TrangThai = 2,
                HinhAnh = "",
                NgayTao = DateTime.Now,
                MoTa = "Nhân viên chăm chỉ"
            };

            var nguoiDung3 = new NguoiDung
            {
                MaNguoiDung = "ND003",
                HoTen = "Ngô Quang Trung",
                NgaySinh = new DateTime(1992, 8, 10),
                Sdt = "0987654321",
                Cccd = "066654321012",
                Email = "trung@gmail.com",
                DiaChi = "33 tay nguyen, Buôn ma thuật",
                MatKhau = "admin123",
                TrangThai = 1,
                HinhAnh = "",
                NgayTao = DateTime.Now,
                MoTa = "Admin tốt bụng"
            };
        }

        public string MaNguoiDung { get; set; } = null!;
        public string? HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? Sdt { get; set; }
        public string? Cccd { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public string? MatKhau { get; set; }
        public int? TrangThai { get; set; }
        public string? HinhAnh { get; set; }
        public DateTime? NgayTao { get; set; }
        public string? MoTa { get; set; }



        public virtual ICollection<DanhSachDiaChi> DanhSachDiaChis { get; set; }
        public virtual ICollection<DonHang> DonHangMaNguoiDungNavigations { get; set; }
        public virtual ICollection<DonHang> DonHangMaNhanVienNavigations { get; set; }
        public virtual ICollection<GioHang> GioHangs { get; set; }
    }
}
