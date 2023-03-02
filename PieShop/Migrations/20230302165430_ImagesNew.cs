using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodShop.Migrations
{
    public partial class ImagesNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Fruit pies");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Cheese cakes");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 4, "Burgers", null },
                    { 5, "Drinks", null }
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "ItemCategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Fruit pies", null },
                    { 2, "Cheese cakes", null },
                    { 3, "Seasonal pies", null },
                    { 4, "Burgers", null },
                    { 5, "Drinks", null },
                    { 6, "Ice Creams", null }
                });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "~/Images/DOUBLE CAROLINA WHOPPER.png");

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsFoodOfTheWeek", "LongDescription", "NameItem", "Notes", "Price", "ShortDescription" },
                values: new object[] { 1, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "~/Images/DOUBLE CAROLINA WHOPPER.png", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Apple Pie", null, 12.95m, "Our famous apple pies!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "ItemCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "ItemCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "ItemCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "ItemCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "ItemCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemCategories",
                keyColumn: "ItemCategoryId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Pies");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Burgers");

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg");
        }
    }
}
