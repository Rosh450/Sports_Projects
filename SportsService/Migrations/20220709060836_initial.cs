using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsService.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sports",
                columns: table => new
                {
                    sportsid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noofplayers = table.Column<int>(type: "int", nullable: false),
                    sportsname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sportstype = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sports", x => x.sportsid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sports");
        }
    }
}
