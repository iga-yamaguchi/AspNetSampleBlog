using AspNetSampleBlog.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetSampleBlog.Models
{
    public class MvcBasicInitializer : DropCreateDatabaseIfModelChanges<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            //base.Seed(context);

            var members = new List<Member>
            {
                new Member
                {
                    Name = "山田",
                    Email = "yamada@example.com",
                    Birth = DateTime.Parse("1980-06-25"),
                    Married = false,
                    Memo = "山田だぜい"
                },
                new Member
                {
                    Name = "田中",
                    Email = "tanaka@example.com",
                    Birth = DateTime.Parse("2000-11-05"),
                    Married = true,
                    Memo = "田中だぜい"

                }
            };

            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();

            var articles = new List<Article>
            {
                new Article
                {
                    Title = "記事1",
                    Content = "本文1",
                    Created = DateTime.Now,
                    ImagePath = "imagepath1",
                    Tags = new List<Tag>
                    {
                        new Tag
                        {
                            Name = "タグ1"
                        },
                        new Tag
                        {
                            Name = "タグ2"
                        }
                    }
                }
            };

            articles.ForEach(a => context.Articles.Add(a));
            context.SaveChanges();
        }
    }
}