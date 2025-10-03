using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class Added_virtual_ScenarioInstance_to_DbModifiedDictionaryEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScenarioInstances_DbModifiedDictionaryEntity<Club>_DbMatchUpsObjectId_DbMatchUpsDictionaryId",
                table: "ScenarioInstances");

            migrationBuilder.DropForeignKey(
                name: "FK_ScenarioInstances_DbModifiedDictionaryEntity<Pot>_DbOpponentsObjectId_DbOpponentsDictionaryId",
                table: "ScenarioInstances");

            migrationBuilder.DropIndex(
                name: "IX_ScenarioInstances_DbMatchUpsObjectId_DbMatchUpsDictionaryId",
                table: "ScenarioInstances");

            migrationBuilder.DropIndex(
                name: "IX_ScenarioInstances_DbOpponentsObjectId_DbOpponentsDictionaryId",
                table: "ScenarioInstances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Club>",
                table: "DbModifiedDictionaryEntity<Club>");

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

            migrationBuilder.AddColumn<Guid>(
                name: "ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Pot>",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Club>",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>",
                columns: new[] { "ObjectId", "DictionaryId", "ScenarioInstanceId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Club>",
                table: "DbModifiedDictionaryEntity<Club>",
                columns: new[] { "ObjectId", "DictionaryId", "ScenarioInstanceId" });

            migrationBuilder.CreateIndex(
                name: "IX_DbModifiedDictionaryEntity<Pot>_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Pot>",
                column: "ScenarioInstanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbModifiedDictionaryEntity<Club>_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Club>",
                column: "ScenarioInstanceId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DbModifiedDictionaryEntity<Club>_ScenarioInstances_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Club>",
                column: "ScenarioInstanceId",
                principalTable: "ScenarioInstances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DbModifiedDictionaryEntity<Pot>_ScenarioInstances_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Pot>",
                column: "ScenarioInstanceId",
                principalTable: "ScenarioInstances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbModifiedDictionaryEntity<Club>_ScenarioInstances_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Club>");

            migrationBuilder.DropForeignKey(
                name: "FK_DbModifiedDictionaryEntity<Pot>_ScenarioInstances_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropIndex(
                name: "IX_DbModifiedDictionaryEntity<Pot>_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Club>",
                table: "DbModifiedDictionaryEntity<Club>");

            migrationBuilder.DropIndex(
                name: "IX_DbModifiedDictionaryEntity<Club>_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Club>");

            migrationBuilder.DropColumn(
                name: "ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropColumn(
                name: "ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Club>");

            migrationBuilder.AddColumn<Guid>(
                name: "DbMatchUpsDictionaryId",
                table: "ScenarioInstances",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DbMatchUpsObjectId",
                table: "ScenarioInstances",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DbOpponentsDictionaryId",
                table: "ScenarioInstances",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DbOpponentsObjectId",
                table: "ScenarioInstances",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>",
                columns: new[] { "ObjectId", "DictionaryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Club>",
                table: "DbModifiedDictionaryEntity<Club>",
                columns: new[] { "ObjectId", "DictionaryId" });

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
    }
}
