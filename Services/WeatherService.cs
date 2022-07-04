using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebApi.Common;

namespace WebApi.Services
{
    public class WeatherService
    {
        public async Task<HttpResponseMessage> GetAll()
        {
            HttpClient _client = new HttpClient();

            HttpResponseMessage a = new HttpResponseMessage();
            a = await _client.PostAsync(Constants.WeatherApiUrl, null).ConfigureAwait(false);
            return a;
        }
    }
}
