using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppPractice.Migrations
{
    public partial class HerosBattles_SecretIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heros_Battles_BattleId",
                table: "Heros");

            migrationBuilder.DropIndex(
                name: "IX_Heros_BattleId",
                table: "Heros");

            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "Heros");

            migrationBuilder.CreateTable(
                name: "HerosBattles",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    BattleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HerosBattles", x => new { x.BattleId, x.HeroId });
                    table.ForeignKey(
                        name: "FK_HerosBattles_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HerosBattles_Heros_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SecretsIdentities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretsIdentities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecretsIdentities_Heros_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HerosBattles_HeroId",
                table: "HerosBattles",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_SecretsIdentities_HeroId",
                table: "SecretsIdentities",
                column: "HeroId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HerosBattles");

            migrationBuilder.DropTable(
                name: "SecretsIdentities");

            migrationBuilder.AddColumn<int>(
                name: "BattleId",
                table: "Heros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Heros_BattleId",
                table: "Heros",
                column: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heros_Battles_BattleId",
                table: "Heros",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
