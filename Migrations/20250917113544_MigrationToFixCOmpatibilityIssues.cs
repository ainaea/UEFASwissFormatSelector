using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class MigrationToFixCOmpatibilityIssues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
