using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeApp.Models;
using EmployeeApp.Services;

namespace EmployeeApp.ViewModels
{
	public partial class EmployeesViewModel : ObservableObject
	{

		public ObservableCollection <Employee> Employees { get; set; } = new ObservableCollection<Employee>();

		public readonly IEmployeeService _employeeService;

		public EmployeesViewModel(IEmployeeService employeeService)
		{
			_employeeService = employeeService;
		}

		[RelayCommand]

		private async Task GetEmployeesList()
		{
			var employees = await _employeeService.GetEmployeesList();
			if(employees.Count > 0)
			{
				foreach(var employee in employees)
				{
					Employees.Add(employee);
				}
			}
		}


		[RelayCommand]
		public async Task AddUpdateEmployee()
		{
			await AppShell.Current.GoToAsync(nameof(AddEmployee));

		}
	}
}

