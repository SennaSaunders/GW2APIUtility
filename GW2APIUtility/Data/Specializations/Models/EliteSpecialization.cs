using Newtonsoft.Json;

namespace GW2APIUtility.Data.Specializations.Models
{
    public class EliteSpecialization : ISpecialization
    {
        [JsonProperty("weapon_trait")]
        public int WeaponTrait { get; set; }

        [JsonProperty("profession_icon_big")]
        public string ProfessionIconBig { get; set; }

        [JsonProperty("profession_icon")]
        public string ProfessionIcon { get; set; }
    }
}
