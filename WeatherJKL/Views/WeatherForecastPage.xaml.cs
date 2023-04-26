using Microsoft.Maui.Controls;
using System;
using WeatherJKL.Core.Dto.WeatherDtos;
using WeatherJKL.Models.Weather;
using WeatherJKL.ApplicationServices.Services;
using WeatherJKL.Core.ServiceInterface;
using Microsoft.Extensions.Hosting;

namespace Views
{
    public partial class WeatherForecastPage : ContentPage
    {
        private readonly IWeatherForecastsServices _weatherForecastsServices;
        private WeatherViewModel _viewModel;

        public WeatherForecastPage(IWeatherForecastsServices weatherForecastsServices)
        {
            InitializeComponent();
            _weatherForecastsServices = weatherForecastsServices;
            _viewModel = new WeatherViewModel();
            BindingContext = _viewModel;

            // Call the method to display the weather forecast
            OnSearchButtonClicked(null, null);
        }

        public async void OnSearchButtonClicked(object sender, EventArgs e)
        {
            string city = Preferences.Get("city", "");

            if (!string.IsNullOrEmpty(city))
            {
                OpenWeatherResultDto weatherResult = await _weatherForecastsServices.OpenWeatherResult(new OpenWeatherResultDto { City = city });

                if (weatherResult != null)
                {
                    _viewModel.City = weatherResult.City;
                    _viewModel.Temperature = $"{weatherResult.Temp} °C";
                    _viewModel.Description = weatherResult.Description;
                    _viewModel.Humidity = $"Humidity: {weatherResult.Humidity}%";
                    _viewModel.WindSpeed = $"Wind speed: {weatherResult.Speed} m/s";
                }
            }
        }
    }

    public class WeatherViewModel : BindableObject
    {
        private string _city;
        public string City
        {
            get { return _city; }
            set { _setField(ref _city, value); OnPropertyChanged(); }
        }
        private string _temperature;
        public string Temperature
        {
            get { return _temperature; }
            set { _setField(ref _temperature, value); OnPropertyChanged(); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _setField(ref _description, value); OnPropertyChanged(); }
        }

        private string _humidity;
        public string Humidity
        {
            get { return _humidity; }
            set { _setField(ref _humidity, value); OnPropertyChanged(); }
        }

        private string _windSpeed;
        public string WindSpeed
        {
            get { return _windSpeed; }
            set { _setField(ref _windSpeed, value); OnPropertyChanged(); }
        }

        private void _setField<T>(ref T field, T value)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
            }
        }
    }
}