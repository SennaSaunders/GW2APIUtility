using GW2APIUtility.DataRetrieval;
using Newtonsoft.Json;

namespace GW2APIUtilityTests
{
    public interface IProfessionsHttpAdaptor
    {
        Task<List<Profession>> GetProfessions();
    }

    public class ProfessionsHttpAdaptor : IProfessionsHttpAdaptor
    {
        private IHttpPort _httpPort;

        public ProfessionsHttpAdaptor(IHttpPort httpPort)
        {
            _httpPort = httpPort;
        }

        public async Task<List<Profession>> GetProfessions()
        {
            string endpoint = "professions";
            var response = await _httpPort.HttpGetAsync(endpoint);
            var responseString = await response.Content.ReadAsStringAsync();
            List<string> professionNames = JsonConvert.DeserializeObject<List<String>>(responseString);
            
            string allProfessionsUrl = $"{endpoint}?ids={String.Join(",", professionNames)}";
            response = await _httpPort.HttpGetAsync(allProfessionsUrl);
            responseString = await response.Content.ReadAsStringAsync();
            return null;
        }
    }

    public class Profession
    {
    }
}