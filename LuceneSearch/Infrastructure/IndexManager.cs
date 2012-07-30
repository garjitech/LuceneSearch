using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using SimpleLucene.Impl;
using LuceneSearch.Infrastructure.IndexDefinitions;

namespace LuceneSearch.Infrastructure
{
	public class IndexManager
	{
		public static void BuildIndex()
		{
			var indexPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Index");
			var indexWriter = new DirectoryIndexWriter(new DirectoryInfo(indexPath), true);

			using (var indexService = new IndexService(indexWriter))
			{
				var result = indexService.IndexEntities(OnTimeItemRepository.GetItems(), new OnTimeItemIndexDefinition());
			}
		}

		public static DirectoryIndexSearcher GetIndexSearcher()
		{
			var indexPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Index");
			var indexSearcher = new DirectoryIndexSearcher(new DirectoryInfo(indexPath), true);
			return indexSearcher;
		}
	}
}