using Microsoft.EntityFrameworkCore.Migrations;

namespace AplikacjaDoNaukiJęzyków.Migrations
{
    public partial class addSlowoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Slowa",
                columns: new[] { "ID", "PoziomSlowa", "SlowoAng", "SlowoAra", "SlowoPol", "SlowoUkr" },
                values: new object[] { 1, "podstawowy", "Hello", "أهلا", "Witam", "привіт" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Slowa",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
