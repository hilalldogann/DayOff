using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace EmployeeApp.ViewModels
{
	public partial class EmployeesViewModel : ObservableObject
	{

		[RelayCommand]
		public async void AddUpdateEmployee()
		{
			await AppShell.Current.GoToAsync(nameof(AddEmployee));

		}
	}
}

