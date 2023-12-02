namespace DnD_NPC_Generator.Models
{
    public class ApiClass
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public int Hit_die { get; set; }
        public List<ApiProficiency> Proficiencies { get; set; }
        public List<ApiSavingThrow> Saving_throws { get; set; }
        public List<ApiClassLevel> Class_levels { get; set; }
        public ApiSpellcasting Spellcasting { get; set; }
        public List<ApiSubclass> Subclasses { get; set; }
    }

    public class ApiClassLevel
    {
        public int Level { get; set; }
        public int? Ability_score_bonuses { get; set; }
        public List<ApiFeature> Features { get; set; }
    }
    public class  ApiFeature
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public List<string> Desc { get; set; }
    }

    public class ApiInfo
    {
        public string Name { get; set; }
        public List<string> Desc { get; set; }
    }

    public class ApiProficiency
    {
        public string Index { get; set; }
        public string Name { get; set; }
    }

    public class  ApiSavingThrow
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public string Full_name { get; set; }
    }

    public class ApiSpellcasting
    {
        public List<ApiInfo> Info { get; set; }
        public int Level { get; set; }
        public ApiSpellcastingAbility Spellcasting_ability { get; set; }
    }

    public class ApiSpellcastingAbility
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public string Full_name { get; set; }
    }

    public class ApiSubclass
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public List<ApiSubFeature> Subclass_levels { get; set; }
    }

    public class ApiSubFeature
    {
        public string Index { get; set; }
        public object Ability_score_bonuses { get; set; }
        public int Level { get; set; }
        public List<ApiFeature> Features { get; set; }
    }
}
