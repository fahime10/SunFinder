using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace SunFinder.UnitTests
{
    public class WeatherDetailsClass
    {
        private readonly IHttpClientWrapper httpClientWrapper;

        public WeatherDetailsClass(IHttpClientWrapper httpClientWrapper)
        {
            this.httpClientWrapper = httpClientWrapper;
        }

        public async Task<string> GetDataFromAPI()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=London&appid=qwerty";
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
    public class WeatherDetailsTestClass
    {
        // Test data to be used
        readonly string url = "https://api.openweathermap.org/data/2.5/weather?q=London&appid=";
        string APIKey = "qwerty";

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
            WeatherDetails air = new WeatherDetails();
            Assert.IsNotNull(air);
        }

        // Mock test a success response of the given API
        [TestMethod]
        public async Task GetDataFromApiAsyncSuccess()
        {
            var mockHttpClientWrapper = new Mock<IHttpClientWrapper>();
            mockHttpClientWrapper
                .Setup(wrapper => wrapper.GetAsync(url + APIKey))
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Content = new StringContent("{\"data\": \"mocked_data\"}")
                });

            var testClass = new WeatherDetailsClass(mockHttpClientWrapper.Object);

            var result = await testClass.GetDataFromAPI();

            Assert.AreEqual("{\"data\": \"mocked_data\"}", result);
        }

        // Mock test a failure response of the given API
        [TestMethod]
        public async Task GetDataFromApiAsyncFailure()
        {
            var mockHttpClientWrapper = new Mock<IHttpClientWrapper>();
            mockHttpClientWrapper
                .Setup(client => client.GetAsync(url + APIKey))
                .ReturnsAsync(new HttpResponseMessage { StatusCode = System.Net.HttpStatusCode.NotFound });

            var testClass = new WeatherDetailsClass(mockHttpClientWrapper.Object);

            var result = await testClass.GetDataFromAPI();

            Assert.IsNull(result);
        }
    }
}
