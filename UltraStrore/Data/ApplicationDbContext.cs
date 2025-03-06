using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UltraStrore.Data.Temp;

namespace UltraStrore.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public virtual DbSet<BinhLuan> BinhLuans { get; set; }

    public virtual DbSet<ChiTietComBo> ChiTietComBos { get; set; }

    public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

    public virtual DbSet<ChiTietGioHang> ChiTietGioHangs { get; set; }

    public virtual DbSet<ComBoSanPham> ComBoSanPhams { get; set; }

    public virtual DbSet<DanhSachDiaChi> DanhSachDiaChis { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<GioHang> GioHangs { get; set; }

    public virtual DbSet<HinhAnh> HinhAnhs { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }

    public virtual DbSet<Video> Videos { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<YeuThich> YeuThiches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=C6;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BinhLuan>(entity =>
        {
            entity.HasKey(e => e.MaBinhLuan).HasName("PK__BINH_LUA__300DD2D899CEB418");

            entity.ToTable("BINH_LUAN");

            entity.HasIndex(e => e.MaSanPham, "IX_BINH_LUAN_ma_san_pham");

            entity.Property(e => e.MaBinhLuan).HasColumnName("ma_binh_luan");
            entity.Property(e => e.DanhGia).HasColumnName("danh_gia");
            entity.Property(e => e.MaNguoiDung)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ma_nguoi_dung");
            entity.Property(e => e.MaSanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_san_pham");
            entity.Property(e => e.NoiDungBinhLuan)
                .HasMaxLength(255)
                .HasColumnName("noi_dung_binh_luan");
            entity.Property(e => e.SoBinhLuan).HasColumnName("so_binh_luan");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.BinhLuans)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK_BINH_LUAN_SAN_PHAM");
        });

        modelBuilder.Entity<ChiTietComBo>(entity =>
        {
            entity.HasKey(e => e.MaChiTietComBo).HasName("PK__CHI_TIET__1B885A91D07009B0");

            entity.ToTable("CHI_TIET_COM_BO");

            entity.HasIndex(e => e.MaComBo, "IX_CHI_TIET_COM_BO_ma_com_bo");

            entity.Property(e => e.MaChiTietComBo).HasColumnName("ma_chi_tiet_com_bo");
            entity.Property(e => e.MaComBo).HasColumnName("ma_com_bo");
            entity.Property(e => e.MaSanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_san_pham");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");

            entity.HasOne(d => d.MaComBoNavigation).WithMany(p => p.ChiTietComBos)
                .HasForeignKey(d => d.MaComBo)
                .HasConstraintName("FK_CHI_TIET_COM_BO_COM_BO_SAN_PHAM");
        });

        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
            entity.HasKey(e => e.MaCtdh).HasName("PK__CHI_TIET__5AE49D8E95395895");

            entity.ToTable("CHI_TIET_DON_HANG");

            entity.HasIndex(e => e.MaCombo, "IX_CHI_TIET_DON_HANG_ma_combo");

            entity.HasIndex(e => e.MaSanPham, "IX_CHI_TIET_DON_HANG_ma_san_pham");

            entity.Property(e => e.MaCtdh).HasColumnName("ma_ctdh");
            entity.Property(e => e.Gia).HasColumnName("gia");
            entity.Property(e => e.MaCombo).HasColumnName("ma_combo");
            entity.Property(e => e.MaDonHang)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ma_don_hang");
            entity.Property(e => e.MaSanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_san_pham");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");
            entity.Property(e => e.ThanhTien).HasColumnName("thanh_tien");

            entity.HasOne(d => d.MaComboNavigation).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.MaCombo)
                .HasConstraintName("FK_CHI_TIET_DON_HANG_COM_BO_SAN_PHAM");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK_CHI_TIET_DON_HANG_SAN_PHAM");
        });

        modelBuilder.Entity<ChiTietGioHang>(entity =>
        {
            entity.HasKey(e => e.MaCtgh).HasName("PK__CHI_TIET__5AE495EDA6F2A925");

            entity.ToTable("CHI_TIET_GIO_HANG");

            entity.HasIndex(e => e.MaGioHang, "IX_CHI_TIET_GIO_HANG_ma_gio_hang");

            entity.Property(e => e.MaCtgh).HasColumnName("ma_ctgh");
            entity.Property(e => e.Gia).HasColumnName("gia");
            entity.Property(e => e.MaCombo).HasColumnName("ma_combo");
            entity.Property(e => e.MaGioHang).HasColumnName("ma_gio_hang");
            entity.Property(e => e.MaSanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_san_pham");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");
            entity.Property(e => e.ThanhTien).HasColumnName("thanh_tien");

            entity.HasOne(d => d.MaComboNavigation).WithMany(p => p.ChiTietGioHangs)
                .HasForeignKey(d => d.MaCombo)
                .HasConstraintName("FK_CHI_TIET_GIO_HANG_COM_BO_SAN_PHAM");

            entity.HasOne(d => d.MaGioHangNavigation).WithMany(p => p.ChiTietGioHangs)
                .HasForeignKey(d => d.MaGioHang)
                .HasConstraintName("FK_CHI_TIET_GIO_HANG_GIO_HANG");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietGioHangs)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK_CHI_TIET_GIO_HANG_SAN_PHAM");
        });

        modelBuilder.Entity<ComBoSanPham>(entity =>
        {
            entity.HasKey(e => e.MaComBo).HasName("PK__COM_BO_S__AF6434A35D0F47EB");

            entity.ToTable("COM_BO_SAN_PHAM");

            entity.Property(e => e.MaComBo)
                .ValueGeneratedOnAdd()
                .HasColumnName("ma_com_bo");
            entity.Property(e => e.MoTa)
                .HasMaxLength(255)
                .HasColumnName("mo_ta");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");
            entity.Property(e => e.TenComBo)
                .HasMaxLength(100)
                .HasColumnName("ten_com_bo");
            entity.Property(e => e.TenHinhAnh)
                .HasMaxLength(100)
                .HasColumnName("ten_hinh_anh");
            entity.Property(e => e.TongGia).HasColumnName("tong_gia");
            entity.Property(e => e.TrangThai).HasColumnName("trang_thai");
        });

        modelBuilder.Entity<DanhSachDiaChi>(entity =>
        {
            entity.HasKey(e => e.MaDiaChi).HasName("PK__DANH_SAC__80439859B4824340");

            entity.ToTable("DANH_SACH_DIA_CHI");

            entity.HasIndex(e => e.MaNguoiDung, "IX_DANH_SACH_DIA_CHI_ma_nguoi_dung");

            entity.Property(e => e.MaDiaChi).HasColumnName("ma_dia_chi");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasColumnName("dia_chi");
            entity.Property(e => e.HoTen)
                .HasMaxLength(100)
                .HasColumnName("ho_ten");
            entity.Property(e => e.MaNguoiDung)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ma_nguoi_dung");
            entity.Property(e => e.MoTa)
                .HasMaxLength(255)
                .HasColumnName("mo_ta");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .HasColumnName("sdt");
            entity.Property(e => e.TrangThai).HasColumnName("trang_thai");

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.DanhSachDiaChis)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK_DANH_SACH_DIA_CHI_NGUOI_DUNG");
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.MaDonHang).HasName("PK__DON_HANG__0246C5EAB291F99F");

            entity.ToTable("DON_HANG");

            entity.HasIndex(e => e.MaNguoiDung, "IX_DON_HANG_ma_nguoi_dung");

            entity.HasIndex(e => e.MaNhanVien, "IX_DON_HANG_ma_nhan_vien");

            entity.Property(e => e.MaDonHang).HasColumnName("ma_don_hang");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasColumnName("dia_chi");
            entity.Property(e => e.LyDoHuy)
                .HasMaxLength(255)
                .HasColumnName("ly_do_huy");
            entity.Property(e => e.MaNguoiDung)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ma_nguoi_dung");
            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ma_nhan_vien");
            entity.Property(e => e.NgayDat).HasColumnName("ngay_dat");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .HasColumnName("sdt");
            entity.Property(e => e.TenNguoiNhan)
                .HasMaxLength(100)
                .HasColumnName("ten_nguoi_nhan");
            entity.Property(e => e.TrangThaiDonHang)
                .HasMaxLength(50)
                .HasColumnName("trang_thai_don_hang");
            entity.Property(e => e.TrangThaiHang)
                .HasMaxLength(50)
                .HasColumnName("trang_thai_hang");

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK_DON_HANG_NGUOI_DUNG");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.MaNhanVien)
                .HasConstraintName("FK_DON_HANG_NHAN_VIEN");
        });

        modelBuilder.Entity<GioHang>(entity =>
        {
            entity.HasKey(e => e.MaGioHang).HasName("PK__GIO_HANG__6C00DDA3D3ED86DE");

            entity.ToTable("GIO_HANG");

            entity.HasIndex(e => e.MaNguoiDung, "IX_GIO_HANG_ma_nguoi_dung");

            entity.Property(e => e.MaGioHang).HasColumnName("ma_gio_hang");
            entity.Property(e => e.MaNguoiDung)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ma_nguoi_dung");

            entity.HasOne(d => d.MaNguoiDungNavigation).WithMany(p => p.GioHangs)
                .HasForeignKey(d => d.MaNguoiDung)
                .HasConstraintName("FK_GIO_HANG_NGUOI_DUNG");
        });

        modelBuilder.Entity<HinhAnh>(entity =>
        {
            entity.HasKey(e => e.MaHinhAnh).HasName("PK__HINH_ANH__5AE49D8E2E189F36");

            entity.ToTable("HINH_ANH");

            entity.HasIndex(e => e.MaBinhLuan, "IX_HINH_ANH_ma_binh_luan");

            entity.HasIndex(e => e.MaSanPham, "IX_HINH_ANH_ma_san_pham");

            entity.Property(e => e.MaHinhAnh).HasColumnName("ma_hinh_anh");
            entity.Property(e => e.MaBinhLuan).HasColumnName("ma_binh_luan");
            entity.Property(e => e.MaSanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_san_pham");
            entity.Property(e => e.TenHinhAnh)
                .HasMaxLength(100)
                .HasColumnName("ten_hinh_anh");

            entity.HasOne(d => d.MaBinhLuanNavigation).WithMany(p => p.HinhAnhs)
                .HasForeignKey(d => d.MaBinhLuan)
                .HasConstraintName("FK_HINH_ANH_BINH_LUAN");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.HinhAnhs)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK_HINH_ANH_SAN_PHAM");
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.MaLoaiSanPham).HasName("PK__LOAI_SAN__7FEA3693092D4574");

            entity.ToTable("LOAI_SAN_PHAM");

            entity.Property(e => e.MaLoaiSanPham).HasColumnName("ma_loai_san_pham");
            entity.Property(e => e.TenLoaiSanPham)
                .HasMaxLength(100)
                .HasColumnName("ten_loai_san_pham");
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.MaNguoiDung).HasName("PK__NGUOI_DU__19C32CF72B9CA41E");

            entity.ToTable("NGUOI_DUNG");

            entity.Property(e => e.MaNguoiDung)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ma_nguoi_dung");
            entity.Property(e => e.Cccd)
                .HasMaxLength(20)
                .HasColumnName("cccd");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasColumnName("dia_chi");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.HinhAnh)
                .HasMaxLength(100)
                .HasColumnName("hinh_anh");
            entity.Property(e => e.HoTen)
                .HasMaxLength(100)
                .HasColumnName("ho_ten");
            entity.Property(e => e.MoTa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("mo_ta");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(255)
                .HasColumnName("mat_khau");
            entity.Property(e => e.TaiKhoan)
            .HasMaxLength(50).HasColumnName("tai_khoan");
            entity.Property(e => e.NgayDangKy).HasColumnName("ngay_dang_ky");
            entity.Property(e => e.NgaySinh).HasColumnName("ngay_sinh");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .HasColumnName("sdt");
            entity.Property(e => e.TrangThai).HasColumnName("trang_thai");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NHAN_VIE__6781B7B911E58FF4");

            entity.ToTable("NHAN_VIEN");

            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ma_nhan_vien");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasColumnName("dia_chi");
            entity.Property(e => e.MaLa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ma_la");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .HasColumnName("sdt");
            entity.Property(e => e.TenNhanVien)
                .HasMaxLength(100)
                .HasColumnName("ten_nhan_vien");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSanPham).HasName("PK__SAN_PHAM__9D25990C2713A687");

            entity.ToTable("SAN_PHAM");

            entity.HasIndex(e => e.MaLoaiSanPham, "IX_SAN_PHAM_ma_loai_san_pham");

            entity.HasIndex(e => e.MaThuongHieu, "IX_SAN_PHAM_ma_thuong_hieu");

            entity.Property(e => e.MaSanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_san_pham");
            entity.Property(e => e.Example).HasColumnName("example");
            entity.Property(e => e.Gia).HasColumnName("gia");
            entity.Property(e => e.KichThuoc)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("kich_thuoc");
            entity.Property(e => e.MaComBo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ma_com_bo");
            entity.Property(e => e.MaLoaiSanPham).HasColumnName("ma_loai_san_pham");
            entity.Property(e => e.MaThuongHieu).HasColumnName("ma_thuong_hieu");
            entity.Property(e => e.MoTa)
                .HasMaxLength(150)
                .HasColumnName("mo_ta");
            entity.Property(e => e.NgayTao).HasColumnName("ngay_tao");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");
            entity.Property(e => e.TenSanPham)
                .HasMaxLength(100)
                .HasColumnName("ten_san_pham");

            entity.HasOne(d => d.MaLoaiSanPhamNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLoaiSanPham)
                .HasConstraintName("FK_SAN_PHAM_LOAI_SAN_PHAM");

            entity.HasOne(d => d.MaThuongHieuNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaThuongHieu)
                .HasConstraintName("FK_SAN_PHAM_THUONG_HIEU");
        });

        modelBuilder.Entity<ThuongHieu>(entity =>
        {
            entity.HasKey(e => e.MaThuongHieu).HasName("PK__THUONG_H__C4FB3F32AE837BB2");

            entity.ToTable("THUONG_HIEU");

            entity.Property(e => e.MaThuongHieu).HasColumnName("ma_thuong_hieu");
            entity.Property(e => e.TenThuongHieu)
                .HasMaxLength(100)
                .HasColumnName("ten_thuong_hieu");
        });

        modelBuilder.Entity<Video>(entity =>
        {
            entity.HasKey(e => e.MaVideo).HasName("PK__VIDEO__946AD5B8DC15860F");

            entity.ToTable("VIDEO");

            entity.HasIndex(e => e.MaSanPham, "IX_VIDEO_ma_san_pham");

            entity.Property(e => e.MaVideo).HasColumnName("ma_video");
            entity.Property(e => e.MaSanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_san_pham");
            entity.Property(e => e.TenVideo)
                .HasMaxLength(100)
                .HasColumnName("ten_video");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.Videos)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK_VIDEO_SAN_PHAM");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.MaVoucher).HasName("PK__VOUCHER__466D17BE6217DC60");

            entity.ToTable("VOUCHER");

            entity.Property(e => e.MaVoucher)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ma_voucher");
            entity.Property(e => e.DieuKien)
                .HasMaxLength(255)
                .HasColumnName("dieu_kien");
            entity.Property(e => e.GiamGia).HasColumnName("giam_gia");
            entity.Property(e => e.MoTa)
                .HasMaxLength(255)
                .HasColumnName("mo_ta");
            entity.Property(e => e.NgayBatDau).HasColumnName("ngay_bat_dau");
            entity.Property(e => e.NgayKetThuc).HasColumnName("ngay_ket_thuc");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");
            entity.Property(e => e.TenVoucher)
                .HasMaxLength(100)
                .HasColumnName("ten_voucher");
            entity.Property(e => e.TrangThai).HasColumnName("trang_thai");
        });

        modelBuilder.Entity<YeuThich>(entity =>
        {
            entity.HasKey(e => e.MaYeuThich).HasName("PK__YEU_THIC__6427C4C6C61640D4");

            entity.ToTable("YEU_THICH");

            entity.HasIndex(e => e.MaSanPham, "IX_YEU_THICH_ma_san_pham");

            entity.Property(e => e.MaYeuThich).HasColumnName("ma_yeu_thich");
            entity.Property(e => e.MaNguoiDung)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ma_nguoi_dung");
            entity.Property(e => e.MaSanPham)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ma_san_pham");
            entity.Property(e => e.NgayYeuThich).HasColumnName("ngay_yeu_thich");
            entity.Property(e => e.SoLuongYeuThich).HasColumnName("so_luong_yeu_thich");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.YeuThiches)
                .HasForeignKey(d => d.MaSanPham)
                .HasConstraintName("FK_YEU_THICH_SAN_PHAM");
        });
        modelBuilder.Entity<ThuongHieu>().HasData(
            new ThuongHieu
            {
                MaThuongHieu = 1,
                TenThuongHieu = "Gucci"
            }
            );
        modelBuilder.Entity<LoaiSanPham>().HasData(
            new LoaiSanPham
            {
                MaLoaiSanPham = 1,
                TenLoaiSanPham = "Áo"
            });
        modelBuilder.Entity<SanPham>().HasData(
           new SanPham
           {
               MaSanPham = "A00001_ff0000_XL",
               TenSanPham = "Áo thun nam",
               MaThuongHieu = 1,
               MaLoaiSanPham = 1,
               KichThuoc = "XL",
               SoLuong = 100,
               Gia = 150000,
               NgayTao = DateOnly.FromDateTime(DateTime.Now),
               TrangThai = 1,
               Example = true,
           },
            new SanPham
            {
                MaSanPham = "A00001_ff0000_XXL",
                TenSanPham = "Áo thun nam",
                MaThuongHieu = 1,
                MaLoaiSanPham = 1,
                KichThuoc = "XL",
                SoLuong = 100,
                Gia = 150000,
                NgayTao = DateOnly.FromDateTime(DateTime.Now),
                TrangThai = 1,
                Example = true,
            },
             new SanPham
             {
                 MaSanPham = "A00001_ff0000_M",
                 TenSanPham = "Áo thun nam",
                 MaThuongHieu = 1,
                 MaLoaiSanPham = 1,
                 KichThuoc = "XL",
                 SoLuong = 100,
                 Gia = 150000,
                 NgayTao = DateOnly.FromDateTime(DateTime.Now),
                 TrangThai = 1,
                 Example = true,
             },
              new SanPham
              {
                  MaSanPham = "A00001_ff00ff_XL",
                  TenSanPham = "Áo thun nam",
                  MaThuongHieu = 1,
                  MaLoaiSanPham = 1,
                  KichThuoc = "XL",
                  SoLuong = 100,
                  Gia = 150000,
                  NgayTao = DateOnly.FromDateTime(DateTime.Now),
                  TrangThai = 1,
                  Example = true,
              },
               new SanPham
               {
                   MaSanPham = "A00001_ff00ff_M",
                   TenSanPham = "Áo thun nam",
                   MaThuongHieu = 1,
                   MaLoaiSanPham = 1,
                   KichThuoc = "XL",
                   SoLuong = 100,
                   Gia = 150000,
                   NgayTao = DateOnly.FromDateTime(DateTime.Now),
                   TrangThai = 1,
                   Example = true,
               },
                new SanPham
                {
                    MaSanPham = "A00002_ff0000_XL",
                    TenSanPham = "Áo thun nam",
                    MaThuongHieu = 1,
                    MaLoaiSanPham = 1,
                    KichThuoc = "XL",
                    SoLuong = 100,
                    Gia = 150000,
                    NgayTao = DateOnly.FromDateTime(DateTime.Now),
                    TrangThai = 1,
                    Example = true,
                },
                 new SanPham
                 {
                     MaSanPham = "A00002_ff0000_XXL",
                     TenSanPham = "Áo thun nam",
                     MaThuongHieu = 1,
                     MaLoaiSanPham = 1,
                     KichThuoc = "XL",
                     SoLuong = 100,
                     Gia = 150000,
                     NgayTao = DateOnly.FromDateTime(DateTime.Now),
                     TrangThai = 1,
                     Example = true,
                 },
                  new SanPham
                  {
                      MaSanPham = "A00002_ff00ff_XL",
                      TenSanPham = "Áo thun nam",
                      MaThuongHieu = 1,
                      MaLoaiSanPham = 1,
                      KichThuoc = "XL",
                      SoLuong = 100,
                      Gia = 150000,
                      NgayTao = DateOnly.FromDateTime(DateTime.Now),
                      TrangThai = 1,
                      Example = true,
                  },
                  new SanPham
                  {
                      MaSanPham = "A00002_ff00ff_M",
                      TenSanPham = "Áo thun nam",
                      MaThuongHieu = 1,
                      MaLoaiSanPham = 1,
                      KichThuoc = "XL",
                      SoLuong = 100,
                      Gia = 150000,
                      NgayTao = DateOnly.FromDateTime(DateTime.Now),
                      TrangThai = 1,
                      Example = true,
                  }
            );
        modelBuilder.Entity<HinhAnh>().HasData(
             new HinhAnh
             {
                 MaHinhAnh = 1,
                 MaSanPham = "A00001_ff0000_XL",
                 Link = "https://media3.coolmate.me/cdn-cgi/image/quality=80,format=auto/uploads/June2024/33333.5.jpg"
             },
             new HinhAnh
             {
                 MaHinhAnh = 2,
                 MaSanPham = "A00002_ff0000_XL",
                 Link = "https://content.pancake.vn/2-23/s2550x3600/2023/12/14/98a33459624269938a7797823e29e9bb04979da5.jpg"
             }
            );
        modelBuilder.Entity<GioHang>().HasData(
              new GioHang
              {
                  MaGioHang = 1,
                  MaNguoiDung = "KH001"
              });
        modelBuilder.Entity<ChiTietGioHang>().HasData(
            new ChiTietGioHang 
            {
                MaCtgh = 1,
                MaGioHang = 1,
                MaSanPham = "A00001_ff00ff_XL",
                MaCombo = null,
                SoLuong = 2,
                Gia = 150000,
                ThanhTien = 300000,
            },
             new ChiTietGioHang
             {
                 MaCtgh = 2,
                 MaGioHang = 1,
                 MaSanPham = "A00002_ff00ff_XL",
                 MaCombo = null,
                 SoLuong = 3,
                 Gia = 150000,
                 ThanhTien = 450000,
             }
            );
        modelBuilder.Entity<NguoiDung>().HasData(
            new NguoiDung
            {
                MaNguoiDung="KH001",
                TaiKhoan="User",
                HoTen ="Embo",
                NgaySinh = new DateOnly(1999,5,19),
                Sdt ="0973713274",
                Cccd = "066099000137",
                Email = "nguyenquangquyX@gmail.com",
                DiaChi = "Here",
                TrangThai = true,
                HinhAnh = "https://safebooru.org//samples/3406/sample_a1935b4ae3f6684ef51e29de9fcbe0cabe608620.jpg?3543495",
                MatKhau = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                NgayDangKy = DateOnly.FromDateTime(DateTime.Now)
            });
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
