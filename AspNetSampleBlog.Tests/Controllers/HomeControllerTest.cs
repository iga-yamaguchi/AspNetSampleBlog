﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetSampleBlog;
using AspNetSampleBlog.Controllers;
using AspNetSampleBlog.Repositories;
using Moq;
using AspNetSampleBlog.Domain;
using AspNetSampleBlog.Tests.Repositories;
using AspNetSampleBlog.ViewModels;

namespace AspNetSampleBlog.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //var articleMock = new Mock<IArticleRepository>();
            //articleMock.Setup(c => c.All())
            //    .Returns(new List<Article>()
            //    {
            //        new Article(),
            //        new Article(),
            //        new Article(),
            //    });
            //var articleRepository = articleMock.Object;

            //var tagMock = new Mock<ITagRepository>();
            //tagMock.Setup(c => c.All())
            //    .Returns(new List<Tag>()
            //    {
            //        new Tag(),
            //        new Tag(),
            //    });
            //var tagRepository = tagMock.Object;

            // Arrange
            //HomeController controller = new HomeController(articleRepository, tagRepository);
            HomeController controller = new HomeController(new DummyArticleRepository(), new DummyTagRepository());

            // Act
            ViewResult result = controller.Index() as ViewResult;
            var model = (HomeViewModel)result.Model;

            // Assert
            Assert.AreEqual(3, model.Articles.Count());
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
