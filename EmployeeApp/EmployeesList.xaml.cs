using EmployeeApp.ViewModels;

namespace EmployeeApp;

public partial class EmployeesList : ContentPage
{
	public EmployeesList( EmployeesViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}
