using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.Models
{
	internal class BookWithCatAndPublisher
	{
		public string BookTitle { get; set; } = null!;
		public string PublisherName { get; set; } = null!;
		public string CategoryName { get; set; } = null!;
	}
}
