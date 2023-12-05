using Newtonsoft.Json;

namespace GW2APIUtility.Data.Traits
{
    public class Trait
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tier")]
        public int Tier { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("slot")]
        public string Slot { get; set; }

        [JsonProperty("facts")]
        public List<Dictionary<string, string>> Facts { get; set; }

        [JsonProperty("specialization")]
        public int Specialization { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
    //todo pull data on "Facts" and see what each contain bc this is bad
    //maybe pull it out into a list of dictionaries?
    //public class Fact
    //{
    //    [JsonProperty("text")]
    //    public string Text { get; set; }

    //    [JsonProperty("type")]
    //    public string Type { get; set; }

    //    [JsonProperty("icon")]
    //    public string Icon { get; set; }

    //    [JsonProperty("value")]
    //    public int Value { get; set; }

    //    [JsonProperty("target")]
    //    public string Target { get; set; }

    //    [JsonProperty("duration")]
    //    public int? Duration { get; set; }

    //    [JsonProperty("status")]
    //    public string Status { get; set; }

    //    [JsonProperty("description")]
    //    public string Description { get; set; }

    //    [JsonProperty("apply_count")]
    //    public int? ApplyCount { get; set; }

    //    [JsonProperty("distance")]
    //    public int? Distance { get; set; }
    //}
}
