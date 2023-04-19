using System.Linq;
using WeatherJKL.Core.Dto.WeatherDtos;
using Microsoft.Maui.Controls;
using WeatherJKL.Models.Weather;
using WeatherJKL.ApplicationServices.Services;
using WeatherJKL.Core.ServiceInterface;

namespace Views;

public partial class WeatherSearchPage : ContentPage
{
    private readonly IWeatherForecastsServices _weatherForecastsServices;
    public WeatherSearchPage(IWeatherForecastsServices weatherForecastsServices)
	{
        InitializeComponent();
        _weatherForecastsServices = weatherForecastsServices;
    }
    private async void OnSearchButtonPressed(object sender, EventArgs e)
    {
        string city = cityEntry.Text.Trim();

        if (!string.IsNullOrEmpty(city))
        {
            OpenWeatherResultDto weatherResult = await _weatherForecastsServices.OpenWeatherResult(new OpenWeatherResultDto { City = city });

            if (weatherResult != null)
            {
                BindingContext = weatherResult;
                resultLayout.IsVisible = true;
            }
        }
    }
}