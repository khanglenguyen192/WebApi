using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebApi.Common;

namespace WebApi.Services
{
    public class WeatherService
    {
        static readonly Lazy<WeatherService> _instance = new Lazy<WeatherService>();
        private HttpClient _client { get; set; }

        public WeatherService()
        {
            _client = new HttpClient();
        }

        public static WeatherService Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public async Task<string> GetAll()
        {
            HttpResponseMessage response = await _client.PostAsync(Constants.WeatherApiUrl, null);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}
