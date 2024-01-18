using CommunityToolkit.Mvvm.Input;
using System;
using CommunityToolkit.Mvvm.ComponentModel;
using DayOff.Views;
using System.Windows.Input;

namespace DayOff.ViewModels
{
	public partial class EmployeeListPageViewModel : ObservableObject
	{

		[ICommand]
		public async void AddUpdateEmployee()
		{
			await AppShell.Current.GoToAsync(nameof(AddUpdateEmployeeDetail));
		}

        private RelayCommand addUpdateEmployeeCommand;
        public ICommand AddUpdateEmployeeCommand => addUpdateEmployeeCommand ??= new RelayCommand(AddUpdateEmployee);

        private void AddUpdateEmployee1()
        {
        }
    }
}

