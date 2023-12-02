using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using DnD_NPC_Generator.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace DnD_NPC_Generator.Models
{
    public class NPC
    {
        //General Information
        public int NPCId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;
        public int NPCClassId { get; set; }

        [ValidateNever]
        public NPCClass NPCClass { get; set; }
        public int NPCRaceId { get; set; }

        [ValidateNever]
        public NPCRace NPCRace { get; set; }

        public string Subclass { get; set; } = string.Empty;

        public int HitPoints { get; set; }
        public int HitDie { get; set; }
        public int HitDieCount { get; set; }

        [Required(ErrorMessage = "Please enter a level.")]
        [Range(0, 20, ErrorMessage = "The NPC level must be between 1 and 20 (or 0 if you'd like it to be random).")]
        public int Level { get; set; }
        public int AC { get; set; }
        public int ProfMod { get; set; } //Proficiency Modifier

        //Base Sats, their modifiers, and saves.
        //Strength
        public int StrScore { get; set; }
        public int StrMod { get; set; }
        public int StrSave { get; set; }

        //Dexterity
        public int DexScore { get; set; }
        public int DexMod { get; set; }
        public int DexSave { get; set; }

        //Constitution
        public int ConScore { get; set; }
        public int ConMod { get; set; }
        public int ConSave { get; set; }

        //Intelligence
        public int IntScore { get; set; }
        public int IntMod { get; set; }
        public int IntSave { get; set; }

        //WIsdom
        public int WisScore { get; set; }
        public int WisMod { get; set; }
        public int WisSave { get; set; }

        //Charisma
        public int ChaScore { get; set; }
        public int ChaMod { get; set; }
        public int ChaSave { get; set; }

        //IP = Is Proficient
        public bool IPAcrobatics { get; set; } = false;
        public bool IPAnimalHandling { get; set; } = false;
        public bool IPArcana { get; set; } = false;
        public bool IPAthletic { get; set; } = false;
        public bool IPDeception { get; set; } = false;
        public bool IPHistory { get; set; } = false;
        public bool IPInsight { get; set; } = false;
        public bool IPIntimidation { get; set; } = false;
        public bool IPInvestigation { get; set; } = false;
        public bool IPMedicine { get; set; } = false;
        public bool IPNature { get; set; } = false;
        public bool IPPerception { get; set; } = false;
        public bool IPPerformance { get; set; } = false;
        public bool IPPersuasion { get; set; } = false;
        public bool IPReligion { get; set; } = false;
        public bool IPSleightOfHand { get; set; } = false;
        public bool IPStealth { get; set; } = false;
        public bool IPSurvival { get; set; } = false;


        //IE = Is Expert
        public bool IEAcrobatics { get; set; } = false;
        public bool IEAnimalHandling { get; set; } = false;
        public bool IEArcana { get; set; } = false;
        public bool IEAthletic { get; set; } = false;
        public bool IEDeception { get; set; } = false;
        public bool IEHistory { get; set; } = false;
        public bool IEInsight { get; set; } = false;
        public bool IEIntimidation { get; set; } = false;
        public bool IEInvestigation { get; set; } = false;
        public bool IEMedicine { get; set; } = false;
        public bool IENature { get; set; } = false;
        public bool IEPerception { get; set; } = false;
        public bool IEPerformance { get; set; } = false;
        public bool IEPersuasion { get; set; } = false;
        public bool IEReligion { get; set; } = false;
        public bool IESleightOfHand { get; set; } = false;
        public bool IEStealth { get; set; } = false;
        public bool IESurvival { get; set; } = false;

        //Spell Information
        public bool isSpellcaster { get; set; } = false;

        [NotMapped]
        public List<int> SpellSlots { get; set; } = null!;

        public string spellData { get; set; } = string.Empty; //Store JSON spell data in here (slots, known spells, Spellbook)

        public void UpdateSpellData()
        {
            // Example spell data
            var knownSpells = new List<int> { 1, 2, 3 };
            var spellSlots = new List<int> { 4, 5, 6 };
            var spellBook = new List<string> { "Fireball", "Magic Missile", "Healing Word" };

            // Serialize Spell JSON data for storage in spellData string
            spellData = JsonConvert.SerializeObject(new { KnownSpells = knownSpells, SpellSlots = spellSlots, SpellBook = spellBook });
        }

        public void LoadSpellData()
        {
            // Deserialize the JSON string back to the original data structure
            var deserializedData = JsonConvert.DeserializeAnonymousType(spellData, new { KnownSpells = new List<int>(), SpellSlots = new List<int>(), SpellBook = new List<string>() });

            // Access deserialized data as needed
            Spells = new List<string>(deserializedData.SpellBook);
        }

        [NotMapped]
        public List<string> Spells { get; set; }

        public NPC() { }
    }
}

