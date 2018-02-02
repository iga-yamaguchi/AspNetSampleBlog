using AspNetSampleBlog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetSampleBlog.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Article> Articles { get; set; }

        public IEnumerable<Tag> Tags { get; set; }
        
        public IEnumerable<DateTime> Years { get; set; }
    }
}