using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private DataContext dbContext = new DataContext();
        public ActionResult Index()
        {
            var category = new Category { CategoryID = 1, Name = "Book" };
            dbContext.Category.Add(category);
            dbContext.SaveChanges();
            return View();
        }
    }
}