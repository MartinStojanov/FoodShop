using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodShop.Migrations
{
    public partial class NewTry11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "https://www.burgerking.it/site/templates/img/crown-std/panino.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "~/Images/whopper-burger-small.png");
        }
    }
}
