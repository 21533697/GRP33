using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBookingRoles.Models.PayPal;
using MyBookingRoles.Models.Store;

namespace MyBookingRoles.Controllers.PayPal
{
    public class PayPalController : Controller
    {
        // GET: PayPal
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ValidateCommand()
        {
            bool useSandbox = Convert.ToBoolean(ConfigurationManager.AppSettings["IsSandbox"]);
            var paypal = new PayPalModel(useSandbox);
            var item = new Item();
            paypal.item_name = item.Pr.ProductName;
            paypal.amount = item.Price.ToString();
            paypal.item_quantity = item.Quantity.ToString();
            return View(paypal);
        }
        public ActionResult RedirectFromPaypal()
        {
            return View();
        }

        public ActionResult CancelFromPaypal()
        {
            return View();
        }

        public ActionResult NotifyFromPaypal()
        {
            return View();
        }
    }
}