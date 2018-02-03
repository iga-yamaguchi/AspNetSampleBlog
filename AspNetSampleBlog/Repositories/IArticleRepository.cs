using AspNetSampleBlog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetSampleBlog.Repositories
{
    public interface IArticleRepository
    {
        IEnumerable<Article> All();

        Article Find(int? id);

        IEnumerable<Article> FindByYear(int? year);

        IEnumerable<DateTime> YearList();

        int Save(Article article);

        int Update(Article article);

        int Delete(Article article);
    }
}
