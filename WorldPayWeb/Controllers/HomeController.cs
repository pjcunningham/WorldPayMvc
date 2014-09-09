using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorldPayWeb.Models;
using WorldPayMvc;

namespace WorldPayWeb.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {

            var model = new CheckoutViewModel { 

                InstallationId = "YOUR_INTSALLATION_ID",
                CartId = "YOUR_CART_ID",
                Total = 100.00m,
                CurrencyCode = CurrencyCode.GBP,

                Address1 = "10 Downing Street",
                Town = "London",
                PostCode = "SW1A 2AA",
                CountryCode = CountryCode.GB,

                Name = "Prime Minister",
                Email = "dave@gov.uk",
                Telephone = "020 7925 0918"
            
            };

            return View(model);
        }

        public ActionResult About() {
            ViewBag.Message = "WorldPay MVC Helper";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Github";

            return View();
        }
    }
}