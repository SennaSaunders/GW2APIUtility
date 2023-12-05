using Newtonsoft.Json;

namespace GW2APIUtility.Data.Specializations.Models
{
    public abstract class ISpecialization
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profession")]
        public string Profession { get; set; }

        [JsonProperty("elite")]
        public bool Elite { get; set; }

        [JsonProperty("minor_traits")]
        public List<int> MinorTraits { get; set; }

        [JsonProperty("major_traits")]
        public List<int> MajorTraits { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }
    }

}