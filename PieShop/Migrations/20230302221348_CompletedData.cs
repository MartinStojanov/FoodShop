using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodShop.Migrations
{
    public partial class CompletedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CategoryName",
                value: "Pizza");

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9,
                column: "IsPieOfTheWeek",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 13,
                column: "IsPieOfTheWeek",
                value: false);

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 15, "", 5, "https://www.pngplay.com/wp-content/uploads/2/Pepperoni-Pizza-PNG-Images-HD.png", "https://toppng.com/uploads/preview/epperoni-pizza-png-pizza-pepperoni-11563248691ecls6qyxtd.png", true, true, "Made from 100% beef topped with a slice of melted cheese, pickles, ketchup and mustard all wrapped up in a sesame seed bun.", "Pepperoni Pizza", null, 12.95m, "Surround yourself with pizza, not negativity.!" },
                    { 16, "", 5, "https://w7.pngwing.com/pngs/117/665/png-transparent-pizza-margherita-margarita-prosciutto-pizzaria-pizza-food-recipe-cheese-thumbnail.png", "https://www.seekpng.com/png/detail/468-4685757_margherita-margherita-pizza-image-png.png", true, false, "What Is A Margherita Pizza? A traditional Neapolitan Margherita pizza recipe is tomato sauce with fresh tomatoes, mozzarella cheese and basil which represent the colours of the Italian flag – white cheese, green basil and red tomato.", "Margherita Pizza", null, 12.95m, "Work hard, be nice, eat pizza!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CategoryName",
                value: "Drinks");

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9,
                column: "IsPieOfTheWeek",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 13,
                column: "IsPieOfTheWeek",
                value: true);
        }
    }
}
