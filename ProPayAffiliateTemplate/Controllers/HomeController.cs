using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProPayAffiliateTemplate.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Affiliates()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
        public ActionResult PricingOne()
        {
            return View();
        }
        public ActionResult PricingTwo()
        {
            return View();
        }
        public ActionResult PricingThree()
        {
            return View();
        }

        public ActionResult Template()
        {
            return View();
        }
    }
}