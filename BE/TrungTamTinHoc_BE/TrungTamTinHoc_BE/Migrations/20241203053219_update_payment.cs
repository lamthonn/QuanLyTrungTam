using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrungTamTinHoc_BE.Migrations
{
    /// <inheritdoc />
    public partial class update_payment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KhoaHocId",
                table: "paymentRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KhoaHocId",
                table: "paymentRecords");
        }
    }
}
