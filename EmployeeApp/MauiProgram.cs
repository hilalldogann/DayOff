﻿using EmployeeApp.Services;
using EmployeeApp.ViewModels;
using Microsoft.Extensions.Logging;

namespace EmployeeApp;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<IEmployeeService, EmployeeService>();

		//views

		builder.Services.AddSingleton<EmployeesList>();
        builder.Services.AddSingleton<AddEmployee>();

        //viewmodel

        builder.Services.AddSingleton<EmployeesViewModel>();
        builder.Services.AddSingleton<AddEmployeeViewModel>();
        return builder.Build();
	}
}

