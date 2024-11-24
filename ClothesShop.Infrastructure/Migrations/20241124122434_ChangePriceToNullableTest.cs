using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangePriceToNullableTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ItemDetails_Price",
                table: "ClothesShop",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ItemDetails_Price",
                table: "ClothesShop",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
