using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XmlAttributeExtractor;


namespace XmlAttributeRazorDisplay.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Olife()
        {
            ViewBag.Message = "Your contact page.";
            var XmlString = System.IO.File.ReadAllText(@"C:\AstuteFSE\LoopBack\A_Lion_1952-10-27_OMUL.xml");

            ViewData["Olife"] = XmlString;

            return View();
        }
    }
}