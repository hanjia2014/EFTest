using EFTest.db;
using EFTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFTest.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Child> childRepository = new Repository<Child>();
        private IRepository<Parent> parentRepository = new Repository<Parent>();
        public ActionResult Index()
        {

            var children = childRepository.SelectAll();
            var parents = parentRepository.SelectAll();

            return View();
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