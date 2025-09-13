﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Demo.Models
{
	internal class Employee
	{
		public int EmpId { get; set; }
		public string? EmpName { get; set; }
		public decimal Salary { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string? Password { get; set; }
		[NotMapped]
		public string? UserName => Email.Split('@').ToString();

		// Navigation Property [One]
		// Ef Core -> Employee May Be Manage One Department [Optional]
		public Department? ManagedDepartment { get; set; } = null!;
	}
}
