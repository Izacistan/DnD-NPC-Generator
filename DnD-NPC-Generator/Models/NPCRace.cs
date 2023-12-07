namespace DnD_NPC_Generator.Models
{
    public class NPCRace
    {
        public NPCRace() { }
        public NPCRace(int id, string name) { NPCRaceId = id; Name = name; }
        public int NPCRaceId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
