using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApi.Models
{
    public class RawData
    {
        [JsonProperty("cnt")]
        public int Count { get; set; }

        [JsonProperty("list")]
        public List<Detail> Details { get; set; }
    }

    public class Detail
    {
        [JsonProperty("coord")]
        public Coord coord { get; set; }

        [JsonProperty("sys")]
        public Sys sys { get; set; }

        [JsonProperty("weather")]
        public List<Weather> weather { get; set; }

        [JsonProperty("main")]
        public Main main { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind wind { get; set; }

        [JsonProperty("clouds")]
        public Cloud clouds { get; set; }

        [JsonProperty("dt")]
        public long dt { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Coord
    {
        public double lon { get; set; }

        public double lat { get; set; }
    }

    public class Sys
    {
        [JsonProperty("cnt")]
        public string Country { get; set; }

        [JsonProperty("timezone")]
        public long TimeZone { get; set; }

        [JsonProperty("sunrise")]
        public long SunRise { get; set; }

        [JsonProperty("sunset")]
        public long SunSet { get; set; }
    }

    public class Weather
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; }

        [JsonProperty("temp_min")]
        public double TempMin { get; set; }

        [JsonProperty("temp_max")]
        public double TempMax{ get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }
    }

    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("def")]
        public int deg { get; set; }
    }

    public class Cloud
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }

}
