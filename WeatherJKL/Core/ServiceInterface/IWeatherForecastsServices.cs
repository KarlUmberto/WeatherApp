using System;
using WeatherJKL.Core.Dto.WeatherDtos;

namespace WeatherJKL.Core.ServiceInterface
{
    public interface IWeatherForecastsServices
    {
        Task<WeatherResultDto> WeatherDetail(WeatherResultDto dto);

        Task<OpenWeatherResultDto> OpenWeatherResult(OpenWeatherResultDto dto);
    }
}