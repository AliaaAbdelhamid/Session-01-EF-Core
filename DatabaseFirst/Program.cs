
using DatabaseFirst.Models;
using DatabaseFirst.Test;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace DatabaseFirst
{
	internal class Program
	{
		static void Main(string[] args)
		{

			using LibraryDbContext dbContext = new LibraryDbContext();

			#region For SELECT Queries (Returning Entities)

			//var result = dbContext.Book.FromSql($"SELECT * FROM Book").ToList();

			//var ShelfCode = "A1";
			//result = dbContext.Book.FromSqlInterpolated($"SELECT * FROM Book WHERE Shelf_code = {ShelfCode}").ToList();


			//var CatId = 1;
			//result = dbContext.Book.FromSqlRaw("SELECT * FROM Book WHERE Cat_id = {0}", CatId).ToList();

			//var Categories = dbContext.Set<CategoryBooks>().FromSqlRaw("EXEC SP_BOOK_CATEGORY").ToList();

			//foreach (var category in Categories)
			//	Console.WriteLine($"{category.Cat_name}- {category.CountOfBooks}"); 
			#endregion

			#region For Non-Query Commands (INSERT, UPDATE, DELETE)

			#region Example 01
			//string title = "C# Basics";
			//int CatId = 1;
			//int PublisherId = 3;
			//string ShelfCode = "A1";
			//int PublishedYear = 2025;

			//int rowsAffected = dbContext.Database
			//	                        .ExecuteSqlInterpolated( @$"INSERT INTO [dbo].[Book]
			//                                                                     ([Title]
			//                                                                     ,[Cat_id]
			//                                                                     ,[Publisher_id]
			//                                                                     ,[Shelf_code]
			//                                                                     ,[PublishedYear])
			//                                                                       VALUES
			//                                                                     ({title} , {CatId} , {PublisherId} , {ShelfCode} , {PublishedYear})");

			//Console.WriteLine($"{rowsAffected} rows updated"); 
			#endregion

			#region Example 02

			//int BookId = 24;
			//var Result = dbContext.Database.ExecuteSql($"DELETE FROM Book WHERE Id = {BookId}");
			//Result = dbContext.Database.ExecuteSqlRaw("DELETE FROM Book WHERE Id = ", 23);
			//BookId = 22;
			//Result = dbContext.Database.ExecuteSqlInterpolated($"DELETE FROM Book WHERE Id = {BookId}");

			#endregion


			#endregion

			#region Stored Procedure

			//int CatId = 1;
			//var books = dbContext.Book
			//                          .FromSqlInterpolated($"EXEC GetBooksByCategory {CatId}")
			//                          .ToList();

			//foreach (var item in books)
			//	Console.WriteLine(item.Title);

			#endregion

			#region Views 

			//var Result = dbContext.Set<BookWithCatAndPublisher>().Where(X => X.PublisherName == "HarperCollins ");

			//foreach (var item in Result)
			//	Console.WriteLine($"{item.BookTitle} - {item.PublisherName} - {item.CategoryName}");

			#endregion
		}
	}
}
