/** 
 * AUTHOR: Halmar Arteaga
 * DATE: 11/05/2023
 * LAST UPDATED: 11/05/2023
 *
 * NOTES: This file contains unit tests for the DND Web API.
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnD_NPC_Generator.WebAPI;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace DnD_UnitTests
{
    public class DNDAPITests
    {
        /*================
         * Test Get Request with valid spell 'Light'
         ================*/
        [Fact]
        public async void GetSpell()
        {
            // Arrange
            var expected = "{\"higher_level\":[],\"index\":\"light\",\"name\":\"Light\",\"desc\":[\"You touch one object that is no larger than 10 feet in any dimension. Until the spell ends, the object sheds bright light in a 20-foot radius and dim light for an additional 20 feet. The light can be colored as you like. Completely covering the object with something opaque blocks the light. The spell ends if you cast it again or dismiss it as an action.\",\"If you target an object held or worn by a hostile creature, that creature must succeed on a dexterity saving throw to avoid the spell.\"],\"range\":\"Touch\",\"components\":[\"V\",\"M\"],\"material\":\"A firefly or phosphorescent moss.\",\"ritual\":false,\"duration\":\"1 hour\",\"concentration\":false,\"casting_time\":\"1 action\",\"level\":0,\"dc\":{\"dc_type\":{\"index\":\"dex\",\"name\":\"DEX\",\"url\":\"/api/ability-scores/dex\"},\"dc_success\":\"none\"},\"school\":{\"index\":\"evocation\",\"name\":\"Evocation\",\"url\":\"/api/magic-schools/evocation\"},\"classes\":[{\"index\":\"bard\",\"name\":\"Bard\",\"url\":\"/api/classes/bard\"},{\"index\":\"cleric\",\"name\":\"Cleric\",\"url\":\"/api/classes/cleric\"},{\"index\":\"sorcerer\",\"name\":\"Sorcerer\",\"url\":\"/api/classes/sorcerer\"},{\"index\":\"wizard\",\"name\":\"Wizard\",\"url\":\"/api/classes/wizard\"}],\"subclasses\":[{\"index\":\"lore\",\"name\":\"Lore\",\"url\":\"/api/subclasses/lore\"}],\"url\":\"/api/spells/light\"}";
            string testSpell = "light";

            // Act
            var request = new DNDAPI();
            await request.GetSpell(testSpell);

            string actual = request.JSONResponse;

            // Assert
            Assert.Equal(expected, actual);
        }

        /*================
         * Test Get Request with invalid spell 'smack-attack'
        ================*/
        [Fact]
        public async void GetSpellInvalid()
        {
            // Arrange
            // want to check if spell is null
            string testSpell = "smack-attack";

            // Act
            var request = new DNDAPI();
            await request.GetSpell(testSpell);

            string actual = request.JSONResponse;

            // Assert
            Assert.Null(actual);
        }

        /*================
         *  Testing call with spaces as a parameter
        ===============*/
        [Fact]
        public async void TrySpaces()
        {
            // Arrange
            string expected = "{\"index\":\"fast-hands\",\"class\":{\"index\":\"rogue\",\"name\":\"Rogue\",\"url\":\"/api/classes/rogue\"},\"subclass\":{\"index\":\"thief\",\"name\":\"Thief\",\"url\":\"/api/subclasses/thief\"},\"name\":\"Fast Hands\",\"level\":3,\"prerequisites\":[],\"desc\":[\"Starting at 3rd level, you can use the bonus action granted by your Cunning Action to make a Dexterity (Sleight of Hand) check, use your thieves' tools to disarm a trap or open a lock, or take the Use an Object action.\"],\"url\":\"/api/features/fast-hands\"}";
            string testFeature = "Fast Hands";

            //Act
            var request = new DNDAPI();
            await request.GetFeature(testFeature);
            string actual = request.JSONResponse;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
