using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
	internal class Department
	{
		public int DeptId { get; set; }

		public string DeptName { get; set; }

		public DateTime DateOfCreation { get; set; }

		public int Serial { get; set; }

		// Navigation Property [One]
		// Ef Core -> Department Has One Employee To Manage It [Mandatory]
		public Employee Manager { get; set; } = null!;

		// Foreign Key
		// By Convention : [ManagerId , ManagerEmpId , EmployeeId , EmployeeEmpId]
		// In One To One Relationship Foreign Key Must be Specified 

		//// By Data Annotation 
		//[ForeignKey(nameof(Manager))]
		public int DeptManagerId { get; set; }
	}
}
