/** 
 * AUTHOR: Isaac Hillaker
 * DATE: 11/10/2023
 * LAST UPDATED: 11/02/2023
 *
 * NOTES: This file contains unit tests for the NPC model class. Specifically it is testing to ensure that the serialization and de-serialization methods are working properly.
 *
 */


using System.ComponentModel.DataAnnotations;
using DnD_NPC_Generator.Models;

namespace DnD_UnitTests
{
    public class NPCModelTests
    {
        /*===============
         Test VALID input, updateSpellData
        ===============*/
        [Fact]
        public void UpdateSpellData_ShouldSerializeCorrectly()
        {
            // Arrange
            var npc = new NPC();

            // Act
            npc.UpdateSpellData();

            // Assert
            Assert.NotNull(npc.spellData); // Ensure it is NOT null
            Assert.IsType<string>(npc.spellData); // Ensure it IS a string
        }

        /*===============
         Test VALID input, loadingSpellData
        ===============*/
        [Fact]
        public void LoadSpellData_ShouldDeserializeCorrectly()
        {
            // Arrange
            var npc = new NPC();
            npc.UpdateSpellData();

            // Act
            npc.LoadSpellData();

            // Assert
            Assert.NotNull(npc.Spells); // Ensure Spells is not null
            Assert.Equal(new List<string> { "Fireball", "Magic Missile", "Healing Word" }, npc.Spells);
        }
    }

}
