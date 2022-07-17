using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventsServices.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    eventid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eventdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    noofslots = table.Column<int>(type: "int", nullable: false),
                    sportsname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.eventid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "events");
        }
    }
}
