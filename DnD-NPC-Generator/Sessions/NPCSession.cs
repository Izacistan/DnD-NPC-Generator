using DnD_NPC_Generator.Models;

namespace DnD_NPC_Generator.Sessions
{
    public class NPCSession
    {
        private const string NpcKey = "npcs";
        private const string CountKey = "count";

        private ISession session { get; set; }

        public NPCSession(ISession session)
        {
            this.session = session;
        }

        public void SetViewNPCs(List<NPC> npcs)
        {
            session.Set(NpcKey, npcs);
            session.SetInt32(CountKey, npcs.Count);
        }
        public List<NPC> GetViewNPCs()
        {
            return session.Get<List<NPC>>(NpcKey) ?? new List<NPC>();
        }

        public int? GetNPCCount()
        {
            return session.GetInt32(CountKey);
        }

        public void RemoveViewNPCs()
        {
            session.Remove(NpcKey);
            session.Remove(CountKey);
        }
    }
}
