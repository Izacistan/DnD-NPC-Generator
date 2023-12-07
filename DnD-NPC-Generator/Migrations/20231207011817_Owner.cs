using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD_NPC_Generator.Migrations
{
    public partial class Owner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NPCs",
                keyColumn: "NPCId",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "NPCs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "NPCs");

            migrationBuilder.InsertData(
                table: "NPCs",
                columns: new[] { "NPCId", "AC", "ChaMod", "ChaSave", "ChaScore", "ConMod", "ConSave", "ConScore", "DexMod", "DexSave", "DexScore", "HitDie", "HitDieCount", "HitPoints", "IEAcrobatics", "IEAnimalHandling", "IEArcana", "IEAthletic", "IEDeception", "IEHistory", "IEInsight", "IEIntimidation", "IEInvestigation", "IEMedicine", "IENature", "IEPerception", "IEPerformance", "IEPersuasion", "IEReligion", "IESleightOfHand", "IEStealth", "IESurvival", "IPAcrobatics", "IPAnimalHandling", "IPArcana", "IPAthletic", "IPDeception", "IPHistory", "IPInsight", "IPIntimidation", "IPInvestigation", "IPMedicine", "IPNature", "IPPerception", "IPPerformance", "IPPersuasion", "IPReligion", "IPSleightOfHand", "IPStealth", "IPSurvival", "IntMod", "IntSave", "IntScore", "Level", "NPCClassId", "NPCRaceId", "Name", "ProfMod", "StrMod", "StrSave", "StrScore", "Subclass", "UserId", "WisMod", "WisSave", "WisScore", "isSpellcaster", "spellData" },
                values: new object[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 0, 0, 0, 1, 2, 5, "Test NPC", 0, 0, 0, 0, "", null, 0, 0, 0, false, "" });
        }
    }
}
