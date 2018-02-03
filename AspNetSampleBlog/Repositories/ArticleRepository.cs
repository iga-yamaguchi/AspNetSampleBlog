using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public Article Find(int? id)
        {
            return db.Articles.Find(id);
        }

        public IEnumerable<Article> FindByYear(int? year)
        {
            return db.Articles.Where(i => i.Created.Year == year)
                .ToList();
        }

        public int Save(Article article)
        {
            db.Articles.Add(article);
            return db.SaveChanges();
        }

        public int Update(Article article)
        {
            db.Entry(article).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public int Delete(Article article)
        {
            db.Articles.Remove(article);
            return db.SaveChanges();
        }

        public IEnumerable<DateTime> YearList()
        {
            return db.Articles.GroupBy(i => i.Created)
                .Select(i => i.Key)
                .ToList();
        }
    }
}