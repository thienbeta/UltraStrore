using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltraStrore.Migrations
{
    /// <inheritdoc />
    public partial class sdfsdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COM_BO_SAN_PHAM",
                columns: table => new
                {
                    ma_com_bo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_com_bo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    mo_ta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ten_hinh_anh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    so_luong = table.Column<int>(type: "int", nullable: true),
                    tong_gia = table.Column<double>(type: "float", nullable: true),
                    trang_thai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__COM_BO_S__AF6434A35D0F47EB", x => x.ma_com_bo);
                });

            migrationBuilder.CreateTable(
                name: "LOAI_SAN_PHAM",
                columns: table => new
                {
                    ma_loai_san_pham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_loai_san_pham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LOAI_SAN__7FEA3693092D4574", x => x.ma_loai_san_pham);
                });

            migrationBuilder.CreateTable(
                name: "NGUOI_DUNG",
                columns: table => new
                {
                    ma_nguoi_dung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ho_ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ngay_sinh = table.Column<DateTime>(type: "date", nullable: true),
                    sdt = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    cccd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dia_chi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    mat_khau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trang_thai = table.Column<int>(type: "int", nullable: true),
                    hinh_anh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ngay_tao = table.Column<DateTime>(type: "date", nullable: true),
                    mo_ta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NGUOI_DU__19C32CF72B9CA41E", x => x.ma_nguoi_dung);
                });

            migrationBuilder.CreateTable(
                name: "THUONG_HIEU",
                columns: table => new
                {
                    ma_thuong_hieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_thuong_hieu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__THUONG_H__C4FB3F32AE837BB2", x => x.ma_thuong_hieu);
                });

            migrationBuilder.CreateTable(
                name: "VOUCHER",
                columns: table => new
                {
                    ma_voucher = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ten_voucher = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    giam_gia = table.Column<double>(type: "float", nullable: true),
                    mo_ta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ngay_bat_dau = table.Column<DateTime>(type: "date", nullable: true),
                    ngay_ket_thuc = table.Column<DateTime>(type: "date", nullable: true),
                    dieu_kien = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    so_luong = table.Column<int>(type: "int", nullable: true),
                    trang_thai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VOUCHER__466D17BE6217DC60", x => x.ma_voucher);
                });

            migrationBuilder.CreateTable(
                name: "CHI_TIET_DON_HANG",
                columns: table => new
                {
                    ma_ctdh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma_don_hang = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ma_san_pham = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    so_luong = table.Column<int>(type: "int", nullable: true),
                    gia = table.Column<int>(type: "int", nullable: true),
                    thanh_tien = table.Column<int>(type: "int", nullable: true),
                    ma_combo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHI_TIET__5AE49D8E95395895", x => x.ma_ctdh);
                    table.ForeignKey(
                        name: "FK_CHI_TIET_DON_HANG_COM_BO_SAN_PHAM",
                        column: x => x.ma_combo,
                        principalTable: "COM_BO_SAN_PHAM",
                        principalColumn: "ma_com_bo");
                });

            migrationBuilder.CreateTable(
                name: "DANH_SACH_DIA_CHI",
                columns: table => new
                {
                    ma_dia_chi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma_nguoi_dung = table.Column<int>(type: "int", nullable: true),
                    ho_ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    sdt = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    mo_ta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    dia_chi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    trang_thai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DANH_SAC__80439859B4824340", x => x.ma_dia_chi);
                    table.ForeignKey(
                        name: "FK_DANH_SACH_DIA_CHI_NGUOI_DUNG",
                        column: x => x.ma_nguoi_dung,
                        principalTable: "NGUOI_DUNG",
                        principalColumn: "ma_nguoi_dung");
                });

            migrationBuilder.CreateTable(
                name: "DON_HANG",
                columns: table => new
                {
                    ma_don_hang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma_nguoi_dung = table.Column<int>(type: "int", nullable: true),
                    ma_nhan_vien = table.Column<int>(type: "int", nullable: true),
                    ngay_dat = table.Column<DateTime>(type: "date", nullable: true),
                    trang_thai_don_hang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    trang_thai_hang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ly_do_huy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ten_nguoi_nhan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    sdt = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    dia_chi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DON_HANG__0246C5EAB291F99F", x => x.ma_don_hang);
                    table.ForeignKey(
                        name: "FK_DON_HANG_NGUOI_DUNG1",
                        column: x => x.ma_nguoi_dung,
                        principalTable: "NGUOI_DUNG",
                        principalColumn: "ma_nguoi_dung");
                    table.ForeignKey(
                        name: "FK_DON_HANG_NGUOI_DUNG2",
                        column: x => x.ma_nhan_vien,
                        principalTable: "NGUOI_DUNG",
                        principalColumn: "ma_nguoi_dung");
                });

            migrationBuilder.CreateTable(
                name: "GIO_HANG",
                columns: table => new
                {
                    ma_gio_hang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma_nguoi_dung = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIO_HANG__6C00DDA3D3ED86DE", x => x.ma_gio_hang);
                    table.ForeignKey(
                        name: "FK_GIO_HANG_NGUOI_DUNG",
                        column: x => x.ma_nguoi_dung,
                        principalTable: "NGUOI_DUNG",
                        principalColumn: "ma_nguoi_dung");
                });

            migrationBuilder.CreateTable(
                name: "SAN_PHAM",
                columns: table => new
                {
                    ma_san_pham = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ten_san_pham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    so_luong = table.Column<int>(type: "int", nullable: true),
                    gia = table.Column<int>(type: "int", nullable: true),
                    ma_com_bo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ma_thuong_hieu = table.Column<int>(type: "int", nullable: true),
                    ma_loai_san_pham = table.Column<int>(type: "int", nullable: true),
                    kich_thuoc = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ngay_tao = table.Column<DateTime>(type: "date", nullable: true),
                    chat_lieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mo_ta = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    trang_thai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SAN_PHAM__9D25990C2713A687", x => x.ma_san_pham);
                    table.ForeignKey(
                        name: "FK_SAN_PHAM_LOAI_SAN_PHAM",
                        column: x => x.ma_loai_san_pham,
                        principalTable: "LOAI_SAN_PHAM",
                        principalColumn: "ma_loai_san_pham");
                    table.ForeignKey(
                        name: "FK_SAN_PHAM_THUONG_HIEU",
                        column: x => x.ma_thuong_hieu,
                        principalTable: "THUONG_HIEU",
                        principalColumn: "ma_thuong_hieu");
                });

            migrationBuilder.CreateTable(
                name: "BINH_LUAN",
                columns: table => new
                {
                    ma_binh_luan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma_san_pham = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ma_nguoi_dung = table.Column<int>(type: "int", unicode: false, maxLength: 10, nullable: true),
                    noi_dung_binh_luan = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    so_tim_binh_luan = table.Column<int>(type: "int", nullable: true),
                    danh_gia = table.Column<double>(type: "float", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BINH_LUA__300DD2D899CEB418", x => x.ma_binh_luan);
                    table.ForeignKey(
                        name: "FK_BINH_LUAN_SAN_PHAM",
                        column: x => x.ma_san_pham,
                        principalTable: "SAN_PHAM",
                        principalColumn: "ma_san_pham");
                });

            migrationBuilder.CreateTable(
                name: "CHI_TIET_COM_BO",
                columns: table => new
                {
                    ma_chi_tiet_com_bo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma_com_bo = table.Column<int>(type: "int", nullable: true),
                    ma_san_pham = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    so_luong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHI_TIET__1B885A91D07009B0", x => x.ma_chi_tiet_com_bo);
                    table.ForeignKey(
                        name: "FK_CHI_TIET_COM_BO_COM_BO_SAN_PHAM",
                        column: x => x.ma_com_bo,
                        principalTable: "COM_BO_SAN_PHAM",
                        principalColumn: "ma_com_bo");
                    table.ForeignKey(
                        name: "FK_CHI_TIET_COM_BO_SAN_PHAM",
                        column: x => x.ma_san_pham,
                        principalTable: "SAN_PHAM",
                        principalColumn: "ma_san_pham");
                });

            migrationBuilder.CreateTable(
                name: "CHI_TIET_GIO_HANG",
                columns: table => new
                {
                    ma_ctgh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma_gio_hang = table.Column<int>(type: "int", nullable: true),
                    ma_san_pham = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    so_luong = table.Column<int>(type: "int", nullable: true),
                    ma_combo = table.Column<int>(type: "int", nullable: true),
                    gia = table.Column<int>(type: "int", nullable: true),
                    thanh_tien = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHI_TIET__5AE495EDA6F2A925", x => x.ma_ctgh);
                    table.ForeignKey(
                        name: "FK_CHI_TIET_GIO_HANG_COM_BO_SAN_PHAM",
                        column: x => x.ma_combo,
                        principalTable: "COM_BO_SAN_PHAM",
                        principalColumn: "ma_com_bo");
                    table.ForeignKey(
                        name: "FK_CHI_TIET_GIO_HANG_GIO_HANG",
                        column: x => x.ma_gio_hang,
                        principalTable: "GIO_HANG",
                        principalColumn: "ma_gio_hang");
                    table.ForeignKey(
                        name: "FK_CHI_TIET_GIO_HANG_SAN_PHAM",
                        column: x => x.ma_san_pham,
                        principalTable: "SAN_PHAM",
                        principalColumn: "ma_san_pham");
                });

            migrationBuilder.CreateTable(
                name: "VIDEO",
                columns: table => new
                {
                    ma_video = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_video = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ma_san_pham = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VIDEO__946AD5B8DC15860F", x => x.ma_video);
                    table.ForeignKey(
                        name: "FK_VIDEO_SAN_PHAM",
                        column: x => x.ma_san_pham,
                        principalTable: "SAN_PHAM",
                        principalColumn: "ma_san_pham");
                });

            migrationBuilder.CreateTable(
                name: "YEU_THICH",
                columns: table => new
                {
                    ma_yeu_thich = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma_san_pham = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ma_nguoi_dung = table.Column<int>(type: "int", nullable: true),
                    so_luong_yeu_thich = table.Column<int>(type: "int", nullable: true),
                    ngay_yeu_thich = table.Column<DateTime>(type: "date", nullable: true),
                    MaNguoiDungNavigationMaNguoiDung = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__YEU_THIC__6427C4C6C61640D4", x => x.ma_yeu_thich);
                    table.ForeignKey(
                        name: "FK_YEU_THICH_NGUOI_DUNG_MaNguoiDungNavigationMaNguoiDung",
                        column: x => x.MaNguoiDungNavigationMaNguoiDung,
                        principalTable: "NGUOI_DUNG",
                        principalColumn: "ma_nguoi_dung");
                    table.ForeignKey(
                        name: "FK_YEU_THICH_SAN_PHAM",
                        column: x => x.ma_san_pham,
                        principalTable: "SAN_PHAM",
                        principalColumn: "ma_san_pham");
                });

            migrationBuilder.CreateTable(
                name: "HINH_ANH",
                columns: table => new
                {
                    ma_hinh_anh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_hinh_anh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ma_san_pham = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ma_binh_luan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HINH_ANH__5AE49D8E2E189F36", x => x.ma_hinh_anh);
                    table.ForeignKey(
                        name: "FK_HINH_ANH_BINH_LUAN",
                        column: x => x.ma_binh_luan,
                        principalTable: "BINH_LUAN",
                        principalColumn: "ma_binh_luan");
                    table.ForeignKey(
                        name: "FK_HINH_ANH_SAN_PHAM",
                        column: x => x.ma_san_pham,
                        principalTable: "SAN_PHAM",
                        principalColumn: "ma_san_pham");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BINH_LUAN_ma_san_pham",
                table: "BINH_LUAN",
                column: "ma_san_pham");

            migrationBuilder.CreateIndex(
                name: "IX_CHI_TIET_COM_BO_ma_com_bo",
                table: "CHI_TIET_COM_BO",
                column: "ma_com_bo");

            migrationBuilder.CreateIndex(
                name: "IX_CHI_TIET_COM_BO_ma_san_pham",
                table: "CHI_TIET_COM_BO",
                column: "ma_san_pham");

            migrationBuilder.CreateIndex(
                name: "IX_CHI_TIET_DON_HANG_ma_combo",
                table: "CHI_TIET_DON_HANG",
                column: "ma_combo");

            migrationBuilder.CreateIndex(
                name: "IX_CHI_TIET_GIO_HANG_ma_combo",
                table: "CHI_TIET_GIO_HANG",
                column: "ma_combo");

            migrationBuilder.CreateIndex(
                name: "IX_CHI_TIET_GIO_HANG_ma_gio_hang",
                table: "CHI_TIET_GIO_HANG",
                column: "ma_gio_hang");

            migrationBuilder.CreateIndex(
                name: "IX_CHI_TIET_GIO_HANG_ma_san_pham",
                table: "CHI_TIET_GIO_HANG",
                column: "ma_san_pham");

            migrationBuilder.CreateIndex(
                name: "IX_DANH_SACH_DIA_CHI_ma_nguoi_dung",
                table: "DANH_SACH_DIA_CHI",
                column: "ma_nguoi_dung");

            migrationBuilder.CreateIndex(
                name: "IX_DON_HANG_ma_nguoi_dung",
                table: "DON_HANG",
                column: "ma_nguoi_dung");

            migrationBuilder.CreateIndex(
                name: "IX_DON_HANG_ma_nhan_vien",
                table: "DON_HANG",
                column: "ma_nhan_vien");

            migrationBuilder.CreateIndex(
                name: "IX_GIO_HANG_ma_nguoi_dung",
                table: "GIO_HANG",
                column: "ma_nguoi_dung");

            migrationBuilder.CreateIndex(
                name: "IX_HINH_ANH_ma_binh_luan",
                table: "HINH_ANH",
                column: "ma_binh_luan");

            migrationBuilder.CreateIndex(
                name: "IX_HINH_ANH_ma_san_pham",
                table: "HINH_ANH",
                column: "ma_san_pham");

            migrationBuilder.CreateIndex(
                name: "IX_SAN_PHAM_ma_loai_san_pham",
                table: "SAN_PHAM",
                column: "ma_loai_san_pham");

            migrationBuilder.CreateIndex(
                name: "IX_SAN_PHAM_ma_thuong_hieu",
                table: "SAN_PHAM",
                column: "ma_thuong_hieu");

            migrationBuilder.CreateIndex(
                name: "IX_VIDEO_ma_san_pham",
                table: "VIDEO",
                column: "ma_san_pham");

            migrationBuilder.CreateIndex(
                name: "IX_YEU_THICH_ma_san_pham",
                table: "YEU_THICH",
                column: "ma_san_pham");

            migrationBuilder.CreateIndex(
                name: "IX_YEU_THICH_MaNguoiDungNavigationMaNguoiDung",
                table: "YEU_THICH",
                column: "MaNguoiDungNavigationMaNguoiDung");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHI_TIET_COM_BO");

            migrationBuilder.DropTable(
                name: "CHI_TIET_DON_HANG");

            migrationBuilder.DropTable(
                name: "CHI_TIET_GIO_HANG");

            migrationBuilder.DropTable(
                name: "DANH_SACH_DIA_CHI");

            migrationBuilder.DropTable(
                name: "DON_HANG");

            migrationBuilder.DropTable(
                name: "HINH_ANH");

            migrationBuilder.DropTable(
                name: "VIDEO");

            migrationBuilder.DropTable(
                name: "VOUCHER");

            migrationBuilder.DropTable(
                name: "YEU_THICH");

            migrationBuilder.DropTable(
                name: "COM_BO_SAN_PHAM");

            migrationBuilder.DropTable(
                name: "GIO_HANG");

            migrationBuilder.DropTable(
                name: "BINH_LUAN");

            migrationBuilder.DropTable(
                name: "NGUOI_DUNG");

            migrationBuilder.DropTable(
                name: "SAN_PHAM");

            migrationBuilder.DropTable(
                name: "LOAI_SAN_PHAM");

            migrationBuilder.DropTable(
                name: "THUONG_HIEU");
        }
    }
}
