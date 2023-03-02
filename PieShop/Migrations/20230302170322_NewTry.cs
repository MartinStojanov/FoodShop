using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodShop.Migrations
{
    public partial class NewTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://e7.pngegg.com/pngimages/215/535/png-clipart-whopper-hamburger-fast-food-cheeseburger-french-fries-burger-king-whopper-hamburger.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/Images/DOUBLE CAROLINA WHOPPER.png");
        }
    }
}
