/** 
* AUTHOR: Halmar Arteaga
* DATE: 11/18/2023
* LAST UPDATED: 11/18/2023
*/

using DnD_NPC_Generator.Models;

namespace DnD_NPC_Generator.Repository
{
    public interface ILegionRepository
    {
        List<NPC> GetAllNpcsByUser(User user);
        List<NPC> GetAllNpcs();
        List<NPCClass> GetAllClasses();
        List<NPCRace> GetAllRaces();
        NPC FindNpc(int id);
        NPC GetNpc(int id);
        void Save();
        void AddNpc(NPC npc);
        void UpdateNpc(NPC npc);
        void DeleteNpc(NPC npc);
    }
}
