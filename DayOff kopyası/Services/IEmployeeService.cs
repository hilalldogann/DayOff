using System;
using DayOff.Models;

namespace DayOff.Services
{
	public interface IEmployeeService
	{
		Task<List<EmployeeModel>> GetEmployeeList();

		Task<int> AddEmployee(EmployeeModel employeeModel);

        Task<int> DeleteEmployee(EmployeeModel employeeModel);

        Task<int> UpdateEmployee(EmployeeModel employeeModel);
    }

}

