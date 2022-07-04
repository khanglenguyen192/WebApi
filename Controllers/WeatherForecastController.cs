using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApi.Common;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IList<CityWeather> Get()
        {
            var result = JsonConvert.DeserializeObject<RawData>(Constants.Data);
            List<CityWeather> datas = new List<CityWeather>();
            foreach (var item in result.Details)
            {
                var city = new CityWeather();
                city.cityId = item.Id;
                city.cityName = item.Name;
                city.weatherMain = item.weather[0]?.Main;
                city.weatherIcon = Constants.BaseIconUrl + item.weather[0]?.Icon + Constants.IconFormat;
                city.mainTemp = item.main.Temp;
                city.mainHumidity = item.main.Humidity;
                datas.Add(city);
            }
            return datas;
        }
    }
}
