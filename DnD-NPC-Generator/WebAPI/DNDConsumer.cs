/** 
 * AUTHOR: Halmar Arteaga
 * DATE: 11/10/2023
 * LAST UPDATED: 11/10/2023
 *
 * NOTES: This file uses GraphQL to get data from the API
 *          ------ Please Let me know if you need anything added to query
 *          ------------------REQUIREMENTS--------------------
 *          NEEDED:
 *              -- Model Class (Must have field names similar to API ex: "casting_time" => public string Casting_time {get; set;}
 *              -- ResponeObjectType <-- this allows the casting from json to C# object (Found in                                               ResponseTypes folder.
 * 
 * USAGE:
 *     In Controller:
 *          private readonly DNDConsumer consumer;
 *     
 *          Constructor(DNDConsumer consumer) {
 *              this.consumer = consumer;
 *          }
 *          
 *          public async Task<IActionResult> Action() {
 *              var spells = await consumer.GetAllSpells();
 *                  //OR IF ONLY NEED ONE SPELL
 *              var spell = await consumer.GetSpell("fire-bolt");
 *              
 *                  //IF USING A VIEW MODEL SPELL OR SPELL HERE
 *              
 *                  //VERY IMPORTANT IF YOU WANT TO RETURN A VIEW
 *              return await Task.Run(() => View(model));
 *                  
 *              -------------------Testing Past This Point--------------------
 *                  ------------If you want to return JSON-------------------
 *                  
 *                  //MULTIPLE SPELLS
 *              return Ok(spells);
 *                  //OR IF ONLY GETING ONE
 *              return Ok(spell);
 *     
 *     
 *
 */


using DnD_NPC_Generator.Migrations;
using DnD_NPC_Generator.Models;
using DnD_NPC_Generator.WebAPI.ResponseTypes;
using GraphQL;
using GraphQL.Client.Abstractions;

namespace DnD_NPC_Generator.WebAPI
{
    public class DNDConsumer
    {
        private readonly IGraphQLClient client;

        public DNDConsumer(IGraphQLClient client)
        {
            this.client = client;
        }

        public async Task<List<Spell>> GetAllSpells()
        {
            var query = new GraphQLRequest
            {
                Query = @"
                        query Spells {
                            spells {
                                name
                                desc
                                higher_level
                                range
                                components
                                material
                                ritual
                                duration
                                concentration
                                casting_time
                                level
                                attack_type
                                school {
                                    name
                                }
                                classes {
                                    name
                                }
                            }
                        }"
            };

            var response = await client.SendQueryAsync<ResponseSpellsCollectionType>(query);

            return response.Data.Spells;
        }

        public async Task<Spell> GetSpell(string id)
        {
            string search = id.ToLower().Replace(" ", "-");

            var query = new GraphQLRequest
            {
                Query = @"
                    query Spell($index: String) {
                      spell(index: $index) {
                        name
                        desc
                        higher_level
                        range
                        components
                        material
                        ritual
                        duration
                        concentration
                        casting_time
                        level
                        attack_type
                        school {
                          name
                        }
                        classes {
                          name
                        }
                      }
                    }",
                Variables = new { index = search }
            };

            var response = await client.SendQueryAsync<ResponseSpellType>(query);
            return response.Data.Spell;
        }
    }
}
