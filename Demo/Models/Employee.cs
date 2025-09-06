using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
	// Model [POCO Class] : Plain Old CLR Object [Domain Entity ]
	internal class Employee
	{
		public int Id { get; set; }
		// Public Numeric Property Named With Id Or (<Entity>Id)
		// Automatically Assumed To Be The Primary Key Of Table With Identity Constraints

		public string? EmpName	 { get; set; }
		// Null able Reference Type 
		// String? Is Mapped To NVarchar(Max) Nullable 
		public decimal Salary { get; set; }
		// Value Type 
		// Salary Is Mapped To Decimal(18,2) Not Allow Null
		public int Age { get; set; }
		// Value Type 
		// Age Is Mapped To int Not Allow Null

	}
}
