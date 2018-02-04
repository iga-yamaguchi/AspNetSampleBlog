using AspNetSampleBlog.Domain;
using AspNetSampleBlog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetSampleBlog.Tests.Repositories
{
    class DummyTagRepository : ITagRepository
    {
        public IEnumerable<Tag> All()
        {
            return new List<Tag>
            {
                new Tag(),
            };
        }
    }
}
