using Microsoft.AspNetCore.Mvc;
using DnD_NPC_Generator.Models;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using System.Numerics;

namespace DnD_NPC_Generator.Services
{
    public class NPCService

    {
        public List<int> GenerateStats(string choice)
        {
            List<int> StatList = new List<int>();

            switch (choice)
            {
                case "4d6d1":
                    Gen4d6d1(ref StatList);
                    break;
                case "Standard-Array":
                    StandardArray(ref StatList);
                    break;
            }

            return StatList;
        }

        public void ChooseClass(ref NPC npc, List<NPCClass> classes, int choice)
        {
            if (choice != 1)
            {
                npc.NPCClassId = choice;
                npc.NPCClass = classes[choice - 1];
                return;
            }
            Random d12 = new Random();
            int newClass = d12.Next(1, classes.Count());
            npc.NPCClassId = classes.ElementAt(newClass).NPCClassId;
            npc.NPCClass = classes.ElementAt(newClass);
            return;
        }

        public void Gen4d6d1(ref List<int> stats)
        {
            Random dSix = new Random();
            List<int> FourDSix = new List<int>();
            int roll = 0;
            int smallest = 10;
            int stat = 0;

            for (int i = 0; i < 6; i++)//For 6 different stat blocks
            {
                for (int j = 0; j < 4; j++)//Roll 4 d 6
                {
                    roll = dSix.Next(6)+1;//Roll 1 d 6
                    FourDSix.Add(roll);//Add it to the 4d6
                }
                
                foreach (int ele in  FourDSix) //For each dice in the stack
                { 
                    if (ele < smallest)//Check to see if it is smaller than the smallest so far
                    {
                        smallest = ele;//If it is, track that number
                    }

                    stat += ele;//Add the dice to the stat block
                }

                stat -= smallest;//Remove the smallest result from the stat block
                stats.Add(stat);//Add it to the list to return back for character stats
                FourDSix.Clear();//Clear the dice pool in preparation for starting again. 
                //End dice roll loop for one stat block

                stat = 0;
                smallest = 10;
            }
            //End dice roll loop for all stat blocks. Should return referenced list
        }

        public void StandardArray(ref List<int> stats)
        {
            stats.Add(15);
            stats.Add(14);
            stats.Add(13);
            stats.Add(12);
            stats.Add(10);
            stats.Add(8);
        }

        //Call this before setting stats
        public void StatPriorities(ref List<int> stats, string NPCclass)
        {
            //This method will rearrange the order of the stats depending on their priority
            //Initialize for ease of use 
            int strength = 0;
            int dexterity = 0;
            int constitution = 0;
            int intelligence = 0;
            int wisdom = 0;
            int charisma = 0;

            stats.Sort();//Sorted from smallest to largest

            switch (NPCclass)
            {
                case "Barbarian":
                    constitution = stats.ElementAt(0);
                    dexterity = stats.ElementAt(1);
                    strength = stats.ElementAt(2);
                    wisdom = stats.ElementAt(3);
                    charisma = stats.ElementAt(4);
                    intelligence = stats.ElementAt(5);
                    break;

                case "Bard":
                    charisma = stats.ElementAt(0);
                    dexterity = stats.ElementAt(1);
                    constitution = stats.ElementAt(2);
                    wisdom = stats.ElementAt(3);
                    intelligence = stats.ElementAt(4);
                    strength = stats.ElementAt(5);
                    break;

                case "Cleric":
                    wisdom = stats.ElementAt(0);
                    constitution = stats.ElementAt(1);
                    dexterity = stats.ElementAt(2);
                    strength = stats.ElementAt(3);
                    charisma = stats.ElementAt(4);
                    intelligence = stats.ElementAt(5);
                    break;

                case "Druid":
                    wisdom = stats.ElementAt(0);
                    constitution = stats.ElementAt(1);
                    dexterity = stats.ElementAt(2);
                    charisma = stats.ElementAt(3);
                    intelligence = stats.ElementAt(4);
                    strength = stats.ElementAt(5);
                    break;

                case "Fighter":
                    strength = stats.ElementAt(0);
                    constitution = stats.ElementAt(1);
                    wisdom = stats.ElementAt(2);
                    charisma = stats.ElementAt(3);
                    dexterity = stats.ElementAt(4);
                    intelligence = stats.ElementAt(5);
                    break;

                case "Monk":
                    dexterity = stats.ElementAt(0);
                    wisdom = stats.ElementAt(1);
                    constitution = stats.ElementAt(2);
                    intelligence = stats.ElementAt(3);
                    charisma = stats.ElementAt(4);
                    strength = stats.ElementAt(5);
                    break;

                case "Paladin":
                    strength = stats.ElementAt(0);
                    constitution = stats.ElementAt(1);
                    charisma = stats.ElementAt(2);
                    wisdom = stats.ElementAt(3);
                    intelligence = stats.ElementAt(4);
                    dexterity = stats.ElementAt(5);
                    break;

                case "Ranger":
                    dexterity = stats.ElementAt(0);
                    wisdom = stats.ElementAt(1);
                    constitution = stats.ElementAt(2);
                    intelligence = stats.ElementAt(3);
                    strength = stats.ElementAt(4);
                    charisma = stats.ElementAt(5);
                    break;

                case "Rogue":
                    dexterity = stats.ElementAt(0);
                    intelligence = stats.ElementAt(1);
                    constitution = stats.ElementAt(2);
                    charisma = stats.ElementAt(3);
                    wisdom = stats.ElementAt(4);
                    strength = stats.ElementAt(5);
                    break;

                case "Sorcerer":
                    charisma = stats.ElementAt(0);
                    dexterity = stats.ElementAt(1);
                    constitution = stats.ElementAt(2);
                    wisdom = stats.ElementAt(3);
                    intelligence = stats.ElementAt(4);
                    strength = stats.ElementAt(5);
                    break;

                case "Warlock":
                    charisma = stats.ElementAt(0);
                    dexterity = stats.ElementAt(1);
                    constitution = stats.ElementAt(2);
                    wisdom = stats.ElementAt(3);
                    intelligence = stats.ElementAt(4);
                    strength = stats.ElementAt(5);
                    break;

                case "Wizard":
                    intelligence = stats.ElementAt(0);
                    dexterity = stats.ElementAt(1);
                    constitution = stats.ElementAt(2);
                    wisdom = stats.ElementAt(3);
                    charisma = stats.ElementAt(4);
                    strength = stats.ElementAt(5);
                    break;
            }
            stats.Clear();//clear the stats lineup

            //Reinsert into stat lineup in correct order
            stats.Add(strength);
            stats.Add(dexterity);
            stats.Add(constitution);
            stats.Add(intelligence);
            stats.Add(wisdom);
            stats.Add(charisma);
        }

        //Run this prior to anything below.
        public void SetStats(ref NPC NPChar, List<int> stats)
        {
            //Sets score lineup
            NPChar.StrScore = stats.ElementAt(0);
            NPChar.DexScore = stats.ElementAt(1);
            NPChar.ConScore = stats.ElementAt(2);
            NPChar.IntScore = stats.ElementAt(3);
            NPChar.WisScore = stats.ElementAt(4);
            NPChar.ChaScore = stats.ElementAt(5);

            //Sets modifiers
            NPChar.StrMod = (NPChar.StrScore / 2) - 5;
            NPChar.StrSave = NPChar.StrMod;

            NPChar.DexMod = (NPChar.DexScore / 2) - 5;
            NPChar.DexSave = NPChar.DexMod;

            NPChar.ConMod = (NPChar.ConScore / 2) - 5;
            NPChar.ConSave = NPChar.ConMod;

            NPChar.IntMod = (NPChar.IntScore / 2) - 5;
            NPChar.IntSave = NPChar.IntMod;

            NPChar.WisMod = (NPChar.WisScore / 2) - 5;
            NPChar.WisSave = NPChar.WisMod;

            NPChar.ChaMod = (NPChar.ChaScore / 2) - 5;
            NPChar.ChaSave = NPChar.ChaMod;
        }

        //Call this method prior to any stat setting functions
        public void SetProficiencyMod(ref NPC NPChar)
        {
            int ProfMod = 2;
            if (NPChar.Level > 4)
            {
                ProfMod++;
            }
            if (NPChar.Level > 8)
            {
                ProfMod++;
            }
            if (NPChar.Level > 12)
            {
                ProfMod++;
            }
            if (NPChar.Level > 16)
            {
                ProfMod++;
            }
            NPChar.ProfMod = ProfMod;
        }

        //Only run after class, stats, and prof have been set.
        public void SetSaveProficiencies(ref NPC NPChar)
        {
            switch (NPChar.NPCClass.Name)
            {
                case "Barbarian":
                    NPChar.StrSave += NPChar.ProfMod;
                    NPChar.ConSave += NPChar.ProfMod;
                    break;

                case "Bard":
                    NPChar.DexSave += NPChar.ProfMod;
                    NPChar.ChaSave += NPChar.ProfMod;
                    break;

                case "Cleric":
                    NPChar.WisSave += NPChar.ProfMod;
                    NPChar.ConSave += NPChar.ProfMod;
                    break;

                case "Druid":
                    NPChar.IntSave += NPChar.ProfMod;
                    NPChar.WisSave += NPChar.ProfMod;
                    break;

                case "Fighter":
                    NPChar.StrSave += NPChar.ProfMod;
                    NPChar.ConSave += NPChar.ProfMod;
                    break;

                case "Monk":
                    NPChar.StrSave += NPChar.ProfMod;
                    NPChar.DexSave += NPChar.ProfMod;
                    break;

                case "Paladin":
                    NPChar.WisSave += NPChar.ProfMod;
                    NPChar.ChaSave += NPChar.ProfMod;
                    break;

                case "Ranger":
                    NPChar.StrSave += NPChar.ProfMod;
                    NPChar.DexSave += NPChar.ProfMod;
                    break;

                case "Rogue":
                    NPChar.DexSave += NPChar.ProfMod;
                    NPChar.IntSave += NPChar.ProfMod;
                    break;

                case "Sorcerer":
                    NPChar.ConSave += NPChar.ProfMod;
                    NPChar.ChaSave += NPChar.ProfMod;
                    break;

                case "Warlock":
                    NPChar.WisSave += NPChar.ProfMod;
                    NPChar.ChaSave += NPChar.ProfMod;
                    break;

                case "Wizard":
                    NPChar.IntSave += NPChar.ProfMod;
                    NPChar.WisSave += NPChar.ProfMod;
                    break;
            }
        }

        public void SetSubclass(ref NPC NPChar)
        {
            List<string> possibilities = new List<string>();
            switch (NPChar.NPCClass.Name)
            {
                case "Barbarian":
                    possibilities.Add("Berserker");
                    possibilities.Add("Totem Warrior");
                    break;

                case "Bard":
                    possibilities.Add("Lore");
                    possibilities.Add("Valor");
                    break;

                case "Cleric":
                    possibilities.Add("Knowledge");
                    possibilities.Add("Life");
                    possibilities.Add("Light");
                    possibilities.Add("Nature");
                    possibilities.Add("Tempest");
                    possibilities.Add("Trickery");
                    possibilities.Add("War");
                    break;

                case "Druid":
                    possibilities.Add("Land");
                    possibilities.Add("Moon");
                    break;

                case "Fighter":
                    possibilities.Add("Battle Master");
                    possibilities.Add("Champion");
                    possibilities.Add("Eldritch Knight");
                    break;

                case "Monk":
                    possibilities.Add("Shadow");
                    possibilities.Add("Four Elements");
                    possibilities.Add("Open Hand");
                    break;

                case "Paladin":
                    possibilities.Add("Devotion");
                    possibilities.Add("Ancients");
                    possibilities.Add("Vengeance");
                    break;

                case "Ranger":
                    possibilities.Add("Beast Master");
                    possibilities.Add("Hunter");
                    break;

                case "Rogue":
                    possibilities.Add("Arcane Trickster");
                    possibilities.Add("Assassin");
                    possibilities.Add("Thief");
                    break;

                case "Sorcerer":
                    possibilities.Add("Draconic Bloodline");
                    possibilities.Add("Wild Magic");
                    break;

                case "Warlock":
                    possibilities.Add("Archfey");
                    possibilities.Add("Fiend");
                    possibilities.Add("Great Old One");
                    break;

                case "Wizard":
                    possibilities.Add("Abjuration");
                    possibilities.Add("Conjuration");
                    possibilities.Add("Divination");
                    possibilities.Add("Enchantment");
                    possibilities.Add("Evocation");
                    possibilities.Add("Illusion");
                    possibilities.Add("Necromancy");
                    possibilities.Add("Transmutation");
                    break;
                default:
                    possibilities.Add("404 class not found.");
                    break;
            }
            Random subchoice = new Random();
            int roll = subchoice.Next(possibilities.Count());
            NPChar.Subclass = possibilities.ElementAt(roll);
        }

        public void SetFullCasterSlots(ref NPC npc)
        {
            //Initialize spell slots for visibility
            int Cantrips = 0;
            int First = 0;
            int Second = 0;
            int Third = 0;
            int Fourth = 0;
            int Fifth = 0;
            int Sixth = 0;
            int Seventh = 0;
            int Eighth = 0;
            int Nineth = 0;

            //Set starting cantrips
            switch (npc.NPCClass.Name)
            {
                case "Bard":
                    Cantrips = 2;
                    break;
                case "Cleric":
                    Cantrips = 3;
                    break;
                case "Druid":
                    Cantrips = 2;
                    break;
                case "Sorcerer":
                    Cantrips = 4;
                    break;
                case "Wizard":
                    Cantrips = 3;
                    break;
                default: break;
            }

            //Iterate through levels and make changes for each level.
            if (npc.Level >= 1)
            {
                First += 2;
            }
            if (npc.Level >= 2)
            {
                First += 1;
            }
            if (npc.Level >= 3)
            {
                First += 1;
                Second += 2;
            }
            if (npc.Level >= 4)
            {
                Cantrips += 1;
                Second += 1;
            }
            if (npc.Level >= 5)
            {
                Third += 2;
            }
            if (npc.Level >= 6)
            {
                Third += 1;
            }
            if (npc.Level >= 7)
            {
                Fourth += 1;
            }
            if (npc.Level >= 8)
            {
                Fourth += 1;
            }
            if (npc.Level >= 9)
            {
                Fourth += 1;
                Fifth += 1;
            }
            if (npc.Level >= 10)
            {
                Cantrips += 1;
                Fifth += 1;
            }
            if (npc.Level >= 11)
            {
                Fifth += 1;
                Sixth += 1;
            }
            if (npc.Level >= 13)
            {
                Seventh += 1;
            }
            if (npc.Level >= 15)
            {
                Eighth += 1;
            }
            if (npc.Level >= 17)
            {
                Nineth += 1;
            }
            if (npc.Level >= 19)
            {
                Sixth += 1;
            }
            if (npc.Level == 20)
            {
                Seventh += 1;
            }

            npc.SpellSlots.Add(Cantrips);
            npc.SpellSlots.Add(First);
            npc.SpellSlots.Add(Second);
            npc.SpellSlots.Add(Third);
            npc.SpellSlots.Add(Fourth);
            npc.SpellSlots.Add(Fifth);
            npc.SpellSlots.Add(Sixth);
            npc.SpellSlots.Add(Seventh);
            npc.SpellSlots.Add(Eighth);
            npc.SpellSlots.Add(Nineth);
        }

        public void SetPartialCasterSlots(ref NPC npc)
        {
            //Initialize spell slots for visibility
            int Cantrips = 0;
            int First = 0;
            int Second = 0;
            int Third = 0;
            int Fourth = 0;
            int Fifth = 0;

            //Iterate through levels and make changes for each level.
            if (npc.Level >= 2)
            {
                First += 2;
            }
            if (npc.Level >= 3)
            {
                First += 1;
            }
            if (npc.Level >= 5)
            {
                First += 1;
                Second += 2;
            }
            if (npc.Level >= 7)
            {
                Second += 1;
            }
            if (npc.Level >= 9)
            {
                Third += 2;
            }
            if (npc.Level >= 11)
            {
                Third += 1;
            }
            if (npc.Level >= 13)
            {
                Fourth += 1;
            }
            if (npc.Level >= 15)
            {
                Fourth += 1;
            }
            if (npc.Level >= 17)
            {
                Fourth += 1;
                Fifth += 1;
            }
            if (npc.Level >= 19)
            {
                Fifth += 1;
            }

            npc.SpellSlots.Add(Cantrips);
            npc.SpellSlots.Add(First);
            npc.SpellSlots.Add(Second);
            npc.SpellSlots.Add(Third);
            npc.SpellSlots.Add(Fourth);
            npc.SpellSlots.Add(Fifth);
        }
        public void SetArcaneEldritch(ref NPC npc)
        {
            //Initialize spell slots for visibility
            int Cantrips = 0;
            int First = 0;
            int Second = 0;
            int Third = 0;
            int Fourth = 0;

            if (npc.Subclass == "Eldritch Knight")
            {
                Cantrips = 2;
                if (npc.Level >= 10) { Cantrips += 1; }
            }

            //Iterate through levels and make changes for each level.
            if (npc.Level >= 3)
            {
                First += 2;
            }
            if (npc.Level >= 4)
            {
                First += 1;
            }
            if (npc.Level >= 7)
            {
                First += 1;
                Second += 2;
            }
            if (npc.Level >= 10)
            {
                Second += 1;
            }
            if (npc.Level >= 13)
            {
                Third += 2;
            }
            if (npc.Level >= 16)
            {
                Third += 1;
            }
            if (npc.Level >= 19)
            {
                Fourth += 1;
            }

            npc.SpellSlots.Add(Cantrips);
            npc.SpellSlots.Add(First);
            npc.SpellSlots.Add(Second);
            npc.SpellSlots.Add(Third);
            npc.SpellSlots.Add(Fourth);
        }

        public void SetWarlocklCasterSlots(ref NPC npc)
        {
            //Initialize spell slots for visibility
            int Cantrips = 0;
            int First = 0;
            int Second = 0;
            int Third = 0;
            int Fourth = 0;
            int Fifth = 0;

            int Slots = 0;

            //Iterate through levels and make changes for each level.
            if (npc.Level >= 1){ Slots += 1; }
            if (npc.Level >= 2) { Slots += 1; }
            if (npc.Level >= 11) { Slots += 1; }
            if (npc.Level >= 17) { Slots += 1; }

            if (npc.Level < 3) { First = Slots; }
            if (npc.Level >= 3 && npc.Level < 5) { Second = Slots; }
            if (npc.Level >= 5 && npc.Level < 7) { Third = Slots; }
            if (npc.Level >= 7 && npc.Level < 9) { Fourth = Slots; }
            if (npc.Level >= 9) { Fifth = Slots; }

            npc.SpellSlots.Add(Cantrips);
            npc.SpellSlots.Add(First);
            npc.SpellSlots.Add(Second);
            npc.SpellSlots.Add(Third);
            npc.SpellSlots.Add(Fourth);
            npc.SpellSlots.Add(Fifth);
        }

        public void SetSpellSlots(ref NPC npc)
        {
            //For full Casters
            switch (npc.NPCClass.Name)
            {
                case "Wizard":
                    SetFullCasterSlots(ref npc);
                    break;
                case "Sorcerer":
                    SetFullCasterSlots(ref npc);
                    break;
                case "Druid":
                    SetFullCasterSlots(ref npc);
                    break;
                case "Cleric":
                    SetFullCasterSlots(ref npc);
                    break;
                case "Bard":
                    SetFullCasterSlots(ref npc);
                    break;
                case "Warlock":
                    SetWarlocklCasterSlots(ref npc);
                    break;
                default: break;
            }
            //For partial Casters
            switch (npc.NPCClass.Name)
            {
                case "Paladin":
                    SetPartialCasterSlots(ref npc);
                    break;
                case "Ranger":
                    SetPartialCasterSlots(ref npc);
                    break;
                case "Fighter":
                    if (npc.Subclass == "Eldritch Knight")
                    {
                        SetArcaneEldritch(ref npc);
                    }
                    break;
                case "Rogue":
                    if (npc.Subclass == "Arcane Trickster")
                    {
                        SetArcaneEldritch(ref npc);
                    }
                    break;
                default: break;
            }
        }

        public void SetRace(ref NPC npc, List<NPCRace> races, int raceChoice)
        {
            if (raceChoice != 1)
            {
                npc.NPCRace = races.ElementAt(Convert.ToInt32(raceChoice) - 1);
                npc.NPCRaceId = Convert.ToInt32(raceChoice);
            }
            else
            {
                Random diceRoll = new Random();
                int selection = diceRoll.Next(1, races.Count());
                npc.NPCRace = races.ElementAt(selection);
                npc.NPCRaceId = races.ElementAt(selection).NPCRaceId;
            }
        }

        public void SetRaceChanges(ref List<int> stats, NPCRace race)
        {
            int str = 0;
            int dex = 1;
            int con = 2;
            int intel = 3;
            int wis = 4;
            int cha = 5;
            switch (race.NPCRaceId)
            {
                case 2://Dwarf
                    stats[con] += 2;
                    stats[wis] += 1;
                    break;
                case 3://Elf
                    stats[dex] += 2;
                    stats[intel] += 1;
                    break;
                case 4://Halfling
                    stats[dex] += 2;
                    stats[cha] += 1;
                    break;
                case 5://Human
                    for (int i = 0; i < stats.Count; i++)
                    {
                        stats[i] += 1;
                    }
                    break;
                case 6://Dragonborn
                    stats[str] += 2;
                    stats[cha] += 1;
                    break;
                case 7://Gnome
                    stats[intel] += 2;
                    stats[dex] += 1;
                    break;
                case 8://Half-Elf
                    stats[cha] += 2;
                    stats[wis] += 1;
                    stats[con] += 1;
                    break;
                case 9://Half-Orc
                    stats[str] += 2;
                    stats[con] += 1;
                    break;
                case 10://Tiefling
                    stats[cha] += 2;
                    stats[intel] += 1;
                    break;
                default:
                    break;
            }
        }

        public void SetRandomLevel(ref NPC npc)
        {
            Random roller = new Random();
            int level = roller.Next(1, 20);
            npc.Level= level;
        }

        public void GenerateNPC(ref NPC npc, List<NPCClass> classes, List<NPCRace> races, int raceChoice, int classChoice, string statChoice)
        {
            if (npc == null) return;
            //This version should fire if the auto-generate is enabled.
            if (npc.Level == 0) { SetRandomLevel(ref npc); }
            List<int> stats = GenerateStats(statChoice);//Get the stat lineup
            ChooseClass(ref npc, classes, classChoice);//Set the class
            SetRace(ref npc, races, raceChoice);//Set random race
            StatPriorities(ref stats, npc.NPCClass.Name);//Arrange stats by priority
            SetRaceChanges(ref stats, npc.NPCRace);//Make chances based on race selection
            SetProficiencyMod(ref npc);//Set the save proficiency
            SetStats(ref npc, stats);//Set the stats
            SetSaveProficiencies(ref npc);
            SetSubclass(ref npc);
            if (npc.isSpellcaster)
            {
                SetSpellSlots(ref npc);
            }
        }
    }
} 
