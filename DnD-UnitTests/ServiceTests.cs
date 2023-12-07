/*
 * Author: Trevor Stewart
 * Date: 12/7/2023
 * Notes: This is intended to test the different functions for the service class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DnD_NPC_Generator.Services;
using DnD_NPC_Generator.Models;

namespace DnD_UnitTests
{
    public class ServiceTests
    {
        //Set up classes for testing
        public List<NPCClass> classes = new List<NPCClass>() {
                new NPCClass { NPCClassId = 1, Name = "Random" },
                new NPCClass { NPCClassId = 2, Name = "Barbarian" },
                new NPCClass { NPCClassId = 3, Name = "Bard" },
                new NPCClass { NPCClassId = 4, Name = "Cleric" },
                new NPCClass { NPCClassId = 5, Name = "Druid" },
                new NPCClass { NPCClassId = 6, Name = "Fighter" },
                new NPCClass { NPCClassId = 7, Name = "Monk" },
                new NPCClass { NPCClassId = 8, Name = "Paladin" },
                new NPCClass { NPCClassId = 9, Name = "Ranger" },
                new NPCClass { NPCClassId = 10, Name = "Rogue" },
                new NPCClass { NPCClassId = 11, Name = "Sorcerer" },
                new NPCClass { NPCClassId = 12, Name = "Warlock" },
                new NPCClass { NPCClassId = 13, Name = "Wizard" }
        };

        //Set up races for testing
        public List<NPCRace> races = new List<NPCRace>() {
                new NPCRace { NPCRaceId = 1, Name = "Random" },
                new NPCRace { NPCRaceId = 2, Name = "Dwarf"},
                new NPCRace { NPCRaceId = 3, Name = "Elf" },
                new NPCRace { NPCRaceId = 4, Name = "Halfling" },
                new NPCRace { NPCRaceId = 5, Name = "Human" },
                new NPCRace { NPCRaceId = 6, Name = "Dragonborn" },
                new NPCRace { NPCRaceId = 7, Name = "Gnome" },
                new NPCRace { NPCRaceId = 8, Name = "Half-Elf" },
                new NPCRace { NPCRaceId = 9, Name = "Half-Orc" },
                new NPCRace { NPCRaceId = 10, Name = "Tiefling" }
        };

        [Fact]
        public void TestStatGeneration()
        {
            //Arange
            var stats = new List<int>();
            var service = new NPCService();
            var choice = "Standard-Array";

            //Act
            stats = service.GenerateStats(choice);

            //Assert
            Assert.NotNull(stats);
            Assert.Equal(6, stats.Count());
            Assert.Equal(15, stats.ElementAt(0));
            Assert.Equal(8, stats.ElementAt(5));
        }

        [Fact]
        public void TestChooseClass()
        {
            //Arrange
            var npc = new NPC();
            var choice = 6;
            var service = new NPCService();

            //Act
            service.ChooseClass(ref npc, classes, choice);

            //Assert
            Assert.Equal(6, npc.NPCClassId);
            Assert.Equal("Fighter", npc.NPCClass.Name);
        }

        [Fact]
        public void TestStatPriorties()
        {
            //Arrange
            var stats = new List<int>();
            var npc = new NPC();
            var classchoice = 5;
            var service = new NPCService();
            var statchoice = "Standard-Array";
            var goalStats = new List<int>() { 8, 13, 14, 10, 15, 12 };

            //Act
            stats = service.GenerateStats(statchoice);
            service.ChooseClass(ref npc, classes, classchoice);
            service.StatPriorities(ref stats, npc.NPCClass.Name);

            //Assert
            Assert.Equal(stats, goalStats);
        }

        [Fact]
        public void TestSetStats()
        {
            //Arrange
            var stats = new List<int>() { 8, 13, 14, 10, 15, 12 };
            var npc = new NPC();
            var service = new NPCService();

            //Act
            service.SetStats(ref npc, stats);

            //Assert
            //Stat Scores
            Assert.Equal(stats[0], npc.StrScore);
            Assert.Equal(stats[1], npc.DexScore);
            Assert.Equal(stats[2], npc.ConScore);
            Assert.Equal(stats[3], npc.IntScore);
            Assert.Equal(stats[4], npc.WisScore);
            Assert.Equal(stats[5], npc.ChaScore);

            //Stat Mods
            Assert.Equal(-1, npc.StrMod);
            Assert.Equal(1, npc.DexMod);
            Assert.Equal(2, npc.ConMod);
            Assert.Equal(0, npc.IntMod);
            Assert.Equal(2, npc.WisMod);
            Assert.Equal(1, npc.ChaMod);
        }

        [Fact]
        public void TestSetRace()
        {
            //Arrange
            var npc = new NPC();
            var service = new NPCService();
            var choice = 4;

            //Act
            service.SetRace(ref npc, races, choice);

            //Assert
            Assert.Equal(4, npc.NPCRaceId);
            Assert.Equal("Halfling", npc.NPCRace.Name);
        }

        [Fact]
        public void TestSetRaceChanges()
        {
            //Arrange
            var stats = new List<int>() { 8, 13, 14, 10, 15, 12 };
            var npc = new NPC();
            var service = new NPCService();

            //Act
            service.SetRace(ref npc, races, 4);//Set to halfling
            service.SetRaceChanges(ref stats, npc.NPCRace);

            //Assert
            Assert.Equal(15, stats[1]);
            Assert.Equal(13, stats[5]);
        }
    }
}
