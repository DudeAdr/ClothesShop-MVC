using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangePriceToIntTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ItemDetails_Price",
                table: "ClothesShop",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ItemDetails_Price",
                table: "ClothesShop",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
