using Microsoft.EntityFrameworkCore.Migrations;

namespace AplikacjaDoNaukiJęzyków.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Slowa",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoziomSlowa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SlowoPol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SlowoAng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SlowoAra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SlowoUkr = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slowa", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slowa");
        }
    }
}
