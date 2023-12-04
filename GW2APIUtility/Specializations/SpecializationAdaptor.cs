using GW2APIUtility.Specializations.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GW2APIUtility.Specializations
{
    public interface ISpecializationAdaptor
    {
        public Task<IEnumerable<int>> GetSpecializationIds();
        public Task<IEnumerable<ISpecialization>> GetSpecializations();
    }

    public class SpecializationAdaptor : ISpecializationAdaptor
    {
        private ISpecializationPort _specializationPort;

        public SpecializationAdaptor(ISpecializationPort specializationPort)
        {
            _specializationPort = specializationPort;
        }

        public async Task<IEnumerable<int>> GetSpecializationIds()
        {
            HttpResponseMessage response = await _specializationPort.GetSpecializationIds();
            var textResponse = await response.Content.ReadAsStringAsync();
            IEnumerable<int>? specializationIds = JsonConvert.DeserializeObject<IEnumerable<int>>(textResponse);
            return specializationIds;
        }

        public async Task<IEnumerable<ISpecialization>> GetSpecializations()
        {
            IEnumerable<int> specializationIds = await GetSpecializationIds();

            List<ISpecialization> specializations = new();
            foreach (int id in specializationIds)
            {
                HttpResponseMessage response = await _specializationPort.GetSpecialization(id);
                string textResponse = await response.Content.ReadAsStringAsync();
                ISpecialization specialization;

                if ((bool)JObject.Parse(textResponse)["elite"])
                {
                    specialization = JsonConvert.DeserializeObject<EliteSpecialization>(textResponse);
                }
                else
                {
                    specialization = JsonConvert.DeserializeObject<CoreSpecialization>(textResponse);
                }

                specializations.Add(specialization);
            }

            return specializations;
        }
    }
}