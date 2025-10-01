using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClubsInScenarioInstance_ScenarioInstances_ScenarioInstanceId",
                        column: x => x.ScenarioInstanceId,
                        principalTable: "ScenarioInstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModifiedDictionary<IEnumerable<Pot>>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioInstanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModifiedDictionary<IEnumerable<Pot>>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModifiedDictionary<IEnumerable<Pot>>_ScenarioInstances_ScenarioInstanceId",
                        column: x => x.ScenarioInstanceId,
                        principalTable: "ScenarioInstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModifiedDictionary<List<Club>>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioInstanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModifiedDictionary<List<Club>>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModifiedDictionary<List<Club>>_ScenarioInstances_ScenarioInstanceId",
                        column: x => x.ScenarioInstanceId,
                        principalTable: "ScenarioInstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModifiedDictionary<List<string>>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioInstanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModifiedDictionary<List<string>>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModifiedDictionary<List<string>>_ScenarioInstances_ScenarioInstanceId",
                        column: x => x.ScenarioInstanceId,
                        principalTable: "ScenarioInstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClubsInPot_Pots_PotId",
                        column: x => x.PotId,
                        principalTable: "Pots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Abbrevation", "Flag", "Name" },
                values: new object[,]
                {
                    { new Guid("1661ef33-73b5-45f8-9927-9bfb37f39866"), "SRB", null, "Serbia" },
                    { new Guid("1661ef33-73b5-45f8-9927-9bfb37f39877"), "CRO", null, "Croatia" },
                    { new Guid("1661ef33-73b5-45f8-9927-9bfb37f39888"), "GRE", null, "Greece" },
                    { new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), "BEL", null, "Belgium" },
                    { new Guid("1691ef33-73b5-45f8-9927-9bfb37f39899"), "BEL", null, "Austria" },
                    { new Guid("1961ef33-73b5-45f8-9927-9bfb37f39899"), "MOL", null, "Moldova" },
                    { new Guid("2661ef33-73b5-45f8-9927-9bfb37f39899"), "DEN", null, "Denmark" },
                    { new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), "ITA", null, "Italy" },
                    { new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), "GER", null, "Germany" },
                    { new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), "FRA", null, "France" },
                    { new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), "POR", null, "Portugal" },
                    { new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), "NED", null, "Netherlands" },
                    { new Guid("6661ef33-73b5-45f8-9927-9bfb37f39877"), "SCO", null, "Scotland" },
                    { new Guid("6661ef33-73b5-45f8-9927-9bfb37f39888"), "UKR", null, "Ukraine" },
                    { new Guid("6661ef33-73b5-45f8-9927-9bfb37f39899"), "TUR", null, "Turkey" },
                    { new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), "ESP", null, "Spain" },
                    { new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), "ENG", null, "England" }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "HomeAndAwayPerOpponent", "Name", "NumberOfGamesPerPot", "NumberOfPot", "NumberOfTeamsPerPot" },
                values: new object[,]
                {
                    { new Guid("92944679-54a6-4248-9bf8-e50e0774dedc"), false, "4-2-2", 2, 2, 4 },
                    { new Guid("c5300dfa-f995-4bb3-9e2e-009b85752995"), false, "UEFA2425", 2, 4, 9 },
                    { new Guid("d5300dfa-f995-4bb3-9e2e-009b85752995"), true, "EPL", 19, 1, 20 },
                    { new Guid("e2e36700-16f6-44de-a5c3-6acf484655c3"), false, "3-2-4", 2, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "CountryId", "Logo", "Name" },
                values: new object[,]
                {
                    { new Guid("002bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Lyon" },
                    { new Guid("012bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Monaco" },
                    { new Guid("022bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Benfica" },
                    { new Guid("032bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Porto" },
                    { new Guid("042bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Sporting CP" },
                    { new Guid("052bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Ajax" },
                    { new Guid("062bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Feyenoord" },
                    { new Guid("072bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39877"), null, "Celtic" },
                    { new Guid("082bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39888"), null, "Shakhtar Donetsk" },
                    { new Guid("092bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Galatasaray" },
                    { new Guid("102bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Red Star Belgrade" },
                    { new Guid("112bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39877"), null, "Dinamo Zagreb" },
                    { new Guid("122bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39888"), null, "Olympiacos" },
                    { new Guid("132bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Club Brugge" },
                    { new Guid("142bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("2661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Copenhagen" },
                    { new Guid("152bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("1691ef33-73b5-45f8-9927-9bfb37f39899"), null, "Red Bull Salzburg" },
                    { new Guid("162bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Genk" },
                    { new Guid("172bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("1961ef33-73b5-45f8-9927-9bfb37f39899"), null, "Sheriff Tiraspol" },
                    { new Guid("742bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Manchester City" },
                    { new Guid("752bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Liverpool" },
                    { new Guid("762bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Arsenal" },
                    { new Guid("772bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Manchester United" },
                    { new Guid("782bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Newcastle United" },
                    { new Guid("792bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "West Ham United" },
                    { new Guid("802bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Aston Villa" },
                    { new Guid("812bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Real Madrid" },
                    { new Guid("822bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Barcelona" },
                    { new Guid("832bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Atlético Madrid" },
                    { new Guid("842bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Sevilla" },
                    { new Guid("852bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Real Sociedad" },
                    { new Guid("862bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Villarreal" },
                    { new Guid("872bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Bayern Munich" },
                    { new Guid("882bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Borussia Dortmund" },
                    { new Guid("892bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Bayer Leverkusen" },
                    { new Guid("902bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Union Berlin" },
                    { new Guid("912bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "RB Leipzig" },
                    { new Guid("922bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Inter Milan" },
                    { new Guid("932bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Juventus" },
                    { new Guid("942bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "AC Milan" },
                    { new Guid("952bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Napoli" },
                    { new Guid("962bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Roma" },
                    { new Guid("972bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Lazio" },
                    { new Guid("982bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Olympique de Marseille" },
                    { new Guid("992bf86e-4f43-4465-9872-34f9b1281f8a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Paris Saint-Germain" }
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
                name: "IX_ModifiedDictionary<IEnumerable<Pot>>_ScenarioInstanceId",
                table: "ModifiedDictionary<IEnumerable<Pot>>",
                column: "ScenarioInstanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModifiedDictionary<List<Club>>_ScenarioInstanceId",
                table: "ModifiedDictionary<List<Club>>",
                column: "ScenarioInstanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModifiedDictionary<List<string>>_ScenarioInstanceId",
                table: "ModifiedDictionary<List<string>>",
                column: "ScenarioInstanceId",
                unique: true);

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
                name: "ModifiedDictionary<IEnumerable<Pot>>");

            migrationBuilder.DropTable(
                name: "ModifiedDictionary<List<Club>>");

            migrationBuilder.DropTable(
                name: "ModifiedDictionary<List<string>>");

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
