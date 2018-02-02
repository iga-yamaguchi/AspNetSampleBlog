using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetSampleBlog.Domain;
using AspNetSampleBlog.Models;

namespace AspNetSampleBlog.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private MvcBasicContext db = new MvcBasicContext();

        public IEnumerable<Article> All()
        {
            return db.Articles.ToList();
        }

        public IEnumerable<Article> FindByYear(int year)
        {
            return db.Articles.Where(i => i.Created.Year == year)
                .ToList();
        }

        public IEnumerable<DateTime> YearList()
        {
            return db.Articles.GroupBy(i => i.Created)
                .Select(i => i.Key)
                .ToList();
        }
    }
}