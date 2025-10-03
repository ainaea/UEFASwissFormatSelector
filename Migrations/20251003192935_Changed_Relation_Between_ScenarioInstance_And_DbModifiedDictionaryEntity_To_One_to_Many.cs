using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class Changed_Relation_Between_ScenarioInstance_And_DbModifiedDictionaryEntity_To_One_to_Many : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DbModifiedDictionaryEntity<Pot>_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropIndex(
                name: "IX_DbModifiedDictionaryEntity<Club>_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Club>");

            migrationBuilder.AddColumn<Guid>(
                name: "ScenarioInstanceId1",
                table: "DbModifiedDictionaryEntity<Pot>",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ScenarioInstanceId1",
                table: "DbModifiedDictionaryEntity<Club>",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbModifiedDictionaryEntity<Pot>_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Pot>",
                column: "ScenarioInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_DbModifiedDictionaryEntity<Pot>_ScenarioInstanceId1",
                table: "DbModifiedDictionaryEntity<Pot>",
                column: "ScenarioInstanceId1",
                unique: true,
                filter: "[ScenarioInstanceId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DbModifiedDictionaryEntity<Club>_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Club>",
                column: "ScenarioInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_DbModifiedDictionaryEntity<Club>_ScenarioInstanceId1",
                table: "DbModifiedDictionaryEntity<Club>",
                column: "ScenarioInstanceId1",
                unique: true,
                filter: "[ScenarioInstanceId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_DbModifiedDictionaryEntity<Club>_ScenarioInstances_ScenarioInstanceId1",
                table: "DbModifiedDictionaryEntity<Club>",
                column: "ScenarioInstanceId1",
                principalTable: "ScenarioInstances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DbModifiedDictionaryEntity<Pot>_ScenarioInstances_ScenarioInstanceId1",
                table: "DbModifiedDictionaryEntity<Pot>",
                column: "ScenarioInstanceId1",
                principalTable: "ScenarioInstances",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbModifiedDictionaryEntity<Club>_ScenarioInstances_ScenarioInstanceId1",
                table: "DbModifiedDictionaryEntity<Club>");

            migrationBuilder.DropForeignKey(
                name: "FK_DbModifiedDictionaryEntity<Pot>_ScenarioInstances_ScenarioInstanceId1",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropIndex(
                name: "IX_DbModifiedDictionaryEntity<Pot>_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropIndex(
                name: "IX_DbModifiedDictionaryEntity<Pot>_ScenarioInstanceId1",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropIndex(
                name: "IX_DbModifiedDictionaryEntity<Club>_ScenarioInstanceId",
                table: "DbModifiedDictionaryEntity<Club>");

            migrationBuilder.DropIndex(
                name: "IX_DbModifiedDictionaryEntity<Club>_ScenarioInstanceId1",
                table: "DbModifiedDictionaryEntity<Club>");

            migrationBuilder.DropColumn(
                name: "ScenarioInstanceId1",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropColumn(
                name: "ScenarioInstanceId1",
                table: "DbModifiedDictionaryEntity<Club>");

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
        }
    }
}
