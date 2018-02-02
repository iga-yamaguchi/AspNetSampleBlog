using AspNetSampleBlog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetSampleBlog.Repositories
{
    public interface ITagRepository
    {
        IEnumerable<Tag> All();
    }
}
