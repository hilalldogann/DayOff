using System;
using DayOff.Models;
using SQLite;

namespace DayOff.Services
{
    public class EmployeeService : IEmployeeService
    {
        private SQLiteAsyncConnection _dbConnection;

        public EmployeeService()
        {
            SetUpDb();
        }

        private async void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Employee.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                 await _dbConnection.CreateTableAsync<EmployeeModel>();


            }
        }

        public Task<int> AddEmployee(EmployeeModel employeeModel)
        {
           return _dbConnection.InsertAsync(employeeModel);
        }

        public Task<int> DeleteEmployee(EmployeeModel employeeModel)
        {
            return _dbConnection.DeleteAsync(employeeModel);
        }

        public async Task<List<EmployeeModel>> GetEmployeeList()
        {
            var employeeList = await _dbConnection.Table<EmployeeModel>().ToListAsync();
            return employeeList;

        }

        public Task<int> UpdateEmployee(EmployeeModel employeeModel)
        {
            
            return _dbConnection.UpdateAsync(employeeModel);
        }

      
        
    }
}

