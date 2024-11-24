using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIdFromDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemDetails_Id",
                table: "ClothesShop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemDetails_Id",
                table: "ClothesShop",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
