using GW2APIUtility.Data.Specializations.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GW2APIUtility.Data.Specializations
{
    public interface ISpecializationAdaptor
    {
        public Task<IEnumerable<int>> GetSpecializationIds();
        public Task<IEnumerable<ISpecialization>> GetSpecializations();
    }

    public class SpecializationAdaptor : ISpecializationAdaptor
    {
        private IHttpPort _httpPort;
        private string _specializationEndpoint = "specializations";

        public SpecializationAdaptor(IHttpPort httpPort)
        {
            _httpPort = httpPort;
        }

        public async Task<IEnumerable<int>> GetSpecializationIds()
        {
            HttpResponseMessage response = await _httpPort.HttpGetAsync(_specializationEndpoint);
            string responseString = await response.Content.ReadAsStringAsync();
            IEnumerable<int>? specializationIds = JsonConvert.DeserializeObject<IEnumerable<int>>(responseString);
            return specializationIds;
        }

        public async Task<IEnumerable<ISpecialization>> GetSpecializations()
        {
            IEnumerable<int> specializationIds = await GetSpecializationIds();

            List<ISpecialization> specializations = new();
            foreach (int id in specializationIds)
            {
                HttpResponseMessage response = await _httpPort.HttpGetAsync($"{_specializationEndpoint}/{id}");
                string responseString = await response.Content.ReadAsStringAsync();
                ISpecialization specialization;

                if ((bool)JObject.Parse(responseString)["elite"])
                {
                    specialization = JsonConvert.DeserializeObject<EliteSpecialization>(responseString);
                }
                else
                {
                    specialization = JsonConvert.DeserializeObject<CoreSpecialization>(responseString);
                }

                specializations.Add(specialization);
            }

            return specializations;
        }
    }
}