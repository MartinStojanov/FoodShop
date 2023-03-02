using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodShop.Migrations
{
    public partial class ImagesNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/Images/DOUBLE CAROLINA WHOPPER.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg");
        }
    }
}
