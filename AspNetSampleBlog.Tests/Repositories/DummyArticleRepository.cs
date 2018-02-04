using AspNetSampleBlog.Domain;
using AspNetSampleBlog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetSampleBlog.Tests.Repositories
{
    class DummyArticleRepository : IArticleRepository
    {
        public IEnumerable<Article> All()
        {
            return new List<Article>
                {
                    new Article(),
                    new Article(),
                    new Article(),
                };
        }

        public int Delete(Article article)
        {
            throw new NotImplementedException();
        }

        public Article Find(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> FindByYear(int? year)
        {
            throw new NotImplementedException();
        }

        public int Save(Article article)
        {
            throw new NotImplementedException();
        }

        public int Update(Article article)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DateTime> YearList()
        {
            return new List<DateTime>
            {
                new DateTime(),
            };
        }
    }
}
