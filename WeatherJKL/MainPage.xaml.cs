using WeatherJKL.ApplicationServices.Services;
using WeatherJKL.Core.ServiceInterface;

namespace WeatherJKL;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnSearchClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new WeatherSearchPage(new WeatherForecastsServices()));
    }
}

