using WeatherJKL.ApplicationServices.Services;
using WeatherJKL.Core.ServiceInterface;

#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;

#endif

namespace WeatherJKL;

public partial class App : Application
{
    const int WindowWidth = 540;
    const int WindowHeight = 1200;
    public App()
	{
		InitializeComponent();

#if WINDOWS
        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
        {
            var mauiWindow = handler.VirtualView;
            var nativeWindow = handler.PlatformView;
            nativeWindow.Activate();
            IntPtr windowhandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
            WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowhandle);
            AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
        });
#endif

        MainPage = new NavigationPage(new WeatherSearchPage(new WeatherForecastsServices()));
    }
}
