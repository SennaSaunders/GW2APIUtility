namespace GW2APIUtility.Specializations
{
    public interface ISpecializationPort
    {
        Task<HttpResponseMessage> GetSpecialization(int id);
        public Task<HttpResponseMessage> GetSpecializationIds();
    }

    public class SpecializationPort : ISpecializationPort
    {
        private HttpClient _httpClient;
        private string baseEndpoint = "specializations";

        public SpecializationPort(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetSpecialization(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{baseEndpoint}/{id}");
            return response;
        }

        public async Task<HttpResponseMessage> GetSpecializationIds()
        {
            var response = await _httpClient.GetAsync(baseEndpoint);
            return response;
        }
    }
}