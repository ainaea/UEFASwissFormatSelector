using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class Added_DbModifiedDictionaryEntity_To_Handle_ModifiedDictionary_IEnumerable_object__ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DbMatchUpsDictionaryId",
                table: "ScenarioInstances",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DbMatchUpsObjectId",
                table: "ScenarioInstances",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DbOpponentsDictionaryId",
                table: "ScenarioInstances",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DbOpponentsObjectId",
                table: "ScenarioInstances",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "DbModifiedDictionaryEntity<Club>",
                columns: table => new
                {
                    DictionaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DictionaryKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbModifiedDictionaryEntity<Club>", x => new { x.ObjectId, x.DictionaryId });
                });

            migrationBuilder.CreateTable(
                name: "DbModifiedDictionaryEntity<Pot>",
                columns: table => new
                {
                    DictionaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DictionaryKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbModifiedDictionaryEntity<Pot>", x => new { x.ObjectId, x.DictionaryId });
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScenarioInstances_DbMatchUpsObjectId_DbMatchUpsDictionaryId",
                table: "ScenarioInstances",
                columns: new[] { "DbMatchUpsObjectId", "DbMatchUpsDictionaryId" });

            migrationBuilder.CreateIndex(
                name: "IX_ScenarioInstances_DbOpponentsObjectId_DbOpponentsDictionaryId",
                table: "ScenarioInstances",
                columns: new[] { "DbOpponentsObjectId", "DbOpponentsDictionaryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ScenarioInstances_DbModifiedDictionaryEntity<Club>_DbMatchUpsObjectId_DbMatchUpsDictionaryId",
                table: "ScenarioInstances",
                columns: new[] { "DbMatchUpsObjectId", "DbMatchUpsDictionaryId" },
                principalTable: "DbModifiedDictionaryEntity<Club>",
                principalColumns: new[] { "ObjectId", "DictionaryId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScenarioInstances_DbModifiedDictionaryEntity<Pot>_DbOpponentsObjectId_DbOpponentsDictionaryId",
                table: "ScenarioInstances",
                columns: new[] { "DbOpponentsObjectId", "DbOpponentsDictionaryId" },
                principalTable: "DbModifiedDictionaryEntity<Pot>",
                principalColumns: new[] { "ObjectId", "DictionaryId" },
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScenarioInstances_DbModifiedDictionaryEntity<Club>_DbMatchUpsObjectId_DbMatchUpsDictionaryId",
                table: "ScenarioInstances");

            migrationBuilder.DropForeignKey(
                name: "FK_ScenarioInstances_DbModifiedDictionaryEntity<Pot>_DbOpponentsObjectId_DbOpponentsDictionaryId",
                table: "ScenarioInstances");

            migrationBuilder.DropTable(
                name: "DbModifiedDictionaryEntity<Club>");

            migrationBuilder.DropTable(
                name: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropIndex(
                name: "IX_ScenarioInstances_DbMatchUpsObjectId_DbMatchUpsDictionaryId",
                table: "ScenarioInstances");

            migrationBuilder.DropIndex(
                name: "IX_ScenarioInstances_DbOpponentsObjectId_DbOpponentsDictionaryId",
                table: "ScenarioInstances");

            migrationBuilder.DropColumn(
                name: "DbMatchUpsDictionaryId",
                table: "ScenarioInstances");

            migrationBuilder.DropColumn(
                name: "DbMatchUpsObjectId",
                table: "ScenarioInstances");

            migrationBuilder.DropColumn(
                name: "DbOpponentsDictionaryId",
                table: "ScenarioInstances");

            migrationBuilder.DropColumn(
                name: "DbOpponentsObjectId",
                table: "ScenarioInstances");
        }
    }
}
