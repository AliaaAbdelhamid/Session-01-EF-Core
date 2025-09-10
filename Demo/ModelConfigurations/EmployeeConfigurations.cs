﻿using Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ModelConfigurations
{
	internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
			builder.ToTable("EmployeesTable");

			builder.HasKey(E => E.EmpId);
			builder.Property(E => E.EmpId)
				.UseIdentityColumn(10, 10);

			builder.Property(E => E.EmpName)
				    .HasColumnName("EmployeeName") 
				    .HasColumnType("varchar") 
				    .HasMaxLength(50); 

			builder.Property(E => E.Salary)
				.HasPrecision(10, 2);

			builder.Property(e => e.Email)
				 .IsRequired();

			builder.Ignore(e => e.UserName);
		}
	}
}
