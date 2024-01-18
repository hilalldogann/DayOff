using DayOff.ViewModels;

namespace DayOff.Views;

public partial class EmployeeListPage : ContentPage
{
	public EmployeeListPage(EmployeeListPageViewModel viewModel)
	{

		InitializeComponent();
		this.BindingContext = viewModel;
	}
}
