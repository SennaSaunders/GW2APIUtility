using Newtonsoft.Json;

namespace GW2APIUtility.DataRetrieval
{
    public interface IPagingHttpAdaptor<T>
    {
        Task<List<T>> GetItems(string url);
    }

    public class PagingHttpAdaptor<T> : IPagingHttpAdaptor<T>
    {
        private IHttpPort _httpPort;

        public PagingHttpAdaptor(IHttpPort httpPort)
        {
            _httpPort = httpPort;
        }

        public async Task<List<T>> GetItems(string url)
        {
            int pages;
            int i = 0;
            List<T> results = new();
            do
            {
                string requestUri = url + i++;
                HttpResponseMessage response = await _httpPort.HttpGetAsync(requestUri);
                string responseString = await response.Content.ReadAsStringAsync();
                results.AddRange(JsonConvert.DeserializeObject<List<T>>(responseString));

                pages = int.Parse(response.Headers.GetValues("x-page-total").First());
            } while (i < pages);

            return results;
        }
    }
}