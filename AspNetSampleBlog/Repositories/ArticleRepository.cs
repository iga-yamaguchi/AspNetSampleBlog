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
    }
}