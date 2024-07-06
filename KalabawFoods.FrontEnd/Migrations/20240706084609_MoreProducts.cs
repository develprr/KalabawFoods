using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KalabawFoods.FrontEnd.Migrations
{
    /// <inheritdoc />
    public partial class MoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Soups"}
                }
            );

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Count", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 4, 2, 3, "A favorite breakfast dish, beef tapa consists of cured meat marinated overnight in a special mixture of native ingredients.", "Beef Tapa", 11.99 },
                    { 5, 2, 5, "Pigar-Pigar features thinly sliced carabeef stir-fried with onions and bell peppers.", "Pigar Pigar", 9.09 },
                    { 6, 2, 4, "A hearty noodle dish that includes carabeef, miki noodles, and a flavorful sauce", "Batil-Batong", 7.99},
                    { 7, 2, 6, "Similar to beef tapa, this version uses carabeef. It’s often served with garlic rice and a fried egg.", "Carabeef Tapa", 5.99},
                    { 8, 1, 9, "A type of sausage with a distinct flavor", "Longanisa", 6.49},
                    { 9, 4, 8, "A comforting soup made with carabeef chunks, vegetables, and spices.", "Minanok Soup", 1.99},
                    { 10, 4, 12, "A traditional dish, papaitan is a bitter soup made with carabeef tripe, bile, and various herbs.", "Papaitan", 2.99},
                    { 11, 2, 9, "A rich and savory stew with vegetables (eggplant, string beans, and banana flower), and a thick peanut sauce.", "Kare Kare", 4.59},
                    { 12, 2, 8, "A flavorful meat stew. It’s cooked with tomatoes, bell peppers, potatoes, and liver spread, resulting in a hearty dish.", "Kaldereta", 6.49 }
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
