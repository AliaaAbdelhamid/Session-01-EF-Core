using Demo.DbContexts;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
	{
		static void Main(string[] args)
		{

			//CompanyDbContext dbContext = new CompanyDbContext();

			//dbContext.Students.Add(new Student()
			//{
			//	SName = "Aliaa"
			//});


			//dbContext.Courses.AddRange(
			//	new Course() { CName = "OOP" },
			//	new Course() { CName = "C#" },
			//	new Course() { CName = "EF Core" });

			//dbContext.SaveChanges();


			//var Course02 = dbContext.Courses.FirstOrDefault(C => C.CourseId == 2);
			//var Course03 = dbContext.Courses.FirstOrDefault(C => C.CourseId == 3);
			//var Student = dbContext.Students.FirstOrDefault(S => S.StudentId == 1);

			//if (Course02 is not null  && Student is not null)
			//{
			//	Student.StdCourses.Add(new StudentCourse()
			//	{
			//		Student = Student,
			//		Course = Course02,
			//		Grade = 100
			//	});
			//}

			//if (Course03 is not null && Student is not null)
			//{
			//	Student.StdCourses.Add(new StudentCourse()
			//	{
			//		Student = Student,
			//		Course = Course03,
			//		Grade = 60
			//	});
			//}
			//dbContext.SaveChanges();
		}
	}
}
