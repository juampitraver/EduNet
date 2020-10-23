using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TP3.Infrastructure.Migrations
{
    public partial class AddChallengeTableAddElementAndCablesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "ConectionType",
                table: "Challenge",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Challenge",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<short>(
                name: "NetType",
                table: "Challenge",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateTable(
                name: "ChallengeCable",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChallengeId = table.Column<long>(nullable: false),
                    CableColor = table.Column<short>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeCable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChallengeCable_Challenge_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChallengeElement",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChallengeId = table.Column<long>(nullable: false),
                    Element = table.Column<short>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeElement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChallengeElement_Challenge_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeCable_ChallengeId",
                table: "ChallengeCable",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_ChallengeElement_ChallengeId",
                table: "ChallengeElement",
                column: "ChallengeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChallengeCable");

            migrationBuilder.DropTable(
                name: "ChallengeElement");

            migrationBuilder.DropColumn(
                name: "ConectionType",
                table: "Challenge");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Challenge");

            migrationBuilder.DropColumn(
                name: "NetType",
                table: "Challenge");
        }
    }
}
