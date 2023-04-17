using WeatherJKL.ApplicationServices.Services;
using WeatherJKL.Core.ServiceInterface;

namespace WeatherJKL;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddScoped<IWeatherForecastsServices, WeatherForecastsServices>();

        return builder.Build();
	}
}
