using AspNetSampleBlog.Domain.ValueObjects;
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

        private Title title;

        [Required]
        public string Title
        {
            get { return title.ToString(); }
            set { this.title = new ValueObjects.Title(value); }
        }

        [Required]
        public string Content { get; set; }

        public string ImagePath { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
