using AspNetSampleBlog.Models;
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
        public ActionResult Index()
        {
            return View(db.Articles.ToList());
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