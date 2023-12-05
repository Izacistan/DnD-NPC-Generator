using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD_NPC_Generator.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTestNPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NPCs",
                keyColumn: "NPCId",
                keyValue: 1,
                columns: new[] { "NPCClassId", "NPCRaceId" },
                values: new object[] { 2, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NPCs",
                keyColumn: "NPCId",
                keyValue: 1,
                columns: new[] { "NPCClassId", "NPCRaceId" },
                values: new object[] { 1, 4 });
        }
    }
}
