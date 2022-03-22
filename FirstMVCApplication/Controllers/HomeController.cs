using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApplication.Models

namespace FirstMVCApplication.Controllers;
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

        public ActionResult ContactUs()
        {
            Provider p = new Provider();

            p.ProviderId = 1;
            p.ProviderName = "Upadhyay";
            p.ProviderType = "Claim";

            ViewBag.Message = "Good Morning Vikas Upadhyay";
            return View(p);
        }
    }
}