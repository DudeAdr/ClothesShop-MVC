using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothesShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClothesShop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemDetails_Id = table.Column<int>(type: "int", nullable: false),
                    ItemDetails_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemDetails_Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemDetails_Colour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemDetails_Price = table.Column<int>(type: "int", nullable: false),
                    EncodedBrand = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesShop", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClothesShop");
        }
    }
}
