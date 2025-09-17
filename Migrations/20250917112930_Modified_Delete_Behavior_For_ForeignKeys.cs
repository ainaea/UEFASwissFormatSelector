using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class Modified_Delete_Behavior_For_ForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Countries_CountryId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubsInPot_Clubs_ClubId",
                table: "ClubsInPot");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubsInPot_Pots_PotId",
                table: "ClubsInPot");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubsInScenarioInstance_Clubs_ClubId",
                table: "ClubsInScenarioInstance");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubsInScenarioInstance_ScenarioInstances_ScenarioInstanceId",
                table: "ClubsInScenarioInstance");

            migrationBuilder.DropForeignKey(
                name: "FK_Pots_ScenarioInstances_ScenarioInstanceId",
                table: "Pots");

            migrationBuilder.DropForeignKey(
                name: "FK_ScenarioInstances_Scenarios_ScenarioId",
                table: "ScenarioInstances");

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

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "CountryId", "Logo", "Name" },
                values: new object[,]
                {
                    { new Guid("01fce158-fb5c-4229-8032-34fe92a816c6"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39888"), null, "Olympiacos" },
                    { new Guid("06476627-43af-4ed6-a046-6d9e4b7dcae1"), new Guid("2661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Copenhagen" },
                    { new Guid("09ca7bea-1d2a-49a4-a568-bd68de0e95a5"), new Guid("1691ef33-73b5-45f8-9927-9bfb37f39899"), null, "Red Bull Salzburg" },
                    { new Guid("0b7ce159-08b3-4acf-bab6-6ec54e409006"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Paris Saint-Germain" },
                    { new Guid("0f077216-aea0-4c1e-958a-c0a74e008680"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Borussia Dortmund" },
                    { new Guid("169cf9b9-6167-4b5c-881e-a8bf6f44df44"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Red Star Belgrade" },
                    { new Guid("1c5fc9f5-52d2-417b-a50e-664a227b946c"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Galatasaray" },
                    { new Guid("26f466fe-44d0-4967-a388-918b2829fe23"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Ajax" },
                    { new Guid("2a5b332b-7696-45a3-b3c2-f56f2e9659ba"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Feyenoord" },
                    { new Guid("2b2aeb74-4d9d-46fa-868d-64e4a75387ac"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Monaco" },
                    { new Guid("32cd6936-6fd1-4b33-a86c-42bed801421c"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Atlético Madrid" },
                    { new Guid("3ebcc484-78b0-4937-a195-99387f9eebbe"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Manchester United" },
                    { new Guid("41de5302-30fb-4c4d-9a95-ffa123da23e0"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Benfica" },
                    { new Guid("4485bfd7-d3ab-497b-8366-2eb6d59e775e"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Villarreal" },
                    { new Guid("4f62785f-c352-413f-ad79-2d0b0298595c"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Manchester City" },
                    { new Guid("58f6a076-0d78-4b50-87a2-0a08f7f08877"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Olympique de Marseille" },
                    { new Guid("5a900e84-6b16-460c-9526-bacc54f128fe"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Aston Villa" },
                    { new Guid("5f6b4c5c-f4b7-4d29-b90a-e1f65411ba62"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Liverpool" },
                    { new Guid("600cdb41-e3a0-45ef-b385-dba771a73a3f"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Lazio" },
                    { new Guid("6279bf3b-8d5f-41b0-a824-56660543d813"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Juventus" },
                    { new Guid("634d9e78-490d-48c4-94e1-0640ae206787"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39888"), null, "Shakhtar Donetsk" },
                    { new Guid("64881335-75d7-48a5-86e7-9f28e01365f1"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Arsenal" },
                    { new Guid("6911a2fc-f938-4c86-892b-6d600a0ce3d1"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Lyon" },
                    { new Guid("6c0a4991-ded4-4081-9f6a-e98aa642937a"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Real Madrid" },
                    { new Guid("71a854fe-243d-459b-bee9-16a81d73bc12"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39877"), null, "Celtic" },
                    { new Guid("773886aa-d9ed-4788-9254-4ab508d18cc5"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Inter Milan" },
                    { new Guid("835cb674-d10b-4e1c-addf-9d5d1b701b0d"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Club Brugge" },
                    { new Guid("856447ff-487a-469d-b01e-368989a8358a"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Genk" },
                    { new Guid("9ebb7650-690e-4131-8c69-42f371d2fce0"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "West Ham United" },
                    { new Guid("a00fb886-0d4e-4223-b339-852e8f065d96"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Barcelona" },
                    { new Guid("a8cc04fe-7093-4dc8-9647-6f747f08c6e3"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Real Sociedad" },
                    { new Guid("ab455e3e-1b64-4f82-9b64-ef41fa502e8f"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39877"), null, "Dinamo Zagreb" },
                    { new Guid("b45c4027-36be-4db7-bcda-5421d4df3d04"), new Guid("1961ef33-73b5-45f8-9927-9bfb37f39899"), null, "Sheriff Tiraspol" },
                    { new Guid("b9bba96f-f981-405b-ad42-c7edaa61060e"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Sporting CP" },
                    { new Guid("cc7c1335-525a-477c-84a4-5031a1516e96"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "AC Milan" },
                    { new Guid("d687162b-e734-40aa-a0ed-c4ec49439397"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Roma" },
                    { new Guid("e24c54a6-bd01-46fb-8c59-13fd114b5c88"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Sevilla" },
                    { new Guid("eccaa54b-c918-4ef5-bcc1-840ad04aaefd"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Union Berlin" },
                    { new Guid("f0b6fcbb-f049-4eb4-99c9-996d59e30a86"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Bayer Leverkusen" },
                    { new Guid("f1115688-bc1e-4f21-9b4d-887973de9fdd"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "RB Leipzig" },
                    { new Guid("f11cb337-0467-4968-a605-6a0538248c18"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Bayern Munich" },
                    { new Guid("f66e3a42-8a4e-4b32-97ea-2774895e4b40"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Napoli" },
                    { new Guid("fa9d3998-e1cc-49fe-9fbc-7ded3aa5086a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Porto" },
                    { new Guid("fd1e7ed7-ca34-4406-9dd1-acfd3b4ea1be"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Newcastle United" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Countries_CountryId",
                table: "Clubs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubsInPot_Clubs_ClubId",
                table: "ClubsInPot",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubsInPot_Pots_PotId",
                table: "ClubsInPot",
                column: "PotId",
                principalTable: "Pots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubsInScenarioInstance_Clubs_ClubId",
                table: "ClubsInScenarioInstance",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubsInScenarioInstance_ScenarioInstances_ScenarioInstanceId",
                table: "ClubsInScenarioInstance",
                column: "ScenarioInstanceId",
                principalTable: "ScenarioInstances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pots_ScenarioInstances_ScenarioInstanceId",
                table: "Pots",
                column: "ScenarioInstanceId",
                principalTable: "ScenarioInstances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScenarioInstances_Scenarios_ScenarioId",
                table: "ScenarioInstances",
                column: "ScenarioId",
                principalTable: "Scenarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Countries_CountryId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubsInPot_Clubs_ClubId",
                table: "ClubsInPot");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubsInPot_Pots_PotId",
                table: "ClubsInPot");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubsInScenarioInstance_Clubs_ClubId",
                table: "ClubsInScenarioInstance");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubsInScenarioInstance_ScenarioInstances_ScenarioInstanceId",
                table: "ClubsInScenarioInstance");

            migrationBuilder.DropForeignKey(
                name: "FK_Pots_ScenarioInstances_ScenarioInstanceId",
                table: "Pots");

            migrationBuilder.DropForeignKey(
                name: "FK_ScenarioInstances_Scenarios_ScenarioId",
                table: "ScenarioInstances");

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("01fce158-fb5c-4229-8032-34fe92a816c6"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("06476627-43af-4ed6-a046-6d9e4b7dcae1"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("09ca7bea-1d2a-49a4-a568-bd68de0e95a5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0b7ce159-08b3-4acf-bab6-6ec54e409006"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0f077216-aea0-4c1e-958a-c0a74e008680"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("169cf9b9-6167-4b5c-881e-a8bf6f44df44"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1c5fc9f5-52d2-417b-a50e-664a227b946c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("26f466fe-44d0-4967-a388-918b2829fe23"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2a5b332b-7696-45a3-b3c2-f56f2e9659ba"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2b2aeb74-4d9d-46fa-868d-64e4a75387ac"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("32cd6936-6fd1-4b33-a86c-42bed801421c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("3ebcc484-78b0-4937-a195-99387f9eebbe"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("41de5302-30fb-4c4d-9a95-ffa123da23e0"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4485bfd7-d3ab-497b-8366-2eb6d59e775e"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4f62785f-c352-413f-ad79-2d0b0298595c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("58f6a076-0d78-4b50-87a2-0a08f7f08877"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("5a900e84-6b16-460c-9526-bacc54f128fe"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("5f6b4c5c-f4b7-4d29-b90a-e1f65411ba62"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("600cdb41-e3a0-45ef-b385-dba771a73a3f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6279bf3b-8d5f-41b0-a824-56660543d813"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("634d9e78-490d-48c4-94e1-0640ae206787"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("64881335-75d7-48a5-86e7-9f28e01365f1"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6911a2fc-f938-4c86-892b-6d600a0ce3d1"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6c0a4991-ded4-4081-9f6a-e98aa642937a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("71a854fe-243d-459b-bee9-16a81d73bc12"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("773886aa-d9ed-4788-9254-4ab508d18cc5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("835cb674-d10b-4e1c-addf-9d5d1b701b0d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("856447ff-487a-469d-b01e-368989a8358a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9ebb7650-690e-4131-8c69-42f371d2fce0"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a00fb886-0d4e-4223-b339-852e8f065d96"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a8cc04fe-7093-4dc8-9647-6f747f08c6e3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ab455e3e-1b64-4f82-9b64-ef41fa502e8f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b45c4027-36be-4db7-bcda-5421d4df3d04"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b9bba96f-f981-405b-ad42-c7edaa61060e"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cc7c1335-525a-477c-84a4-5031a1516e96"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d687162b-e734-40aa-a0ed-c4ec49439397"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("e24c54a6-bd01-46fb-8c59-13fd114b5c88"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("eccaa54b-c918-4ef5-bcc1-840ad04aaefd"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f0b6fcbb-f049-4eb4-99c9-996d59e30a86"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f1115688-bc1e-4f21-9b4d-887973de9fdd"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f11cb337-0467-4968-a605-6a0538248c18"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f66e3a42-8a4e-4b32-97ea-2774895e4b40"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("fa9d3998-e1cc-49fe-9fbc-7ded3aa5086a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("fd1e7ed7-ca34-4406-9dd1-acfd3b4ea1be"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Countries_CountryId",
                table: "Clubs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubsInPot_Clubs_ClubId",
                table: "ClubsInPot",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubsInPot_Pots_PotId",
                table: "ClubsInPot",
                column: "PotId",
                principalTable: "Pots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubsInScenarioInstance_Clubs_ClubId",
                table: "ClubsInScenarioInstance",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubsInScenarioInstance_ScenarioInstances_ScenarioInstanceId",
                table: "ClubsInScenarioInstance",
                column: "ScenarioInstanceId",
                principalTable: "ScenarioInstances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pots_ScenarioInstances_ScenarioInstanceId",
                table: "Pots",
                column: "ScenarioInstanceId",
                principalTable: "ScenarioInstances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScenarioInstances_Scenarios_ScenarioId",
                table: "ScenarioInstances",
                column: "ScenarioId",
                principalTable: "Scenarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
