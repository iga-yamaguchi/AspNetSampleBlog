using AspNetSampleBlog.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetSampleBlog.Models
{
    public class MvcBasicContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}