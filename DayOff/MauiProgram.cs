using DayOff.ViewModels;
using DayOff.Views;
using Microsoft.Extensions.Logging;

namespace DayOff;

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

        //services


        //view registration

        builder.Services.AddSingleton<EmployeeListPage>();

        //view models
        builder.Services.AddSingleton<EmployeeListPageViewModel>();

        //


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

