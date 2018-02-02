using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetSampleBlog.Domain;
using AspNetSampleBlog.Models;

namespace AspNetSampleBlog.Repositories
{
    public class TagRepository : ITagRepository
    {
        private MvcBasicContext db = new MvcBasicContext();

        public IEnumerable<Tag> All()
        {
            return db.Tags.ToList();
        }
    }
}