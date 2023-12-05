using Newtonsoft.Json;

namespace GW2APIUtility.Data.Traits
{
    public interface ITraitAdaptor
    {
        Task<Trait> GetTrait(int id);
        Task<IEnumerable<int>> GetTraitIds();
    }
    public class TraitAdaptor : ITraitAdaptor
    {
        private IHttpPort _httpPort;
        public TraitAdaptor(IHttpPort httpPort)
        {
            _httpPort = httpPort;
        }

        private string _traitEndpoint = "traits";

        public async Task<IEnumerable<int>> GetTraitIds()
        {
            HttpResponseMessage response = await _httpPort.HttpGetAsync(_traitEndpoint);
            string responseString = await response.Content.ReadAsStringAsync();
            IEnumerable<int>? traitIds = JsonConvert.DeserializeObject<IEnumerable<int>>(responseString);
            return traitIds;
        }

        public async Task<Trait> GetTrait(int id)
        {
            HttpResponseMessage response = await _httpPort.HttpGetAsync($"{_traitEndpoint}/{id}");
            string responseString = await response.Content.ReadAsStringAsync();
            Trait trait = JsonConvert.DeserializeObject<Trait>(responseString);
            return trait;
        }
    }
}