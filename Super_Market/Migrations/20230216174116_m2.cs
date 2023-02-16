using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Market.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserName", "Password", "Pos", "Salary" },
                values: new object[] { "sasa", 2555, 0, 1000f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserName",
                keyValue: "sasa");
        }
    }
}
