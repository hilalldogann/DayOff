using DayOff.Views;

namespace DayOff;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();


		Routing.RegisterRoute(nameof(AddUpdateEmployeeDetail), typeof(AddUpdateEmployeeDetail));

	}
}

