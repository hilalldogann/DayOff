using System;
using SQLite;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmployeeApp.Models
{
	public class Employee
	{
        [PrimaryKey, AutoIncrement]

		public int Id { get; set; }

		public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string Department { get; set; }

        public int OffDay { get; set; }

    }
}

