using System.Net.Http;
using System.Threading.Tasks;

namespace SunFinder.UnitTests
{
    public interface IHttpClientWrapper
    {
        Task<HttpResponseMessage> GetAsync(string requestUri);
    }

    public class HttpClientWrapper : IHttpClientWrapper
    {
        private readonly HttpClient httpClient;

        public HttpClientWrapper(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<HttpResponseMessage> GetAsync(string url)
        {
            return httpClient.GetAsync(url);
        }
    }
}
