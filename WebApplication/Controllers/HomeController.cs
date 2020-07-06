using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ServiceReferenceWebApplication.Service1Client client;

        public HomeController()
        {
            client = new ServiceReferenceWebApplication.Service1Client();
        }
        public ActionResult Index()
        {
            var orders = client.GetOrders();
            return View(orders);
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