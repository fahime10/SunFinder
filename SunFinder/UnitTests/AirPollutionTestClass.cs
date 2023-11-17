using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

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

    public class AirPollutionClass
    {
        private readonly IHttpClientWrapper httpClientWrapper;

        public AirPollutionClass(IHttpClientWrapper httpClientWrapper)
        {
            this.httpClientWrapper = httpClientWrapper;
        }

        public async Task<string> GetDataFromAPI()
        {
            string url = "http://api.openweathermap.org/data/2.5/air_pollution?lat=50.0&lon=50.0&appid=qwerty";
            var response = await httpClientWrapper.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return null;
            }
        }
    }

    [TestClass]
    public class AirPollutionTestClass
    {
        // Test data to be used
        string url = "http://api.openweathermap.org/data/2.5/air_pollution?lat=50.0&lon=50.0&appid=qwerty";

        // First test check
        [TestMethod]
        public void OK()
        {
            bool ok = true;
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void InstanceOK()
        {
            AirPollution air = new AirPollution();
            Assert.IsNotNull(air);
        }

        // Mock test a success response of the given API
        [TestMethod]
        public async Task GetDataFromApiAsyncSuccess()
        {
            var mockHttpClientWrapper = new Mock<IHttpClientWrapper>();
            mockHttpClientWrapper
                .Setup(wrapper => wrapper.GetAsync(url))
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Content = new StringContent("{\"data\": \"mocked_data\"}")
                });

            var testClass = new AirPollutionClass(mockHttpClientWrapper.Object);

            var result = await testClass.GetDataFromAPI();

            Assert.AreEqual("{\"data\": \"mocked_data\"}", result);
        }

        // Mock test a failure response of the given API
        [TestMethod]
        public async Task GetDataFromApiAsyncFailure()
        {
            var mockHttpClientWrapper = new Mock<IHttpClientWrapper>();
            mockHttpClientWrapper
                .Setup(client => client.GetAsync(url))
                .ReturnsAsync(new HttpResponseMessage { StatusCode = System.Net.HttpStatusCode.NotFound });

            var testClass = new AirPollutionClass(mockHttpClientWrapper.Object);

            var result = await testClass.GetDataFromAPI();

            Assert.IsNull(result);
        }

        // Test pollution function
        [TestMethod]
        public void TestPollution()
        {
            AirPollution air = new AirPollution();

            for (int i = 1; i < 7; i++)
            {
                int indexValue = i;
                string result = air.pollution(indexValue);

                switch(i)
                {
                    case 1:
                        Assert.AreEqual("Low pollution - Good", result);
                        break;
                    case 2:
                        Assert.AreEqual("Some pollution - Fair", result);
                        break;
                    case 3:
                        Assert.AreEqual("Moderate pollution", result);
                        break;
                    case 4:
                        Assert.AreEqual("High pollution - Poor", result);
                        break;
                    case 5:
                        Assert.AreEqual("Very high pollution - Very poor", result);
                        break;
                    default:
                        Assert.AreEqual("Unknown", result);
                        break;
                }
            }
        }
    }
}