using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD_NPC_Generator.Migrations
{
    /// <inheritdoc />
    public partial class ChangeClassAndRaceOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 1,
                column: "Name",
                value: "Random");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 2,
                column: "Name",
                value: "Barbarian");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 3,
                column: "Name",
                value: "Bard");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 4,
                column: "Name",
                value: "Cleric");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 5,
                column: "Name",
                value: "Druid");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 6,
                column: "Name",
                value: "Fighter");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 7,
                column: "Name",
                value: "Monk");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 8,
                column: "Name",
                value: "Paladin");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 9,
                column: "Name",
                value: "Ranger");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 10,
                column: "Name",
                value: "Rogue");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 11,
                column: "Name",
                value: "Sorcerer");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 12,
                column: "Name",
                value: "Warlock");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 13,
                column: "Name",
                value: "Wizard");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 1,
                column: "Name",
                value: "Random");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 2,
                column: "Name",
                value: "Dwarf");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 3,
                column: "Name",
                value: "Elf");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 4,
                column: "Name",
                value: "Halfling");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 5,
                column: "Name",
                value: "Human");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 6,
                column: "Name",
                value: "Dragonborn");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 7,
                column: "Name",
                value: "Gnome");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 8,
                column: "Name",
                value: "Half-Elf");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 9,
                column: "Name",
                value: "Half-Orc");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 10,
                column: "Name",
                value: "Tiefling");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 1,
                column: "Name",
                value: "Barbarian");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 2,
                column: "Name",
                value: "Bard");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 3,
                column: "Name",
                value: "Cleric");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 4,
                column: "Name",
                value: "Druid");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 5,
                column: "Name",
                value: "Fighter");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 6,
                column: "Name",
                value: "Monk");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 7,
                column: "Name",
                value: "Paladin");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 8,
                column: "Name",
                value: "Ranger");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 9,
                column: "Name",
                value: "Rogue");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 10,
                column: "Name",
                value: "Sorcerer");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 11,
                column: "Name",
                value: "Warlock");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 12,
                column: "Name",
                value: "Wizard");

            migrationBuilder.UpdateData(
                table: "NPCClasses",
                keyColumn: "NPCClassId",
                keyValue: 13,
                column: "Name",
                value: "Random");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 1,
                column: "Name",
                value: "Dwarf");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 2,
                column: "Name",
                value: "Elf");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 3,
                column: "Name",
                value: "Halfling");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 4,
                column: "Name",
                value: "Human");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 5,
                column: "Name",
                value: "Dragonborn");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 6,
                column: "Name",
                value: "Gnome");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 7,
                column: "Name",
                value: "Half-Elf");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 8,
                column: "Name",
                value: "Half-Orc");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 9,
                column: "Name",
                value: "Tiefling");

            migrationBuilder.UpdateData(
                table: "NPCRaces",
                keyColumn: "NPCRaceId",
                keyValue: 10,
                column: "Name",
                value: "Random");
        }
    }
}
