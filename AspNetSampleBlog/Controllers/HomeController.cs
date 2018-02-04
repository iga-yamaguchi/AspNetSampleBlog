using AspNetSampleBlog.Models;
using AspNetSampleBlog.Repositories;
using AspNetSampleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetSampleBlog.Controllers
{
    public class HomeController : Controller
    {
        private IArticleRepository articleRepository;
        private ITagRepository tagRepository;

        public HomeController() : this(new ArticleRepository(), new TagRepository()) { }

        public HomeController(IArticleRepository articleRepository, ITagRepository tagRepository)
        {
            this.articleRepository = articleRepository;
            this.tagRepository = tagRepository;
        }

        public ActionResult Index()
        {
            return View(new HomeViewModel { Articles = articleRepository.All(), Tags = tagRepository.All(), Years = articleRepository.YearList() });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}