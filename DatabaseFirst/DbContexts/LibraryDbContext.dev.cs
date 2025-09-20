using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Test;

public partial class LibraryDbContext
{
	partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
	{

		modelBuilder.Entity<BookWithCatAndPublisher>()
		            .HasNoKey()             
		            .ToView("BooksWithCatAndPublisher");
	}
}

