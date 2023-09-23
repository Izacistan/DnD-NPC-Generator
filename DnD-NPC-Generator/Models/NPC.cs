using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DnD_NPC_Generator.Models
{
    public class NPC
    {
        //General Information
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Race { get; set; } = string.Empty;
        public int HitPoints { get; set; }
        public int HitDie { get; set; }
        public int HitDieCount { get; set; }
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
        public bool IPAcrobatics { get; set; }
        public bool IPAnimalHandling { get; set; }
        public bool IPArcana { get; set; }
        public bool IPAtheltics { get; set; }
        public bool IPDeception { get; set; }
        public bool IPHistory { get; set; }
        public bool IPInsight { get; set; }
        public bool IPIntimidation { get; set; }
        public bool IPInvestigation { get; set; }
        public bool IPMedicine { get; set; }
        public bool IPNature { get; set; }
        public bool IPPerception { get; set; }
        public bool IPPerformance { get; set; }
        public bool IPPersuasion { get; set; }
        public bool IPReligion { get; set; }
        public bool IPSleightOfHand { get; set; }
        public bool IPStealth { get; set; }
        public bool IPSurvival { get; set; }
        public NPC() { }
    }
}

