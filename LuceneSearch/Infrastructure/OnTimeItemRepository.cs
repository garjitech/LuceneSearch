using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LuceneSearch.Infrastructure.Models;

namespace LuceneSearch.Infrastructure
{
	public class OnTimeItemRepository
	{
		public static IList<OnTimeItem> GetItems()
		{
			return new List<OnTimeItem> 
			{
				new OnTimeItem { Id = 1, Title = "Football", Description="Google Analytics Gadget", AssignedTo="Garrett Wolf", CreatedOn = new DateTime(2011, 1, 1)},
				new OnTimeItem { Id = 2, Title = "Trainers", Description="Facebook Gadget", AssignedTo="Mike Wolf", CreatedOn = new DateTime(2011, 2, 15)},
				new OnTimeItem { Id = 3, Title = "Laptop", Description="Dapper Database", AssignedTo="Tyler Wolf", CreatedOn = new DateTime(2010, 12, 28)},
				new OnTimeItem { Id = 4, Title = "DVD", Description="jQuery Widgets", AssignedTo="Garrett Smith", CreatedOn = new DateTime(2010, 11, 5)},
				new OnTimeItem { Id = 5, Title = "Mobile Phone", Description="Dashboard Layout", AssignedTo="Mike Wolfe", CreatedOn = new DateTime(2010, 9, 18)},
				new OnTimeItem { Id = 5, Title = "Phone Cover", Description="OAuth Services", AssignedTo="Garrett Wolfe", CreatedOn = new DateTime(2010, 9, 18)}
			};
		}
	}
}