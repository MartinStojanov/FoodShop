using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodShop.Migrations
{
    public partial class NewTry111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 12, "", 4, "https://www.burgerking.it/site/templates/img/crown-std/panino.png", "https://e7.pngegg.com/pngimages/215/535/png-clipart-whopper-hamburger-fast-food-cheeseburger-french-fries-burger-king-whopper-hamburger.png", true, true, "Our WHOPPER® Cheese Sandwich is a savoury flame-grilled beef topped with melted cheese, ripe tomatoes, fresh lettuce, creamy mayonnaise, ketchup, crunchy pickles, and sliced white onions on a soft sesame seed bun.", "Whopper® Cheese", null, 12.95m, "First, we eat. Then, we do everything else!" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 13, "", 4, "https://w7.pngwing.com/pngs/595/58/png-transparent-whopper-hamburger-big-king-veggie-burger-burger-king-burger-king-food-recipe-fast-food-restaurant-thumbnail.png", "https://freepngimg.com/thumb/sandwich/77381-king-whopper-hamburger-big-veggie-burger.png", true, true, "Big King® consists of two juicy flame-grilled 100% beef patties with double cheese on them, sliced onions, fresh lettuce, pickles and unique Big King sauce. Would You dare to try also extra-extra-large version of it - our Big King XXL®?.", "Big King®", null, 12.95m, "Life is better with a burger!" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Notes", "Price", "ShortDescription" },
                values: new object[] { 14, "", 4, "https://thumb.tildacdn.com/tild3237-3036-4662-b636-383431323936/-/format/webp/5-burg-cheeseburg.jpg", "https://upload.wikimedia.org/wikipedia/commons/1/11/Cheeseburger.png", true, true, "Made from 100% beef topped with a slice of melted cheese, pickles, ketchup and mustard all wrapped up in a sesame seed bun.", "Cheeseburger", null, 12.95m, "You had me at cheeseburger!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 14);

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsFoodOfTheWeek", "LongDescription", "NameItem", "Notes", "Price", "ShortDescription" },
                values: new object[] { 1, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "~/Images/DOUBLE CAROLINA WHOPPER.png", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Apple Pie", null, 12.95m, "Our famous apple pies!" });
        }
    }
}
