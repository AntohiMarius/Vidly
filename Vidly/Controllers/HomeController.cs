using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
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

        [Route("home/customers/details/{id:regex(Id.Customer)}")]
        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "Marius Antohi"},
                new Customer {Name = "Florin Straton"}
            };

            return View(customers);
        }
    }
}