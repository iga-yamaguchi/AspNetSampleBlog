using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetSampleBlog.Domain.ValueObjects
{
    public class Title
    {
        private string title;

        public Title(string title)
        {
            this.title = title;
        }

        public override string ToString()
        {
            return title;
        }
    }
}
