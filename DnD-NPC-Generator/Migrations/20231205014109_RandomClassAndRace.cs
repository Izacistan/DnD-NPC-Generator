using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD_NPC_Generator.Migrations
{
    /// <inheritdoc />
    public partial class RandomClassAndRace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NPCClasses",
                columns: new[] { "NPCClassId", "Name" },
                values: new object[] { 13, "Random" });

            migrationBuilder.InsertData(
                table: "NPCRaces",
                columns: new[] { "NPCRaceId", "Name" },
                values: new object[] { 10, "Random" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 10);
        }
    }
}
