using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
			optionsBuilder.UseSqlServer("Server = .; Database = CompanyG06 ; Trusted_Connection = true");
		}
		
	}
}
