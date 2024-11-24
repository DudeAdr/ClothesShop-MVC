using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddingAbout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ItemDetails_Price",
                table: "ClothesShop",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "ClothesShop",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "ClothesShop");

            migrationBuilder.AlterColumn<int>(
                name: "ItemDetails_Price",
                table: "ClothesShop",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
