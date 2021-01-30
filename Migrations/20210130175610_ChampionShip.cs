using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballChempionship.Migrations
{
    public partial class ChampionShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "championships",
                columns: table => new
                {
                    ChampionshipId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teamAId = table.Column<int>(nullable: false),
                    teamBId = table.Column<int>(nullable: false),
                    scoreA = table.Column<int>(nullable: false),
                    scoreB = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_championships", x => x.ChampionshipId);
                });

            migrationBuilder.CreateTable(
                name: "footballTeams",
                columns: table => new
                {
                    FootballTeamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teamName = table.Column<string>(nullable: true),
                    score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_footballTeams", x => x.FootballTeamId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "championships");

            migrationBuilder.DropTable(
                name: "footballTeams");
        }
    }
}
