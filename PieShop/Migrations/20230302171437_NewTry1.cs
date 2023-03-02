using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodShop.Migrations
{
    public partial class NewTry1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "~/Images/whopper-burger-small.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "~/Images/DOUBLE CAROLINA WHOPPER.png");
        }
    }
}
