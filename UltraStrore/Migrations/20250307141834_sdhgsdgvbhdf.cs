using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltraStrore.Migrations
{
    /// <inheritdoc />
    public partial class sdhgsdgvbhdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CancelConunt",
                table: "NGUOI_DUNG",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LockoutEndDate",
                table: "NGUOI_DUNG",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelConunt",
                table: "NGUOI_DUNG");

            migrationBuilder.DropColumn(
                name: "LockoutEndDate",
                table: "NGUOI_DUNG");
        }
    }
}
