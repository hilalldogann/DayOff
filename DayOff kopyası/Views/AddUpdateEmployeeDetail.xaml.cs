using DayOff.ViewModels;

namespace DayOff.Views;

public partial class AddUpdateEmployeeDetail : ContentPage
{
    public AddUpdateEmployeeDetail(AddUpdateEmployeeDetailViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}

}
