using Microsoft.AspNetCore.Mvc;
using DnD_NPC_Generator.Models;
using System.Reflection.Metadata.Ecma335;

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
                    roll = dSix.Next(6)+1;//Roll 1 d 4
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
    }
} 
