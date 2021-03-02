using reFactorPrj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reFactorPrj.Controllers
{
    public class HomeController : Controller
    {
        private reModel db = new reModel();
        public ActionResult Index()
        {
            // OrderBy...Take...取亂數(6)筆
            return View(db.tRecipe.OrderBy(x => Guid.NewGuid()).Take(6).ToList());
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