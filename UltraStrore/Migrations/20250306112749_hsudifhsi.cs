using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltraStrore.Migrations
{
    /// <inheritdoc />
    public partial class hsudifhsi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DON_HANG_NGUOI_DUNG",
                table: "DON_HANG");

            migrationBuilder.DropForeignKey(
                name: "FK_DON_HANG_NHAN_VIEN",
                table: "DON_HANG");

            migrationBuilder.DropTable(
                name: "NHAN_VIEN");

            migrationBuilder.DropColumn(
                name: "ma_la",
                table: "NGUOI_DUNG");

            migrationBuilder.RenameColumn(
                name: "example",
                table: "SAN_PHAM",
                newName: "chat_lieu");

            migrationBuilder.RenameColumn(
                name: "ngay_ky",
                table: "NGUOI_DUNG",
                newName: "ngay_tao");

            migrationBuilder.AlterColumn<int>(
                name: "trang_thai",
                table: "VOUCHER",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "dieu_kien",
                table: "VOUCHER",
                type: "decimal(18,0)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "trang_thai",
                table: "SAN_PHAM",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "trang_thai",
                table: "NGUOI_DUNG",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mo_ta",
                table: "NGUOI_DUNG",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CHI_TIET_GIO_HANG_ma_combo",
                table: "CHI_TIET_GIO_HANG",
                column: "ma_combo");

            migrationBuilder.CreateIndex(
                name: "IX_CHI_TIET_GIO_HANG_ma_san_pham",
                table: "CHI_TIET_GIO_HANG",
                column: "ma_san_pham");

            migrationBuilder.AddForeignKey(
                name: "FK_CHI_TIET_GIO_HANG_COM_BO_SAN_PHAM",
                table: "CHI_TIET_GIO_HANG",
                column: "ma_combo",
                principalTable: "COM_BO_SAN_PHAM",
                principalColumn: "ma_com_bo");

            migrationBuilder.AddForeignKey(
                name: "FK_CHI_TIET_GIO_HANG_SAN_PHAM",
                table: "CHI_TIET_GIO_HANG",
                column: "ma_san_pham",
                principalTable: "SAN_PHAM",
                principalColumn: "ma_san_pham");

            migrationBuilder.AddForeignKey(
                name: "FK_DON_HANG_NGUOI_DUNG1",
                table: "DON_HANG",
                column: "ma_nguoi_dung",
                principalTable: "NGUOI_DUNG",
                principalColumn: "ma_nguoi_dung");

            migrationBuilder.AddForeignKey(
                name: "FK_DON_HANG_NGUOI_DUNG2",
                table: "DON_HANG",
                column: "ma_nhan_vien",
                principalTable: "NGUOI_DUNG",
                principalColumn: "ma_nguoi_dung");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CHI_TIET_GIO_HANG_COM_BO_SAN_PHAM",
                table: "CHI_TIET_GIO_HANG");

            migrationBuilder.DropForeignKey(
                name: "FK_CHI_TIET_GIO_HANG_SAN_PHAM",
                table: "CHI_TIET_GIO_HANG");

            migrationBuilder.DropForeignKey(
                name: "FK_DON_HANG_NGUOI_DUNG1",
                table: "DON_HANG");

            migrationBuilder.DropForeignKey(
                name: "FK_DON_HANG_NGUOI_DUNG2",
                table: "DON_HANG");

            migrationBuilder.DropIndex(
                name: "IX_CHI_TIET_GIO_HANG_ma_combo",
                table: "CHI_TIET_GIO_HANG");

            migrationBuilder.DropIndex(
                name: "IX_CHI_TIET_GIO_HANG_ma_san_pham",
                table: "CHI_TIET_GIO_HANG");

            migrationBuilder.DropColumn(
                name: "trang_thai",
                table: "SAN_PHAM");

            migrationBuilder.DropColumn(
                name: "mo_ta",
                table: "NGUOI_DUNG");

            migrationBuilder.RenameColumn(
                name: "chat_lieu",
                table: "SAN_PHAM",
                newName: "example");

            migrationBuilder.RenameColumn(
                name: "ngay_tao",
                table: "NGUOI_DUNG",
                newName: "ngay_ky");

            migrationBuilder.AlterColumn<bool>(
                name: "trang_thai",
                table: "VOUCHER",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "dieu_kien",
                table: "VOUCHER",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "trang_thai",
                table: "NGUOI_DUNG",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ma_la",
                table: "NGUOI_DUNG",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NHAN_VIEN",
                columns: table => new
                {
                    ma_nhan_vien = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    dia_chi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ma_la = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sdt = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ten_nhan_vien = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NHAN_VIE__6781B7B911E58FF4", x => x.ma_nhan_vien);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DON_HANG_NGUOI_DUNG",
                table: "DON_HANG",
                column: "ma_nguoi_dung",
                principalTable: "NGUOI_DUNG",
                principalColumn: "ma_nguoi_dung");

            migrationBuilder.AddForeignKey(
                name: "FK_DON_HANG_NHAN_VIEN",
                table: "DON_HANG",
                column: "ma_nhan_vien",
                principalTable: "NHAN_VIEN",
                principalColumn: "ma_nhan_vien");
        }
    }
}
