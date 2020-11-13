using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P01_U3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Comedia()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Terror()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Drama()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Accion()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Romanticas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Infantiles()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}