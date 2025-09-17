using DemoInheritance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance.Contexts
{
	internal class MyCompanyDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = .; Database = MyCompanyG06 ; Trusted_Connection = true; TrustServerCertificate=true");

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<FulltimeEmployee>().HasBaseType(typeof(Employee));
			//modelBuilder.Entity<ParttimeEmployee>().HasBaseType(typeof(Employee));

			//modelBuilder.Entity<Employee>()
			//			.HasDiscriminator<int>("EmployeeType")
			//			.HasValue<Employee>(0)
			//			.HasValue<FulltimeEmployee>(1)
			//			.HasValue<ParttimeEmployee>(2);

			modelBuilder.Entity<FulltimeEmployee>().ToTable("FullTimeEmployee");
			modelBuilder.Entity<ParttimeEmployee>().ToTable("PartTimeEmployee");
		}
		public DbSet<Employee> Employees { get; set; }
		public DbSet<FulltimeEmployee> FulltimeEmployees { get; set; }
		public DbSet<ParttimeEmployee> parttimeEmployees { get; set; }
	}
}
