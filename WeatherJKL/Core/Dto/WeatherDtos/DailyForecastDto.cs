using System.Text.Json.Serialization;

namespace WeatherJKL.Core.Dto.WeatherDtos
{
    public class DailyForecastsDto
    {
        public Temperature Temperature { get; set; }
        public Day Day { get; set; }
        public Night Night { get; set; }

        //public List<string> Sources { get; set; }

    }

    public class Temperature
    {
        public Minimum Minimum { get; set; }
        public Maximum Maximum { get; set; }
    }

    public class Day
    {

        [JsonPropertyName("Icon")]
        public int Icon { get; set; }

        [JsonPropertyName("IconPhrase")]
        public string IconPhrase { get; set; }

        [JsonPropertyName("HasPrecipitation")]
        public bool HasPrecipitation { get; set; }

        [JsonPropertyName("PrecipitationType")]
        public string PrecipitationType { get; set; }

        [JsonPropertyName("PrecipitationIntensity")]
        public string PrecipitationIntensity { get; set; }
    }

    public class Night
    {
        [JsonPropertyName("Icon")]
        public int Icon { get; set; }

        [JsonPropertyName("IconPhrase")]
        public string IconPhrase { get; set; }

        [JsonPropertyName("HasPrecipitation")]
        public bool HasPrecipitation { get; set; }

        [JsonPropertyName("PrecipitationType")]
        public string PrecipitationType { get; set; }

        [JsonPropertyName("PrecipitationIntensity")]
        public string PrecipitationIntensity { get; set; }
    }

    public class Maximum
    {
        [JsonPropertyName("Value")]
        public double Value { get; set; }

        [JsonPropertyName("Unit")]
        public string Unit { get; set; }

        [JsonPropertyName("UnitType")]
        public int UnitType { get; set; }
    }

    public class Minimum
    {
        [JsonPropertyName("Value")]
        public double Value { get; set; }

        [JsonPropertyName("Unit")]
        public string Unit { get; set; }

        [JsonPropertyName("UnitType")]
        public int UnitType { get; set; }
    }
}