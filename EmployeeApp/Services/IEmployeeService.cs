using System;
using EmployeeApp.Models;

namespace EmployeeApp.Services
{
	public interface IEmployeeService
	{
		Task<List<Employee>> GetEmployeesList();


		Task<int> AddEmployee(Employee employee);


        Task<int> DeleteEmployee(Employee employee);

        Task<int> UpdateEmployee(Employee employee);


    }
}

