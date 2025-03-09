using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltraStrore.Migrations
{
    /// <inheritdoc />
    public partial class sdhjksdfhjksdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NgayBinhLuan",
                table: "BINH_LUAN",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayBinhLuan",
                table: "BINH_LUAN");
        }
    }
}
