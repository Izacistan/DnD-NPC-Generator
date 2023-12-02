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
using GraphQL.Client.Abstractions.Utilities;

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
                                index
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
                                damage {
                                    damage_type {
                                        name
                                    }
                                }
                                dc {
                                    type {
                                        name
                                    }
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
                                index
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
                                damage {
                                    damage_type {
                                        name
                                    }
                                }
                                dc {
                                    type {
                                        name
                                    }
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

        public async Task<List<Spell>> GetSpellsByClass(string clName) {
            string search = clName.ToLowerCase().Replace(" ", "-");
            var query = new GraphQLRequest
            {
                Query = @"
                        query Spell($term: StringFilter) {
                            spells(class: $term) {
                                index
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
                                damage {
                                    damage_type {
                                        name
                                    }
                                }
                                dc {
                                    type {
                                        name
                                    }
                                }
                                classes {
                                    name
                                }
                            }
                        }",
                Variables = new { term = search }
            };
            var response = await client.SendQueryAsync<ResponseSpellsCollectionType>(query);
            return response.Data.Spells;
        }

        public async Task<ApiClass> GetClassInfo(string id)
        {
            string search = id.ToLower().Replace(" ", "-");
            var query = new GraphQLRequest
            {
                Query = @"
                        query Class($index: String) {
                          class(index: $index) {
                            index
                            name
                            hit_die
                            proficiencies {
                              index
                              name
                            }
                            saving_throws {
                              index
                              name
                              full_name
                            }
                            class_levels {
                              level
                              ability_score_bonuses
                              features {
                                index
                                name
                                level
                                desc
                              }
                            }
                            spellcasting {
                              info {
                                name
                              }
                              level
                              spellcasting_ability {
                                name
                                full_name
                                index
                              }
                            }
                            subclasses {
                              index
                              name
                              subclass_levels {
                                index
                                ability_score_bonuses
                                level
                                features {
                                  index
                                  name
                                  level
                                  desc
                                }
                                spellcasting {
                                  cantrips_known
                                  spell_slots_level_1
                                  spell_slots_level_2
                                  spell_slots_level_3
                                  spell_slots_level_4
                                  spell_slots_level_5
                                  spell_slots_level_6
                                  spell_slots_level_7
                                  spell_slots_level_8
                                  spell_slots_level_9
                                  spells_known
                                }
                              }
                            }
                          }
                        }",
                Variables = new { index = search }
            };

            var response = await client.SendQueryAsync<ResponseClassType>(query);
            return response.Data.Class;
        }
    }
}
