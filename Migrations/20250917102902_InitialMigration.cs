using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Abbrevation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scenarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberOfPot = table.Column<int>(type: "int", nullable: false),
                    NumberOfTeamsPerPot = table.Column<int>(type: "int", nullable: false),
                    NumberOfGamesPerPot = table.Column<int>(type: "int", nullable: false),
                    HomeAndAwayPerOpponent = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scenarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clubs_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScenarioInstances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScenarioInstances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScenarioInstances_Scenarios_ScenarioId",
                        column: x => x.ScenarioId,
                        principalTable: "Scenarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubsInScenarioInstance",
                columns: table => new
                {
                    ClubId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioInstanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ranking = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubsInScenarioInstance", x => new { x.ClubId, x.ScenarioInstanceId });
                    table.ForeignKey(
                        name: "FK_ClubsInScenarioInstance_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubsInScenarioInstance_ScenarioInstances_ScenarioInstanceId",
                        column: x => x.ScenarioInstanceId,
                        principalTable: "ScenarioInstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioInstanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pots_ScenarioInstances_ScenarioInstanceId",
                        column: x => x.ScenarioInstanceId,
                        principalTable: "ScenarioInstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubsInPot",
                columns: table => new
                {
                    ClubId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubsInPot", x => new { x.ClubId, x.PotId });
                    table.ForeignKey(
                        name: "FK_ClubsInPot_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubsInPot_Pots_PotId",
                        column: x => x.PotId,
                        principalTable: "Pots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_CountryId",
                table: "Clubs",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubsInPot_PotId",
                table: "ClubsInPot",
                column: "PotId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubsInScenarioInstance_ScenarioInstanceId",
                table: "ClubsInScenarioInstance",
                column: "ScenarioInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Pots_ScenarioInstanceId",
                table: "Pots",
                column: "ScenarioInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ScenarioInstances_ScenarioId",
                table: "ScenarioInstances",
                column: "ScenarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubsInPot");

            migrationBuilder.DropTable(
                name: "ClubsInScenarioInstance");

            migrationBuilder.DropTable(
                name: "Pots");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "ScenarioInstances");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Scenarios");
        }
    }
}
