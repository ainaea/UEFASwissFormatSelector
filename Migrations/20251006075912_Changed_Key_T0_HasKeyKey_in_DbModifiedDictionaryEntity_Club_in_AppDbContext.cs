using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class Changed_Key_T0_HasKeyKey_in_DbModifiedDictionaryEntity_Club_in_AppDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Club>",
                table: "DbModifiedDictionaryEntity<Club>");

            migrationBuilder.AddColumn<Guid>(
                name: "HasKeyKey",
                table: "DbModifiedDictionaryEntity<Pot>",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "HasKeyKey",
                table: "DbModifiedDictionaryEntity<Club>",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>",
                column: "HasKeyKey");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Club>",
                table: "DbModifiedDictionaryEntity<Club>",
                column: "HasKeyKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Club>",
                table: "DbModifiedDictionaryEntity<Club>");

            migrationBuilder.DropColumn(
                name: "HasKeyKey",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.DropColumn(
                name: "HasKeyKey",
                table: "DbModifiedDictionaryEntity<Club>");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>",
                columns: new[] { "ObjectId", "DictionaryId", "ScenarioInstanceId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Club>",
                table: "DbModifiedDictionaryEntity<Club>",
                columns: new[] { "ObjectId", "DictionaryId", "ScenarioInstanceId" });
        }
    }
}
