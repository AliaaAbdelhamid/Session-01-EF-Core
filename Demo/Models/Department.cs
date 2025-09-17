﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Demo.Models
{
	internal class Department
	{
		public int DeptId { get; set; }

		public string DeptName { get; set; }

		public DateTime DateOfCreation { get; set; }

		public int Serial { get; set; }

		[InverseProperty(nameof(Employee.ManagedDepartment))]
		public virtual Employee Manager { get; set; } = null!;

		public int? DeptManagerId { get; set; }

		// Navigation Property [One]
		// Department Contains Many Employees
		[InverseProperty(nameof(Employee.EmployeeDepartment))]
		public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

	}
}
