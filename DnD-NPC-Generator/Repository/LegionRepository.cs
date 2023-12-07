/** 
* AUTHOR: Halmar Arteaga
* DATE: 11/18/2023
* LAST UPDATED: 11/18/2023
*/

using DnD_NPC_Generator.Models;
using Microsoft.EntityFrameworkCore;

namespace DnD_NPC_Generator.Repository
{
    public class LegionRepository : ILegionRepository
    {
        private NPCContext context;
        public LegionRepository(NPCContext context)
        {
            this.context = context;
        }

        public List<NPC> GetAllNpcsByUser(User user)
        {
            string id = user.Id;
            return context.NPCs.Where(n => n.Owner == id).Include(n => n.NPCClass).Include(n => n.NPCRace).OrderBy(c => c.NPCId).ToList();
        }
        public List<NPC> GetAllNpcs()
        {
            return context.NPCs.Include(n => n.NPCClass).Include(n => n.NPCRace).OrderBy(c => c.NPCId).ToList();
        }
        public List<NPCClass> GetAllClasses()
        {
            return context.NPCClasses.OrderBy(c => c.NPCClassId).ToList();
        }

        public List<NPCRace> GetAllRaces()
        {
            return context.NPCRaces.OrderBy(c => c.NPCRaceId).ToList();
        }
        public NPC FindNpc(int id)
        {
            return context.NPCs.Find(id);
        }
        public NPC GetNpc(int search)
        {
            return context.NPCs.Where(n => n.NPCId == search).FirstOrDefault();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void AddNpc(NPC npc)
        {
            context.NPCs.Add(npc);
        }

        public void UpdateNpc(NPC npc)
        {
            context.NPCs.Update(npc);
        }

        public void DeleteNpc(NPC npc)
        {
            context.NPCs.Remove(npc);
        }
    }
}
