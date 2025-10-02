using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class Created_Standalone_Entity_For_Each_Dictionary_Type : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MatchUpSkeleton",
                table: "ScenarioInstances");

            migrationBuilder.DropColumn(
                name: "MatchUps",
                table: "ScenarioInstances");

            migrationBuilder.DropColumn(
                name: "Opponents",
                table: "ScenarioInstances");

            migrationBuilder.CreateTable(
                name: "ModifiedDictionary<IEnumerable<Pot>>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioInstanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModifiedDictionary<IEnumerable<Pot>>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModifiedDictionary<IEnumerable<Pot>>_ScenarioInstances_ScenarioInstanceId",
                        column: x => x.ScenarioInstanceId,
                        principalTable: "ScenarioInstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModifiedDictionary<List<Club>>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioInstanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModifiedDictionary<List<Club>>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModifiedDictionary<List<Club>>_ScenarioInstances_ScenarioInstanceId",
                        column: x => x.ScenarioInstanceId,
                        principalTable: "ScenarioInstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModifiedDictionary<List<string>>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioInstanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModifiedDictionary<List<string>>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModifiedDictionary<List<string>>_ScenarioInstances_ScenarioInstanceId",
                        column: x => x.ScenarioInstanceId,
                        principalTable: "ScenarioInstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModifiedDictionary<IEnumerable<Pot>>_ScenarioInstanceId",
                table: "ModifiedDictionary<IEnumerable<Pot>>",
                column: "ScenarioInstanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModifiedDictionary<List<Club>>_ScenarioInstanceId",
                table: "ModifiedDictionary<List<Club>>",
                column: "ScenarioInstanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModifiedDictionary<List<string>>_ScenarioInstanceId",
                table: "ModifiedDictionary<List<string>>",
                column: "ScenarioInstanceId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModifiedDictionary<IEnumerable<Pot>>");

            migrationBuilder.DropTable(
                name: "ModifiedDictionary<List<Club>>");

            migrationBuilder.DropTable(
                name: "ModifiedDictionary<List<string>>");

            migrationBuilder.AddColumn<string>(
                name: "MatchUpSkeleton",
                table: "ScenarioInstances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchUps",
                table: "ScenarioInstances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Opponents",
                table: "ScenarioInstances",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
