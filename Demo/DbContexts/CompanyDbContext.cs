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
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

			modelBuilder.Entity<Employee>()
						.HasOne(E => E.ManagedDepartment)
						.WithOne(D => D.Manager)
						.HasForeignKey<Department>(D => D.DeptManagerId)
						.OnDelete(DeleteBehavior.Restrict);
		}



		public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Departments { get; set; }
	}
}
