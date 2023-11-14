using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DnD_NPC_Generator.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NPCClasses",
                columns: table => new
                {
                    NPCClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCClasses", x => x.NPCClassId);
                });

            migrationBuilder.CreateTable(
                name: "NPCRaces",
                columns: table => new
                {
                    NPCRaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCRaces", x => x.NPCRaceId);
                });

            migrationBuilder.CreateTable(
                name: "NPCs",
                columns: table => new
                {
                    NPCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NPCClassId = table.Column<int>(type: "int", nullable: false),
                    NPCRaceId = table.Column<int>(type: "int", nullable: false),
                    Subclass = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    IPSurvival = table.Column<bool>(type: "bit", nullable: false),
                    IEAcrobatics = table.Column<bool>(type: "bit", nullable: false),
                    IEAnimalHandling = table.Column<bool>(type: "bit", nullable: false),
                    IEArcana = table.Column<bool>(type: "bit", nullable: false),
                    IEAthletic = table.Column<bool>(type: "bit", nullable: false),
                    IEDeception = table.Column<bool>(type: "bit", nullable: false),
                    IEHistory = table.Column<bool>(type: "bit", nullable: false),
                    IEInsight = table.Column<bool>(type: "bit", nullable: false),
                    IEIntimidation = table.Column<bool>(type: "bit", nullable: false),
                    IEInvestigation = table.Column<bool>(type: "bit", nullable: false),
                    IEMedicine = table.Column<bool>(type: "bit", nullable: false),
                    IENature = table.Column<bool>(type: "bit", nullable: false),
                    IEPerception = table.Column<bool>(type: "bit", nullable: false),
                    IEPerformance = table.Column<bool>(type: "bit", nullable: false),
                    IEPersuasion = table.Column<bool>(type: "bit", nullable: false),
                    IEReligion = table.Column<bool>(type: "bit", nullable: false),
                    IESleightOfHand = table.Column<bool>(type: "bit", nullable: false),
                    IEStealth = table.Column<bool>(type: "bit", nullable: false),
                    IESurvival = table.Column<bool>(type: "bit", nullable: false),
                    isSpellcaster = table.Column<bool>(type: "bit", nullable: false),
                    spellData = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCs", x => x.NPCId);
                    table.ForeignKey(
                        name: "FK_NPCs_NPCClasses_NPCClassId",
                        column: x => x.NPCClassId,
                        principalTable: "NPCClasses",
                        principalColumn: "NPCClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NPCs_NPCRaces_NPCRaceId",
                        column: x => x.NPCRaceId,
                        principalTable: "NPCRaces",
                        principalColumn: "NPCRaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "NPCClasses",
                columns: new[] { "NPCClassId", "Name" },
                values: new object[,]
                {
                    { 1, "Barbarian" },
                    { 2, "Bard" },
                    { 3, "Cleric" },
                    { 4, "Druid" },
                    { 5, "Fighter" },
                    { 6, "Monk" },
                    { 7, "Paladin" },
                    { 8, "Ranger" },
                    { 9, "Rogue" },
                    { 10, "Sorcerer" },
                    { 11, "Warlock" },
                    { 12, "Wizard" }
                });

            migrationBuilder.InsertData(
                table: "NPCRaces",
                columns: new[] { "NPCRaceId", "Name" },
                values: new object[,]
                {
                    { 1, "Dwarf" },
                    { 2, "Elf" },
                    { 3, "Halfling" },
                    { 4, "Human" },
                    { 5, "Dragonborn" },
                    { 6, "Gnome" },
                    { 7, "Half-Elf" },
                    { 8, "Half-Orc" },
                    { 9, "Tiefling" }
                });

            migrationBuilder.InsertData(
                table: "NPCs",
                columns: new[] { "NPCId", "AC", "ChaMod", "ChaSave", "ChaScore", "ConMod", "ConSave", "ConScore", "DexMod", "DexSave", "DexScore", "HitDie", "HitDieCount", "HitPoints", "IEAcrobatics", "IEAnimalHandling", "IEArcana", "IEAthletic", "IEDeception", "IEHistory", "IEInsight", "IEIntimidation", "IEInvestigation", "IEMedicine", "IENature", "IEPerception", "IEPerformance", "IEPersuasion", "IEReligion", "IESleightOfHand", "IEStealth", "IESurvival", "IPAcrobatics", "IPAnimalHandling", "IPArcana", "IPAthletic", "IPDeception", "IPHistory", "IPInsight", "IPIntimidation", "IPInvestigation", "IPMedicine", "IPNature", "IPPerception", "IPPerformance", "IPPersuasion", "IPReligion", "IPSleightOfHand", "IPStealth", "IPSurvival", "IntMod", "IntSave", "IntScore", "Level", "NPCClassId", "NPCRaceId", "Name", "ProfMod", "StrMod", "StrSave", "StrScore", "Subclass", "WisMod", "WisSave", "WisScore", "isSpellcaster", "spellData" },
                values: new object[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 0, 0, 0, 1, 1, 4, "Test NPC", 0, 0, 0, 0, "", 0, 0, 0, false, "" });

            migrationBuilder.CreateIndex(
                name: "IX_NPCs_NPCClassId",
                table: "NPCs",
                column: "NPCClassId");

            migrationBuilder.CreateIndex(
                name: "IX_NPCs_NPCRaceId",
                table: "NPCs",
                column: "NPCRaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NPCs");

            migrationBuilder.DropTable(
                name: "NPCClasses");

            migrationBuilder.DropTable(
                name: "NPCRaces");
        }
    }
}
