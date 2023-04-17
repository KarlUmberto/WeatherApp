using Microsoft.Maui.Controls;
using WeatherJKL.Core.Dto.WeatherDtos;
using WeatherJKL.Models.Weather;
using WeatherJKL.ApplicationServices.Services;
using WeatherJKL.Core.ServiceInterface;

namespace WeatherJKL.Views
{
    public partial class OpenWeathersPage : ContentPage
    {
        private readonly OpenWeatherResultDto _openWeatherService;

        public OpenWeathersPage(OpenWeatherResultDto openWeatherResult)
        {
            InitializeComponent();

            _openWeatherService = openWeatherResult;
        }

        private async void OnSearchButtonClicked(object sender, EventArgs e)
        {
            string city = cityEntry.Text.Trim();

            if (!string.IsNullOrEmpty(city))
            {
                OpenWeatherResultDto weatherResult = await _openWeatherService.GetWeatherAsync(city);

                if (weatherResult != null)
                {
                    BindingContext = weatherResult;
                    resultLayout.IsVisible = true;
                }
            }
        }
    }
}