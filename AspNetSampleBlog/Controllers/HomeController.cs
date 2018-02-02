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
        private MvcBasicContext db = new MvcBasicContext();
        private IArticleRepository articleRepository;

        public HomeController() : this(new ArticleRepository()) { }

        public HomeController(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public ActionResult Index()
        {
            return View(new HomeViewModel { Articles = articleRepository.All(), Tags = db.Tags.ToList() });
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