using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AspNetSampleBlog.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public string ImagePath { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}