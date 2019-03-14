using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webtintuc.Models;

namespace Webtintuc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Hello = "Xin chao";
            ViewData["Xinchao"] = "Xin chao lan 2";
            var model = new HelloModel();
            model.FirstName="Phu";
            model.LastNAme = "Do";
            return View(model);
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