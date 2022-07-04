﻿namespace WebApi.Models
{
    public class CityWeather
    {
        public long cityId { get; set; }
        public string cityName { get; set; }
        public string weatherMain { get; set; }
        public string weatherDescription { get; set; }
        public string weatherIcon { get; set; }
        public double mainTemp { get; set; }
        public double mainHumidity { get; set; }
    }
}
