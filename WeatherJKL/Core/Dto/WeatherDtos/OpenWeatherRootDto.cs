using System.Text.Json.Serialization;

namespace WeatherJKL.Core.Dto.WeatherDtos
{
    public class OpenWeatherRootDto
    {
        [JsonPropertyName("coord")]
        public Coords Coord { get; set; }

        [JsonPropertyName("weather")]
        public List<Weathers> Weather { get; set; }

        [JsonPropertyName("main")]
        public Mains Main { get; set; }

        [JsonPropertyName("wind")]
        public Winds Wind { get; set; }

        [JsonPropertyName("timezone")]
        public int Timezone { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

    }

    public class Coords
    {
        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }
    }

    public class Mains
    {
        [JsonPropertyName("temp")]
        public double Temp { get; set; }

        [JsonPropertyName("feels_like")]
        public double Feels_like { get; set; }

        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }

    public class Weathers
    {
        [JsonPropertyName("main")]
        public string Main { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class Winds
    {
        [JsonPropertyName("speed")]
        public double Speed { get; set; }
    }
}