namespace GW2APIUtility
{
    public interface IHttpPort
    {
        public Task<HttpResponseMessage> HttpGetAsync(string endpoint);
    }

    public class HttpPort : IHttpPort
    {
        private HttpClient _httpClient;

        public HttpPort(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> HttpGetAsync(string endpoint)
        {
            return await _httpClient.GetAsync(endpoint);
        }
    }
}
