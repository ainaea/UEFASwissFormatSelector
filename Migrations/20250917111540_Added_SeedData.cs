using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class Added_SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("0a2171c0-78fa-4a4d-a5d6-fc77b0e4ad83"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Benfica" },
                    { new Guid("1b158596-f133-408b-9227-37ef58c267c4"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Borussia Dortmund" },
                    { new Guid("1bbbdaa6-8cdc-40f6-bac5-344271b42a9b"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Lyon" },
                    { new Guid("286cdb2a-c302-4232-a611-9756ab091755"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Juventus" },
                    { new Guid("2947fb15-3299-4d56-9a02-649adc0a769c"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Arsenal" },
                    { new Guid("30e96714-52a6-4a0f-a5e9-f72e152729fc"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "AC Milan" },
                    { new Guid("39ad2db5-44d1-49ba-8e17-91cb9f4d53b9"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Napoli" },
                    { new Guid("3ab6ee57-acca-4b62-ac9e-efd1b4fe4957"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Bayern Munich" },
                    { new Guid("3acff47e-3960-4ce4-aa18-adfe6fc3edc3"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39877"), null, "Dinamo Zagreb" },
                    { new Guid("3efdb9f7-2255-4e42-84bf-d2fb0e8b7253"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Monaco" },
                    { new Guid("484de9e5-1d2e-4d89-afbd-3ad3e29c76ab"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Villarreal" },
                    { new Guid("486ee81a-8d8d-4209-98f6-131314b4e8d9"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Real Madrid" },
                    { new Guid("4b5b09fe-f36d-49b3-acb9-176707256614"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Real Sociedad" },
                    { new Guid("5dada835-43b3-433a-bc01-deae6e680e58"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39888"), null, "Olympiacos" },
                    { new Guid("63554ced-a7ba-402f-b485-708f6eb1d42c"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Feyenoord" },
                    { new Guid("6cd26890-2df3-451c-8761-014b615b3df1"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Paris Saint-Germain" },
                    { new Guid("7ccd80ad-a891-45c9-bc4a-f15ffcb683c2"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Olympique de Marseille" },
                    { new Guid("81afdf8a-03c9-456d-b94b-b587b5ad61ba"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Red Star Belgrade" },
                    { new Guid("894e3dd8-e8f1-4b67-b77e-ec4704dcd48d"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Manchester United" },
                    { new Guid("99302cb2-f757-4115-8b17-180a7b5cd381"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Club Brugge" },
                    { new Guid("9e7b3294-d442-4d48-bc2b-09365ede430c"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Porto" },
                    { new Guid("a37ab947-16d0-48db-b867-986b64102b0e"), new Guid("1961ef33-73b5-45f8-9927-9bfb37f39899"), null, "Sheriff Tiraspol" },
                    { new Guid("a88ba145-4531-4a5f-96d5-ff5aa827d394"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Bayer Leverkusen" },
                    { new Guid("aa4a8252-1a16-4cd3-b1cb-dc3a2c1eafe8"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Liverpool" },
                    { new Guid("ac060e1f-d569-4ea5-a79a-231a1b07f88b"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Union Berlin" },
                    { new Guid("b490f6ec-6773-4cb9-b240-49cac63de507"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Sevilla" },
                    { new Guid("b5ff4dde-ce33-4fd5-87d5-566cd76801bf"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Roma" },
                    { new Guid("bbf95577-e60b-4f66-a4eb-462fcec1faa2"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Atlético Madrid" },
                    { new Guid("c3e146b4-56a2-407c-bec0-26814392de96"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Aston Villa" },
                    { new Guid("c4dc9d7a-489d-4819-a5b0-09f60e3c7e83"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Inter Milan" },
                    { new Guid("c5cd6ce5-7479-4592-a84f-da8761d2bac0"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Sporting CP" },
                    { new Guid("c6d32cd4-43a4-4f77-8f4a-7c86829363c5"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Galatasaray" },
                    { new Guid("c7d0a582-3844-4422-a515-4bcc88e732fd"), new Guid("1691ef33-73b5-45f8-9927-9bfb37f39899"), null, "Red Bull Salzburg" },
                    { new Guid("c8284cee-66a4-495d-8785-a5d2d349bdc2"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Lazio" },
                    { new Guid("cfc455e8-679c-475e-a97b-d9fc95369225"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Ajax" },
                    { new Guid("d040c9f2-61ae-46b6-b99d-e35113f08a73"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Newcastle United" },
                    { new Guid("d379c3ed-71c6-472b-8c7a-957cbd2b0cf8"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Manchester City" },
                    { new Guid("dbde8e16-504f-4df2-bdf9-2378018355c2"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "RB Leipzig" },
                    { new Guid("df2f8068-2cb1-407c-9dc6-8898a51cfa5f"), new Guid("2661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Copenhagen" },
                    { new Guid("dfeb48dd-1ffe-4c28-8256-ccc0c1c71b73"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "West Ham United" },
                    { new Guid("e5ddabc8-1493-4bc0-9f06-435e83b61b91"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Genk" },
                    { new Guid("eb2c4cb7-ded3-4439-a6b0-2cae70b89a29"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Barcelona" },
                    { new Guid("f0f8a133-f7b5-4958-a293-408e6d878c2f"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39888"), null, "Shakhtar Donetsk" },
                    { new Guid("fecc1ada-d7b5-43ee-ab04-0f5f81a1e282"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39877"), null, "Celtic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0a2171c0-78fa-4a4d-a5d6-fc77b0e4ad83"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1b158596-f133-408b-9227-37ef58c267c4"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1bbbdaa6-8cdc-40f6-bac5-344271b42a9b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("286cdb2a-c302-4232-a611-9756ab091755"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2947fb15-3299-4d56-9a02-649adc0a769c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("30e96714-52a6-4a0f-a5e9-f72e152729fc"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("39ad2db5-44d1-49ba-8e17-91cb9f4d53b9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("3ab6ee57-acca-4b62-ac9e-efd1b4fe4957"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("3acff47e-3960-4ce4-aa18-adfe6fc3edc3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("3efdb9f7-2255-4e42-84bf-d2fb0e8b7253"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("484de9e5-1d2e-4d89-afbd-3ad3e29c76ab"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("486ee81a-8d8d-4209-98f6-131314b4e8d9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4b5b09fe-f36d-49b3-acb9-176707256614"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("5dada835-43b3-433a-bc01-deae6e680e58"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("63554ced-a7ba-402f-b485-708f6eb1d42c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6cd26890-2df3-451c-8761-014b615b3df1"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7ccd80ad-a891-45c9-bc4a-f15ffcb683c2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("81afdf8a-03c9-456d-b94b-b587b5ad61ba"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("894e3dd8-e8f1-4b67-b77e-ec4704dcd48d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("99302cb2-f757-4115-8b17-180a7b5cd381"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9e7b3294-d442-4d48-bc2b-09365ede430c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a37ab947-16d0-48db-b867-986b64102b0e"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a88ba145-4531-4a5f-96d5-ff5aa827d394"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("aa4a8252-1a16-4cd3-b1cb-dc3a2c1eafe8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ac060e1f-d569-4ea5-a79a-231a1b07f88b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b490f6ec-6773-4cb9-b240-49cac63de507"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b5ff4dde-ce33-4fd5-87d5-566cd76801bf"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("bbf95577-e60b-4f66-a4eb-462fcec1faa2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c3e146b4-56a2-407c-bec0-26814392de96"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c4dc9d7a-489d-4819-a5b0-09f60e3c7e83"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c5cd6ce5-7479-4592-a84f-da8761d2bac0"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c6d32cd4-43a4-4f77-8f4a-7c86829363c5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c7d0a582-3844-4422-a515-4bcc88e732fd"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c8284cee-66a4-495d-8785-a5d2d349bdc2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cfc455e8-679c-475e-a97b-d9fc95369225"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d040c9f2-61ae-46b6-b99d-e35113f08a73"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d379c3ed-71c6-472b-8c7a-957cbd2b0cf8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("dbde8e16-504f-4df2-bdf9-2378018355c2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("df2f8068-2cb1-407c-9dc6-8898a51cfa5f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("dfeb48dd-1ffe-4c28-8256-ccc0c1c71b73"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("e5ddabc8-1493-4bc0-9f06-435e83b61b91"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("eb2c4cb7-ded3-4439-a6b0-2cae70b89a29"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f0f8a133-f7b5-4958-a293-408e6d878c2f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("fecc1ada-d7b5-43ee-ab04-0f5f81a1e282"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("92944679-54a6-4248-9bf8-e50e0774dedc"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("c5300dfa-f995-4bb3-9e2e-009b85752995"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("d5300dfa-f995-4bb3-9e2e-009b85752995"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("e2e36700-16f6-44de-a5c3-6acf484655c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1661ef33-73b5-45f8-9927-9bfb37f39866"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1661ef33-73b5-45f8-9927-9bfb37f39877"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1661ef33-73b5-45f8-9927-9bfb37f39888"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1691ef33-73b5-45f8-9927-9bfb37f39899"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1961ef33-73b5-45f8-9927-9bfb37f39899"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2661ef33-73b5-45f8-9927-9bfb37f39899"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6661ef33-73b5-45f8-9927-9bfb37f39877"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6661ef33-73b5-45f8-9927-9bfb37f39888"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6661ef33-73b5-45f8-9927-9bfb37f39899"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"));
        }
    }
}
