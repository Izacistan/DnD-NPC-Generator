namespace DnD_NPC_Generator.Models
{
    public class SpellListView
    {
        public SpellListView() {
            ClassFilter = "all";
        }
        public List<Spell> Spells { get; set; }
        public string ClassFilter {  get; set; }
    }
}
