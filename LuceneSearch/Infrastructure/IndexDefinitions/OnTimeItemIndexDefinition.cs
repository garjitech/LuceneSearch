using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleLucene;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using LuceneSearch.Infrastructure.Models;

namespace LuceneSearch.Infrastructure.IndexDefinitions
{
	public class OnTimeItemIndexDefinition : IIndexDefinition<OnTimeItem>
	{
		public Document Convert(OnTimeItem entity)
		{
			var document = new Document();
			document.Add(new Field("id", entity.Id.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
			document.Add(new Field("name", entity.Title, Field.Store.YES, Field.Index.ANALYZED));
			document.Add(new Field("description", entity.Description, Field.Store.NO, Field.Index.ANALYZED));
			document.Add(new Field("assignedto", entity.AssignedTo, Field.Store.YES, Field.Index.ANALYZED));
			document.Add(new Field("createdon", DateTools.DateToString(entity.CreatedOn, DateTools.Resolution.DAY), Field.Store.YES, Field.Index.NOT_ANALYZED));
			return document;
		}

		public Term GetIndex(OnTimeItem entity)
		{
			return new Term("id", entity.Id.ToString());
		}
	}
}