using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuceneSearch.Infrastructure.Models
{
	public class OnTimeItem
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string AssignedTo { get; set; }
		public DateTime CreatedOn { get; set; }
	}
}