using DayOff.Services;
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
        builder.Services.AddSingleton<IEmployeeService, EmployeeService>();


        //view registration

        builder.Services.AddSingleton<EmployeeListPage>();
        builder.Services.AddTransient<AddUpdateEmployeeDetail>();

        //view models
        builder.Services.AddSingleton<EmployeeListPageViewModel>();
        builder.Services.AddTransient<AddUpdateEmployeeDetailViewModel>();

		//

	
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

