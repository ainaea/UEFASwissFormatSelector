using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class MigrationToFixCOmpatibilityIssues2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0908321e-4eb5-40ef-b3da-fe157d3e3c58"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0bac3e11-5c17-4ecb-94a9-d10f406c4162"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0eabb8e5-a79d-457c-8905-3639cb5196a2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1393549e-03eb-41d3-a139-dd03b25cb023"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("16e2aa1d-4903-48f0-b44b-560f69956c18"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1c249449-395b-47fa-a9c6-7e06a54bb338"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1d72ddc1-48ba-4525-a985-5ba8eabdd366"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("21ec319b-09a5-4f80-82f7-ac9ec33be94a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2588ff35-1311-44d0-a148-2606b0228c83"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("33f5a98a-467b-4ee3-950e-b1cc4c608c28"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("371dedc0-07a8-4bee-a68d-b40fb6c50b09"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("487dfe46-bca4-4019-aaae-a2dae3f6a8b4"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4fffd503-4986-4e70-ba74-2cc3dc6e66e2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("50461a41-d0af-436c-8956-ff3881148f88"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6289276c-c2a4-4c0c-a35c-90e30eabeba1"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("630d4609-9688-4600-a904-cfbc637368bc"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6ad15ec8-af1f-47a2-8b84-291d93e3fb57"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7b53c50c-7747-4c65-b62e-a7193d3b1884"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("898c7e94-b104-4b63-8af9-12d6c76badaf"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9001e991-ad25-4847-9df4-c462c4e9d040"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9bd0a45d-17c6-4aaf-86ad-93b84eb1e0c1"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a7a29524-5ee0-40d0-9d6b-febb94710658"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a7c222f6-7968-45dc-a419-374c3395fbe5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("aa3536b2-ceb2-4c1d-9083-0b2d3cca69d5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("aefd829a-eccb-4c40-8fef-29ff3d239450"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("af156ba6-7347-4862-b2ac-e28d53a44cc7"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b081a154-33a1-4c65-b5f3-16c749626710"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b624e4d7-211e-4d61-a41c-bbf735792ee0"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("bb0e19b0-0f94-450f-89b1-1c4215e71dd3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("bf422d8a-ab82-4021-ba47-3b7bb2cfeeb1"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("bf9ea561-c896-47cd-9eee-45499a3da63a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c878cb97-9037-49b7-a29b-7f8b2f417502"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cef7d048-b46e-49c3-829d-7abd5472254d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cf500bbd-15e0-48b5-8ede-5b988bc344d9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cf7eb2aa-b192-413f-881a-81746ecf5461"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cfa6de2b-5ec8-4e62-9eb7-9a8245a9ab71"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d4b5ae48-cc4e-4c81-829a-6638390e80b3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("da42e4b3-0a01-43df-9dcc-54885a2bfb27"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("dbd250b3-1334-40d7-9682-13b6edec9111"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("df0f295a-b10a-4625-add3-1d0fcd29cc5f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ec7d906b-1f85-4534-a006-a852539d568f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f11afe6d-1133-4c4d-b264-4cb100fb2883"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f19d9e88-9a7a-4d23-8dfc-51607a7fdf77"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f20d7598-0db2-4222-a8fe-24fff02a0856"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "CountryId", "Logo", "Name" },
                values: new object[,]
                {
                    { new Guid("07033692-a604-4875-9cab-780419027610"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Roma" },
                    { new Guid("07d12192-1324-4e89-b7fd-787f25312f6f"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Monaco" },
                    { new Guid("08b44704-e461-49a3-92f9-f598d56a71f7"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Real Sociedad" },
                    { new Guid("0e423654-f6e0-4c28-b905-c2951dc67e3b"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "AC Milan" },
                    { new Guid("139e089d-481c-47d8-b5b7-099c3af8137d"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Lyon" },
                    { new Guid("13ed621c-ec2f-4b89-b52a-c9e25e480a61"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Atlético Madrid" },
                    { new Guid("13f97579-6783-4a42-a6de-a868ecc62962"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Paris Saint-Germain" },
                    { new Guid("15da069d-c1b9-4fe9-ab58-26d34bfa08d5"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Manchester United" },
                    { new Guid("16aeb5fa-a4d6-4dc7-94f5-e8de4a69878b"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Genk" },
                    { new Guid("19427952-3dd3-4d13-92cd-9bf7c8762da0"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39877"), null, "Celtic" },
                    { new Guid("19ee40ca-911a-4a58-a755-25a20c35d523"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39888"), null, "Shakhtar Donetsk" },
                    { new Guid("2cd8961f-8275-44af-92fd-989205388336"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39877"), null, "Dinamo Zagreb" },
                    { new Guid("4a9b0d26-ba63-4e78-8587-e696c82e4378"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Inter Milan" },
                    { new Guid("4c7d8449-ccfc-4a8c-9c4c-9f2f187586b9"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Feyenoord" },
                    { new Guid("4ea73390-b63a-4963-b80c-8f371970ff52"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Galatasaray" },
                    { new Guid("652f6e93-391f-4df5-b4e4-d51d6c51906c"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39888"), null, "Olympiacos" },
                    { new Guid("6a9f5c29-4d50-4328-9a00-2bdb61af1cf3"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Sporting CP" },
                    { new Guid("73f7125f-2a8c-4ff7-aa95-86cc25f42e5d"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Bayer Leverkusen" },
                    { new Guid("8532e0ae-b786-4c81-ad21-1c5c8c9217ee"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Barcelona" },
                    { new Guid("864379ac-8249-4ccb-b2f9-dde73df08554"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Villarreal" },
                    { new Guid("89b219fb-f09f-4c86-90df-10699016ee90"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Sevilla" },
                    { new Guid("8c23249c-23c0-4e84-8cc1-bedc5c85e270"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Napoli" },
                    { new Guid("8d09a2c1-e055-4a3f-b1d7-29e8171cc0ce"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Newcastle United" },
                    { new Guid("973bcfff-6590-4ae2-be25-903ecd671d69"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Liverpool" },
                    { new Guid("9ad7e6cc-74d1-43b2-9765-63d3878c14e4"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Club Brugge" },
                    { new Guid("9b6cb67b-9c66-463c-b990-1b17e0730c25"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Benfica" },
                    { new Guid("9ba6bc16-299b-45b7-b208-80986360f8aa"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Lazio" },
                    { new Guid("a212c5fd-079f-4d40-86b3-4ca4fc44f92d"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Ajax" },
                    { new Guid("a74395e6-e939-40aa-8a2f-efd604994266"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Manchester City" },
                    { new Guid("af1c5950-27eb-4998-8358-1325f18a33b4"), new Guid("1961ef33-73b5-45f8-9927-9bfb37f39899"), null, "Sheriff Tiraspol" },
                    { new Guid("b19cc21e-0c4a-4445-acdb-367543c17a95"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "RB Leipzig" },
                    { new Guid("b75abe7e-6195-419f-ac17-fb77c67ce0b3"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Union Berlin" },
                    { new Guid("b7d07a52-fc63-4202-ae36-f38ef86c0e9e"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Juventus" },
                    { new Guid("be0fa8d0-fb78-4140-b1a6-4a8bd4471c6b"), new Guid("1691ef33-73b5-45f8-9927-9bfb37f39899"), null, "Red Bull Salzburg" },
                    { new Guid("c0c33017-b8f3-47f9-8ea1-60a3e64f3f85"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Aston Villa" },
                    { new Guid("c1c6d0dc-55ef-4eae-8907-1c99bc405664"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Bayern Munich" },
                    { new Guid("d1860380-b541-422e-a5df-ce9c0bd0d652"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Porto" },
                    { new Guid("d2cdcf1a-9857-41ba-88bb-71efab4442b5"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Real Madrid" },
                    { new Guid("d3cc2cb7-2560-4195-ac31-fda22292e91d"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "West Ham United" },
                    { new Guid("d56d16c2-c850-4e30-887e-eab5b027ca32"), new Guid("2661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Copenhagen" },
                    { new Guid("de5879a2-fc11-4229-bd95-f6489a9d981d"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Arsenal" },
                    { new Guid("df25b4d0-9880-4aa2-b505-9ceaed12601d"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Borussia Dortmund" },
                    { new Guid("f7c5d1c9-ae1e-4ba1-81ce-b9a488a9690f"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Olympique de Marseille" },
                    { new Guid("fafb12ef-428a-4e51-801e-5da10e5f5452"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Red Star Belgrade" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("07033692-a604-4875-9cab-780419027610"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("07d12192-1324-4e89-b7fd-787f25312f6f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("08b44704-e461-49a3-92f9-f598d56a71f7"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0e423654-f6e0-4c28-b905-c2951dc67e3b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("139e089d-481c-47d8-b5b7-099c3af8137d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("13ed621c-ec2f-4b89-b52a-c9e25e480a61"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("13f97579-6783-4a42-a6de-a868ecc62962"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("15da069d-c1b9-4fe9-ab58-26d34bfa08d5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("16aeb5fa-a4d6-4dc7-94f5-e8de4a69878b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("19427952-3dd3-4d13-92cd-9bf7c8762da0"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("19ee40ca-911a-4a58-a755-25a20c35d523"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2cd8961f-8275-44af-92fd-989205388336"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4a9b0d26-ba63-4e78-8587-e696c82e4378"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4c7d8449-ccfc-4a8c-9c4c-9f2f187586b9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4ea73390-b63a-4963-b80c-8f371970ff52"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("652f6e93-391f-4df5-b4e4-d51d6c51906c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6a9f5c29-4d50-4328-9a00-2bdb61af1cf3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("73f7125f-2a8c-4ff7-aa95-86cc25f42e5d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8532e0ae-b786-4c81-ad21-1c5c8c9217ee"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("864379ac-8249-4ccb-b2f9-dde73df08554"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("89b219fb-f09f-4c86-90df-10699016ee90"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8c23249c-23c0-4e84-8cc1-bedc5c85e270"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8d09a2c1-e055-4a3f-b1d7-29e8171cc0ce"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("973bcfff-6590-4ae2-be25-903ecd671d69"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9ad7e6cc-74d1-43b2-9765-63d3878c14e4"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9b6cb67b-9c66-463c-b990-1b17e0730c25"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9ba6bc16-299b-45b7-b208-80986360f8aa"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a212c5fd-079f-4d40-86b3-4ca4fc44f92d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a74395e6-e939-40aa-8a2f-efd604994266"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("af1c5950-27eb-4998-8358-1325f18a33b4"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b19cc21e-0c4a-4445-acdb-367543c17a95"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b75abe7e-6195-419f-ac17-fb77c67ce0b3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b7d07a52-fc63-4202-ae36-f38ef86c0e9e"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("be0fa8d0-fb78-4140-b1a6-4a8bd4471c6b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c0c33017-b8f3-47f9-8ea1-60a3e64f3f85"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c1c6d0dc-55ef-4eae-8907-1c99bc405664"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d1860380-b541-422e-a5df-ce9c0bd0d652"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d2cdcf1a-9857-41ba-88bb-71efab4442b5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d3cc2cb7-2560-4195-ac31-fda22292e91d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d56d16c2-c850-4e30-887e-eab5b027ca32"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("de5879a2-fc11-4229-bd95-f6489a9d981d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("df25b4d0-9880-4aa2-b505-9ceaed12601d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f7c5d1c9-ae1e-4ba1-81ce-b9a488a9690f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("fafb12ef-428a-4e51-801e-5da10e5f5452"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "CountryId", "Logo", "Name" },
                values: new object[,]
                {
                    { new Guid("0908321e-4eb5-40ef-b3da-fe157d3e3c58"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Galatasaray" },
                    { new Guid("0bac3e11-5c17-4ecb-94a9-d10f406c4162"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Bayern Munich" },
                    { new Guid("0eabb8e5-a79d-457c-8905-3639cb5196a2"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Sporting CP" },
                    { new Guid("1393549e-03eb-41d3-a139-dd03b25cb023"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Borussia Dortmund" },
                    { new Guid("16e2aa1d-4903-48f0-b44b-560f69956c18"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39888"), null, "Olympiacos" },
                    { new Guid("1c249449-395b-47fa-a9c6-7e06a54bb338"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Villarreal" },
                    { new Guid("1d72ddc1-48ba-4525-a985-5ba8eabdd366"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Napoli" },
                    { new Guid("21ec319b-09a5-4f80-82f7-ac9ec33be94a"), new Guid("2661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Copenhagen" },
                    { new Guid("2588ff35-1311-44d0-a148-2606b0228c83"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39877"), null, "Dinamo Zagreb" },
                    { new Guid("33f5a98a-467b-4ee3-950e-b1cc4c608c28"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Roma" },
                    { new Guid("371dedc0-07a8-4bee-a68d-b40fb6c50b09"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Real Madrid" },
                    { new Guid("487dfe46-bca4-4019-aaae-a2dae3f6a8b4"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Manchester United" },
                    { new Guid("4fffd503-4986-4e70-ba74-2cc3dc6e66e2"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39877"), null, "Celtic" },
                    { new Guid("50461a41-d0af-436c-8956-ff3881148f88"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Atlético Madrid" },
                    { new Guid("6289276c-c2a4-4c0c-a35c-90e30eabeba1"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Red Star Belgrade" },
                    { new Guid("630d4609-9688-4600-a904-cfbc637368bc"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Porto" },
                    { new Guid("6ad15ec8-af1f-47a2-8b84-291d93e3fb57"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Liverpool" },
                    { new Guid("7b53c50c-7747-4c65-b62e-a7193d3b1884"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Genk" },
                    { new Guid("898c7e94-b104-4b63-8af9-12d6c76badaf"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "AC Milan" },
                    { new Guid("9001e991-ad25-4847-9df4-c462c4e9d040"), new Guid("1691ef33-73b5-45f8-9927-9bfb37f39899"), null, "Red Bull Salzburg" },
                    { new Guid("9bd0a45d-17c6-4aaf-86ad-93b84eb1e0c1"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39888"), null, "Shakhtar Donetsk" },
                    { new Guid("a7a29524-5ee0-40d0-9d6b-febb94710658"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Juventus" },
                    { new Guid("a7c222f6-7968-45dc-a419-374c3395fbe5"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Sevilla" },
                    { new Guid("aa3536b2-ceb2-4c1d-9083-0b2d3cca69d5"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Ajax" },
                    { new Guid("aefd829a-eccb-4c40-8fef-29ff3d239450"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Aston Villa" },
                    { new Guid("af156ba6-7347-4862-b2ac-e28d53a44cc7"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Real Sociedad" },
                    { new Guid("b081a154-33a1-4c65-b5f3-16c749626710"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Lazio" },
                    { new Guid("b624e4d7-211e-4d61-a41c-bbf735792ee0"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Union Berlin" },
                    { new Guid("bb0e19b0-0f94-450f-89b1-1c4215e71dd3"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Lyon" },
                    { new Guid("bf422d8a-ab82-4021-ba47-3b7bb2cfeeb1"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "Bayer Leverkusen" },
                    { new Guid("bf9ea561-c896-47cd-9eee-45499a3da63a"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39866"), null, "Feyenoord" },
                    { new Guid("c878cb97-9037-49b7-a29b-7f8b2f417502"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Paris Saint-Germain" },
                    { new Guid("cef7d048-b46e-49c3-829d-7abd5472254d"), new Guid("8bb21cd3-572c-4392-bf4d-29aa4cf58b06"), null, "Barcelona" },
                    { new Guid("cf500bbd-15e0-48b5-8ede-5b988bc344d9"), new Guid("1661ef33-73b5-45f8-9927-9bfb37f39899"), null, "Club Brugge" },
                    { new Guid("cf7eb2aa-b192-413f-881a-81746ecf5461"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "West Ham United" },
                    { new Guid("cfa6de2b-5ec8-4e62-9eb7-9a8245a9ab71"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Manchester City" },
                    { new Guid("d4b5ae48-cc4e-4c81-829a-6638390e80b3"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39855"), null, "Benfica" },
                    { new Guid("da42e4b3-0a01-43df-9dcc-54885a2bfb27"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Olympique de Marseille" },
                    { new Guid("dbd250b3-1334-40d7-9682-13b6edec9111"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Newcastle United" },
                    { new Guid("df0f295a-b10a-4625-add3-1d0fcd29cc5f"), new Guid("5dcf05a0-aeec-487e-bab1-10a4b4913ef3"), null, "Inter Milan" },
                    { new Guid("ec7d906b-1f85-4534-a006-a852539d568f"), new Guid("a5300dfa-f995-4bb3-9e2e-009b85752995"), null, "Arsenal" },
                    { new Guid("f11afe6d-1133-4c4d-b264-4cb100fb2883"), new Guid("6321ef33-73b5-45f8-9927-9afb37f39844"), null, "RB Leipzig" },
                    { new Guid("f19d9e88-9a7a-4d23-8dfc-51607a7fdf77"), new Guid("6661ef33-73b5-45f8-9927-9bfb37f39844"), null, "Monaco" },
                    { new Guid("f20d7598-0db2-4222-a8fe-24fff02a0856"), new Guid("1961ef33-73b5-45f8-9927-9bfb37f39899"), null, "Sheriff Tiraspol" }
                });
        }
    }
}
