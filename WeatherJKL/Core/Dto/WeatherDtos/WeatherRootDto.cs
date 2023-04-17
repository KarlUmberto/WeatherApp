namespace WeatherJKL.Core.Dto.WeatherDtos
{
    public class WeatherRootDto
    {
        public HeadlineDto Headline { get; set; }
        public List<DailyForecastsDto> DailyForecasts { get; set; }
    }
}