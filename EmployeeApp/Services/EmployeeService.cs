using System;
using EmployeeApp.Models;
using SQLite;

namespace EmployeeApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        public SQLiteAsyncConnection _dbConnection;

        private async Task SetUpDatabase()
        {
            if(_dbConnection == null)
            {
                string dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Employee.db3");
                _dbConnection = new SQLiteAsyncConnection(dbpath);
                await _dbConnection.CreateTableAsync<Employee>();
            }
        }




        public async Task<int> AddEmployee(Employee employee)
        {
            await SetUpDatabase();
            return await _dbConnection.InsertAsync(employee);
        }

        public async Task<int> DeleteEmployee(Employee employee)
        {
            await SetUpDatabase();
            return await _dbConnection.InsertAsync(employee);
        }



        public async Task<List<Employee>> GetEmployeesList()
        {
            var employeesList = await _dbConnection.Table<Employee>().ToListAsync();

                return employeesList;
        }

        public async Task<int> UpdateEmployee(Employee employee)
        {
            return await _dbConnection.InsertAsync(employee);
        }
    }
}