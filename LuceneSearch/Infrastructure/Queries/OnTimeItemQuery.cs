using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleLucene.Impl;
using Lucene.Net.QueryParsers;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Search;

namespace LuceneSearch.Infrastructure.Queries
{
	public class OnTimeItemQuery : QueryBase
	{
		public OnTimeItemQuery(Query query) : base(query) { }

		public OnTimeItemQuery() { }

		public OnTimeItemQuery WithKeywords(string keywords)
		{
			if (!string.IsNullOrEmpty(keywords))
			{
				string[] fields = { "title", "description", "assignedto" };
				var parser = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_29,
					fields, new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_29));

				parser.SetAllowLeadingWildcard(true);
				parser.SetFuzzyPrefixLength(1);
				Query multiQuery = parser.Parse(keywords);

				this.AddQuery(multiQuery);
			}
			return this;
		}
	}
}