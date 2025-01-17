using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS_Microservices.Services.MenuAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddIMSMenuToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IMSMenus",
                columns: table => new
                {
                    menuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    manuName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMSMenus", x => x.menuID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "IMSMenus",
                columns: new[] { "menuID", "category", "manuName", "price" },
                values: new object[,]
                {
                    { 1, "rice", "Chicken Biriyani", 10.0 },
                    { 2, "rice", "Beef Biriyani", 12.0 },
                    { 3, "drink", "Teo Lemao", 3.0 },
                    { 4, "side dish", "Mee Goreng", 6.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IMSMenus");
        }
    }
}
