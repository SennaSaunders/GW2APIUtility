using Newtonsoft.Json;

namespace GW2APIUtility.Models.Skills
{
    public class Skill
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("facts")]
        public List<Fact> Facts { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("weapon_type")]
        public string WeaponType { get; set; }

        [JsonProperty("attunement")]
        public string Attunement { get; set; }

        [JsonProperty("professions")]
        public List<string> Professions { get; set; }

        [JsonProperty("slot")]
        public string Slot { get; set; }

        [JsonProperty("flags")]
        public List<string> Flags { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("chat_link")]
        public string ChatLink { get; set; }

        [JsonProperty("prev_chain")]
        public int? PrevChain { get; set; }

        [JsonProperty("categories")]
        public List<string> Categories { get; set; }

        [JsonProperty("traited_facts")]
        public List<TraitedFact> TraitedFacts { get; set; }

        [JsonProperty("cost")]
        public int? Cost { get; set; }

        [JsonProperty("flip_skill")]
        public int? FlipSkill { get; set; }

        [JsonProperty("dual_attunement")]
        public string DualAttunement { get; set; }

        [JsonProperty("specialization")]
        public int? Specialization { get; set; }

        [JsonProperty("dual_wield")]
        public string DualWield { get; set; }

        [JsonProperty("initiative")]
        public int? Initiative { get; set; }

        [JsonProperty("next_chain")]
        public int? NextChain { get; set; }
    }

    public class Fact
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("distance")]
        public int? Distance { get; set; }

        [JsonProperty("hit_count")]
        public int? HitCount { get; set; }

        [JsonProperty("dmg_multiplier")]
        public double? DmgMultiplier { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("apply_count")]
        public int? ApplyCount { get; set; }

        [JsonProperty("percent")]
        public float? Percent { get; set; }

        [JsonProperty("finisher_type")]
        public string FinisherType { get; set; }

        [JsonProperty("field_type")]
        public string FieldType { get; set; }
    }

    public class TraitedFact
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("requires_trait")]
        public int RequiresTrait { get; set; }

        [JsonProperty("hit_count")]
        public int HitCount { get; set; }

        [JsonProperty("dmg_multiplier")]
        public double DmgMultiplier { get; set; }

        [JsonProperty("overrides")]
        public int Overrides { get; set; }

        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("distance")]
        public int? Distance { get; set; }
    }
}
