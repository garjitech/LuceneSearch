using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleLucene;
using Lucene.Net.Documents;
using LuceneSearch.Infrastructure.Models;

namespace LuceneSearch.Infrastructure.ResultDefinitions
{
	public class OnTimeItemResultDefinition : IResultDefinition<OnTimeItem>
	{
		public OnTimeItem Convert(Document document)
		{
			var product = new OnTimeItem();
			product.Id = document.GetValue<int>("id");
			product.Title = document.GetValue("name");
			product.Description = document.GetValue("description");
			product.AssignedTo = document.GetValue("assignedto");

			return product;
		}
	}
}