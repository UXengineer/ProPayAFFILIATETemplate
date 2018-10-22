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
        public ActionResult PricingTwo()
        {
            return View();
        }
        public ActionResult Template()
        {
            return View();
        }
    }
}