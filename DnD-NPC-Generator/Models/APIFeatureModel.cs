namespace DnD_NPC_Generator.Models
{
    public class APIFeatureModel
    {
        public string index { get; set; }
        public Dictionary<string, string> featureClass { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public List<string> prerequisites { get; set; }
        public List<string> description { get; set; }
        public string url { get; set; }
    }
}
