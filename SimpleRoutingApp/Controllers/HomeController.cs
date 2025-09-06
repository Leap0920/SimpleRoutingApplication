using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleRoutingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Students()
        {
            ViewBag.Message = "Here is the list of students";
            return View();
        }

        public ActionResult Announcements()
        {
            ViewBag.Message = "Here is the Announcements page";
            return View();
        }
        public ActionResult Schedule()
        {
            ViewBag.Message = "Here is the Schedule page";
            return View();
        }
    }
}