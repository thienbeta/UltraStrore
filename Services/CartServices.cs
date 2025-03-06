using UltraStrore.Data.Temp;
using UltraStrore.Helper;
using UltraStrore.Models.CreateModels;
using UltraStrore.Models.ViewModels;
using UltraStrore.Repository;

namespace UltraStrore.Services
{
    public class CartServices : ICartServices
    {
        public static List<KhachHang> KhachHangaaa = new List<KhachHang>
        {
            new KhachHang
            {
                MaNguoiDung="KH001",
                TenTaiKhoan="User",
                MatKhau="123456"
            }
        };
        public static List<GioHang> GioHangaa = new List<GioHang>
        {
            new GioHang
            {
                ID=1,
                MaKhacHang="KH001"
            }
        };
        public static List<ChiTietGioHang> CTGH = new List<ChiTietGioHang>
        {
            new ChiTietGioHang
            {
                MaCTGH =1,
                MaGioHang =1,
                MaSanPham="A00001_ff0000_XL",
                MaCombo =null,
                SoLuong =2,
                Gia = 150000,
                ThanhTien = 300000,
            },
            new ChiTietGioHang
            {
                MaCTGH =2,
                MaGioHang =1,
                MaSanPham="A00002_00ffff_XL",
                MaCombo =null,
                SoLuong =3,
                Gia = 150000,
                ThanhTien = 450000,
            }
        };

        public async Task<GioHangView> GioHangViews(string MaKhachHang)
        {
            GioHangView GioHangView = new GioHangView();
            var GioHang = CartServices.GioHangaa.Where(g=>g.MaKhacHang==MaKhachHang).FirstOrDefault();
            if (GioHang != null)
            {
                var CTGH = CartServices.CTGH.Where(g => g.MaGioHang == GioHang.ID).ToList();
                List<ChiTietGioHangSanPhamView> DetailSanPhamView = new List<ChiTietGioHangSanPhamView>();
                foreach (var item in CTGH)
                {
                    var sp = SanPhamServices.sanpham.Where(g => g.ID == item.MaSanPham).FirstOrDefault();
                    ChiTietGioHangSanPhamView spview = new ChiTietGioHangSanPhamView();
                    spview.IDSanPham = item.MaSanPham;
                    spview.TenSanPham = sp.Name;
                    spview.TienSanPham = sp.DonGia * item.SoLuong;
                    spview.MauSac = sp.ID.Split('_')[1];
                    spview.KickThuoc = sp.ID.Split('_')[2];
                    spview.SoLuong = item.SoLuong;
                    DetailSanPhamView.Add(spview);
                }
                GioHangView.CTGHSanPhamView = DetailSanPhamView;
                GioHangView.IDNguoiDung = MaKhachHang;
                GioHangView.ID = GioHang.ID;
                return GioHangView;
            }
            return GioHangView;
        }

        public async Task<APIResponse> ThemSanPham(ChiTietGioHangSanPhamCreate info)
        {
            APIResponse response = new APIResponse();
            try
            {
                string MaSanPham = info.IDSanPham.Trim() + "_" + info.MauSac.Trim() + "_" + info.KichThuoc.Trim();
                var SanPham = SanPhamServices.sanpham.Where(g => g.ID == MaSanPham).FirstOrDefault();
                var item = KhachHangaaa.Where(g => g.MaNguoiDung == info.IDNguoiDung).FirstOrDefault();
                if (item == null)
                {
                    response.Result = "Lỗi";
                    response.ResponseCode = 401;
                }
                else
                {
                    var GioHangCustomer = GioHangaa.Where(g => g.MaKhacHang == item.MaNguoiDung).FirstOrDefault();
                    int IDGioHang = -1;
                    if (GioHangCustomer == null)
                    {
                        var MaxIDGioHang = GioHangaa.OrderByDescending(g => g.ID).Select(g => g.ID).FirstOrDefault();
                        MaxIDGioHang++;
                        GioHang gioHang = new GioHang()
                        {
                            ID = MaxIDGioHang,
                            MaKhacHang = info.IDNguoiDung
                        };
                        GioHangaa.Add(gioHang);
                        IDGioHang = gioHang.ID;
                    }
                    else
                    {
                        IDGioHang = GioHangCustomer.ID;
                        var Checked = CTGH.Where(g => g.MaGioHang == IDGioHang).ToList();
                        if(Checked.Count > 0)
                        {
                            foreach (var check in Checked)
                            {
                                if (check.MaSanPham.Trim() == MaSanPham)
                                {
                                    check.SoLuong += info.SoLuong;
                                    response.ResponseCode = 201;
                                    response.Result = "Thêm sản phẩm vào giỏ hàng thành công";
                                    return response;
                                }
                            }
                        }                     
                    }                           
                    var MaxIDCTGH = CTGH.OrderByDescending(g => g.MaCTGH).Select(g => g.MaCTGH).FirstOrDefault();
                    MaxIDCTGH++;
                    ChiTietGioHang ctgh = new ChiTietGioHang()
                    {
                        MaCTGH = MaxIDCTGH,
                        MaGioHang = IDGioHang,
                        MaSanPham = MaSanPham,
                        MaCombo = null,
                        SoLuong = info.SoLuong,
                        Gia = SanPham.DonGia,
                        ThanhTien = info.SoLuong * SanPham.DonGia
                    };
                    CTGH.Add(ctgh);
                    response.ResponseCode = 201;
                    response.Result = "Thêm vào giỏ hàng thành công";
                }
            }
            catch (Exception ex)
            {
                response.ResponseCode = 500;
                response.Result = $"Lỗi: {ex.Message}";
            }
            return response;
        }    
    }
}

