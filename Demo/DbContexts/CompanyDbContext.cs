using Common;
using Demo.ModelConfigurations;
using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DbContexts
{
	internal class CompanyDbContext : DbContext
	{
		public CompanyDbContext():base()
		{
			
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = .; Database = CompanyG06 ; Trusted_Connection = true; TrustServerCertificate=true");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());
			//modelBuilder.ApplyConfiguration(new DepartmentConfigurations());

			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			// Automatically Apply All Fluent Api Configurations From Separate
			// Configuration Classes [Class Implement IEntityTypeConfiguration<>] In The Given Assembly 
			// Assembly.GetExecutingAssembly() -> the one where your DbContext Exists
		}


		public DbSet<Employee> Employees { get; set; }
		public DbSet<Common.Department> Departments { get; set; }
	}
}
