using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD_NPC_Generator.Migrations
{
    /// <inheritdoc />
    public partial class Spells : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subclass",
                table: "NPCs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isSpellcaster",
                table: "NPCs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "spellData",
                table: "NPCs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "NPCs",
                keyColumn: "NPCId",
                keyValue: 1,
                columns: new[] { "Subclass", "isSpellcaster", "spellData" },
                values: new object[] { "", false, "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subclass",
                table: "NPCs");

            migrationBuilder.DropColumn(
                name: "isSpellcaster",
                table: "NPCs");

            migrationBuilder.DropColumn(
                name: "spellData",
                table: "NPCs");
        }
    }
}
