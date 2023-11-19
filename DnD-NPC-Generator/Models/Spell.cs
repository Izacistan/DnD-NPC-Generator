namespace DnD_NPC_Generator.Models
{
    public class SpellClass { public string Name { get; set; } }
    public class SpellDamage { public SpellDamageType Damage_type { get; set; } }
    public class SpellDamageType { public string Name { get; set; } }
    public class SpellSchool { public string Name { get; set; } }
    public class SpellDC { public SpellDCType Type { get; set; } }
    public class SpellDCType { public string Name { get; set; } }
    public class Spell
    {

        public string Index { get; set; }
        public string Name { get; set; }
        public List<string> Desc { get; set; }
        public List<string> Higher_level { get; set; }
        public string Range { get; set; }
        public List<string> Components { get; set; }
        public string Material { get; set; }
        public bool Ritual { get; set; }
        public string Duration { get; set; }
        public bool Concentration { get; set; }
        public string Casting_time { get; set; }
        public int Level { get; set; }
        public string Attack_type { get; set; }
        public SpellDamage? Damage { get; set; }
        public SpellDC? Dc { get; set; }
        public SpellSchool? School { get; set; }
        public List<SpellClass>? Classes { get; set; }
    }
}
