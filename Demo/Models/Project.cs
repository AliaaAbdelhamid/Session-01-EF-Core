﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
	internal class Project
	{
		public int Id { get; set; }
		public string PName { get; set; } = null!;
		[InverseProperty(nameof(EmployeeProject.Project))]
		public ICollection<EmployeeProject> ProjectEmployees { get; set; } = new HashSet<EmployeeProject>();
	}
}
