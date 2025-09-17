using DemoInheritance.Contexts;
using DemoInheritance.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoInheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using MyCompanyDbContext dbContext = new MyCompanyDbContext();
			//FulltimeEmployee fulltimeEmployee = new FulltimeEmployee()
			//{
			//	Name = "Omar",
			//	Address = "Cairo",
			//	Age = 25,
			//	Salary = 50000,
			//	StartDate = DateTime.Now
			//};
			//dbContext.Employees.Add(fulltimeEmployee);

			//ParttimeEmployee parttimeEmployee = new ParttimeEmployee()
			//{
			//	Name = "Salma",
			//	Address = "Giza",
			//	Age = 30,
			//	CountOfHours = 200,
			//	HourRate = 100
			//};
			//dbContext.Add(parttimeEmployee);

			//Employee employee = new Employee()
			//{
			//	Name = "Mohamed",
			//	Address = "Alex",
			//	Age = 50
			//};

			//dbContext.Add(employee);
			//dbContext.SaveChanges();

			var Employees = dbContext.Employees;
			if (Employees is not null)
			{
				foreach (var employee in Employees)
				{
					Console.WriteLine($"{employee.Id} -- {employee.Name} -- {employee.Address} ");
				}
				//Console.WriteLine("===========================");
				//foreach (var employee in Employees.OfType<FulltimeEmployee>())
				//{
				//	Console.WriteLine($"{employee.Id} -- {employee.Name} -- {employee.Address} -- {employee.Salary}");
				//}
			}


			//Console.WriteLine("=========================");
			//var FTEmployee = dbContext.Set<FulltimeEmployee>().FirstOrDefault();
			//if (FTEmployee is not null)
			//{
			//		Console.WriteLine($"{FTEmployee.Id} -- {FTEmployee.Name} -- {FTEmployee.Address} -- {FTEmployee.Salary}");
			//}
			//Console.WriteLine("=========================");
			//var PTEmployee = dbContext.Set<ParttimeEmployee>().FirstOrDefault();
			//if (PTEmployee is not null)
			//{
			//		Console.WriteLine($"{PTEmployee.Id} -- {PTEmployee.Name} -- {PTEmployee.Address} -- {PTEmployee.HourRate}");

			//}
		}
	}
}
