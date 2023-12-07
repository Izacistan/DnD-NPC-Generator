namespace DnD_NPC_Generator.Models
{
    public class NPCClass
    {
        public NPCClass() { }
        public NPCClass(int id, string name) { NPCClassId = id; Name = name; }
        public int NPCClassId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
