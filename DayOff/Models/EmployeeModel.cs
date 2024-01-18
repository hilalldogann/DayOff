using System;
using SQLite;

namespace DayOff.Models
{
    public class EmployeeModel
	{
        [PrimaryKey, AutoIncrement]

		public int EmployeeID { get; set; }

		public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int OffDay { get; set; }
    }
}

