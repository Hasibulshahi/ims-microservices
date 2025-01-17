using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS_Microservices.Services.UserAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedIMSEmployeeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "IMSEmployees",
                columns: new[] { "employeeID", "email", "firstName", "lastName", "password", "phone" },
                values: new object[,]
                {
                    { 1, "abc@xyz.com", "Hasibul", "Hassan", "123456", "0123456789" },
                    { 2, "def@xyz.com", "Sharmin", "Akter", "147852", "01122334455" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IMSEmployees",
                keyColumn: "employeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IMSEmployees",
                keyColumn: "employeeID",
                keyValue: 2);
        }
    }
}
