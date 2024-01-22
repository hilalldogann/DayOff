using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeApp.Models;
using EmployeeApp.Services;

namespace EmployeeApp.ViewModels
{
	public partial class AddEmployeeViewModel :ObservableObject
	{
		private readonly IEmployeeService _employeeService;

        public AddEmployeeViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

            EmployeeDetails = new Employee();

        }

        [ObservableProperty]

		public Employee employeeDetails;

		[RelayCommand]

		public async Task AddEmployee()
		{

			var response = await  _employeeService.AddEmployee(EmployeeDetails);
			if( response > 0)
			{
				await Shell.Current.DisplayAlert("record added", "employee submitted", "ok");

			}
			else
			{
				await Shell.Current.DisplayAlert("record not added", "employee not submitted", "ok");

            }
		}

	}
}

