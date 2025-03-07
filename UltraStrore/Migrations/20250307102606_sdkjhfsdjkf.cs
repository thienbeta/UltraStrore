using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltraStrore.Migrations
{
    /// <inheritdoc />
    public partial class sdkjhfsdjkf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VaiTro",
                table: "NGUOI_DUNG",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VaiTro",
                table: "NGUOI_DUNG");
        }
    }
}
