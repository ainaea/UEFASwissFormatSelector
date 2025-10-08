using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class Changed_Key_T0_HasKeyKey_in_DbModifiedDictionaryEntity_Club_in_AppDbContext3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>",
                column: "HasKeyKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbModifiedDictionaryEntity<Pot>",
                table: "DbModifiedDictionaryEntity<Pot>",
                columns: new[] { "ObjectId", "DictionaryId", "ScenarioInstanceId" });
        }
    }
}
