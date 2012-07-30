using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleLucene.Impl;
using System.IO;
using LuceneSearch.Infrastructure;
using LuceneSearch.Infrastructure.Queries;
using LuceneSearch.Infrastructure.Models;
using LuceneSearch.Infrastructure.ResultDefinitions;

namespace LuceneSearch.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Items(string search)
		{
			var indexSearcher = IndexManager.GetIndexSearcher();
			OnTimeItemQuery query = query = new OnTimeItemQuery();
			using (var searchService = new SearchService(indexSearcher))
			{
				if (!string.IsNullOrEmpty(search))
				{				
					query = query.WithKeywords(search);
				}
				var result = searchService.SearchIndex<OnTimeItem>(query.Query, new OnTimeItemResultDefinition());
				return Json(result.Results, JsonRequestBehavior.AllowGet);
			}
		}
	}
}
