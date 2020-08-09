using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MathCaptcha;

namespace UiApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var r=Captcha.GetCaptcha();
            ViewBag.Image = r[0];
            ViewBag.Answer = r[1];

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