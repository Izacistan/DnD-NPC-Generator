using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnD_NPC_Generator.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NPCs",
                columns: table => new
                {
                    NPCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HitPoints = table.Column<int>(type: "int", nullable: false),
                    HitDie = table.Column<int>(type: "int", nullable: false),
                    HitDieCount = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    AC = table.Column<int>(type: "int", nullable: false),
                    ProfMod = table.Column<int>(type: "int", nullable: false),
                    StrScore = table.Column<int>(type: "int", nullable: false),
                    StrMod = table.Column<int>(type: "int", nullable: false),
                    StrSave = table.Column<int>(type: "int", nullable: false),
                    DexScore = table.Column<int>(type: "int", nullable: false),
                    DexMod = table.Column<int>(type: "int", nullable: false),
                    DexSave = table.Column<int>(type: "int", nullable: false),
                    ConScore = table.Column<int>(type: "int", nullable: false),
                    ConMod = table.Column<int>(type: "int", nullable: false),
                    ConSave = table.Column<int>(type: "int", nullable: false),
                    IntScore = table.Column<int>(type: "int", nullable: false),
                    IntMod = table.Column<int>(type: "int", nullable: false),
                    IntSave = table.Column<int>(type: "int", nullable: false),
                    WisScore = table.Column<int>(type: "int", nullable: false),
                    WisMod = table.Column<int>(type: "int", nullable: false),
                    WisSave = table.Column<int>(type: "int", nullable: false),
                    ChaScore = table.Column<int>(type: "int", nullable: false),
                    ChaMod = table.Column<int>(type: "int", nullable: false),
                    ChaSave = table.Column<int>(type: "int", nullable: false),
                    IPAcrobatics = table.Column<bool>(type: "bit", nullable: false),
                    IPAnimalHandling = table.Column<bool>(type: "bit", nullable: false),
                    IPArcana = table.Column<bool>(type: "bit", nullable: false),
                    IPAthletic = table.Column<bool>(type: "bit", nullable: false),
                    IPDeception = table.Column<bool>(type: "bit", nullable: false),
                    IPHistory = table.Column<bool>(type: "bit", nullable: false),
                    IPInsight = table.Column<bool>(type: "bit", nullable: false),
                    IPIntimidation = table.Column<bool>(type: "bit", nullable: false),
                    IPInvestigation = table.Column<bool>(type: "bit", nullable: false),
                    IPMedicine = table.Column<bool>(type: "bit", nullable: false),
                    IPNature = table.Column<bool>(type: "bit", nullable: false),
                    IPPerception = table.Column<bool>(type: "bit", nullable: false),
                    IPPerformance = table.Column<bool>(type: "bit", nullable: false),
                    IPPersuasion = table.Column<bool>(type: "bit", nullable: false),
                    IPReligion = table.Column<bool>(type: "bit", nullable: false),
                    IPSleightOfHand = table.Column<bool>(type: "bit", nullable: false),
                    IPStealth = table.Column<bool>(type: "bit", nullable: false),
                    IPSurvival = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCs", x => x.NPCId);
                });

            migrationBuilder.InsertData(
                table: "NPCs",
                columns: new[] { "NPCId", "AC", "ChaMod", "ChaSave", "ChaScore", "Class", "ConMod", "ConSave", "ConScore", "DexMod", "DexSave", "DexScore", "HitDie", "HitDieCount", "HitPoints", "IPAcrobatics", "IPAnimalHandling", "IPArcana", "IPAthletic", "IPDeception", "IPHistory", "IPInsight", "IPIntimidation", "IPInvestigation", "IPMedicine", "IPNature", "IPPerception", "IPPerformance", "IPPersuasion", "IPReligion", "IPSleightOfHand", "IPStealth", "IPSurvival", "IntMod", "IntSave", "IntScore", "Level", "Name", "ProfMod", "Race", "StrMod", "StrSave", "StrScore", "WisMod", "WisSave", "WisScore" },
                values: new object[] { 1, 0, 0, 0, 0, "Barbarian", 0, 0, 0, 0, 0, 0, 0, 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 0, 0, 0, 1, "Test NPC", 0, "Human", 0, 0, 0, 0, 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NPCs");
        }
    }
}
