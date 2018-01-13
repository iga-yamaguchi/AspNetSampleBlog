using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetSampleBlog.Domain
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
