using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class Changed_Key_T0_HasKeyKey_AND_ObjectId_DictionaryId_ScenarioInstanceId_in_DbModifiedDictionaryEntity_Club_in_AppDbContext3 : Migration
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>",
                columns: new[] { "HasKeyKey", "ObjectId", "DictionaryId", "ScenarioInstanceId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Club>",
                table: "DbModifiedDictionaryEntity<Club>",
                columns: new[] { "HasKeyKey", "ObjectId", "DictionaryId", "ScenarioInstanceId" });
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>",
                column: "HasKeyKey");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Club>",
                table: "DbModifiedDictionaryEntity<Club>",
                column: "HasKeyKey");
        }
    }
}
