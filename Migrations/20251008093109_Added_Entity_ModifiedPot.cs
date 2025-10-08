using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UEFASwissFormatSelector.Migrations
{
    /// <inheritdoc />
    public partial class Added_Entity_ModifiedPot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Pots",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Pots");
        }
    }
}
