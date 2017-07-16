using shoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoppingStore.Controllers
{
    public class HomeController : Controller
    {
        ShoppingStoreEntities StoreDb = new ShoppingStoreEntities();
        private List<Item> GetTopSellingItems(int count)
        {
            return StoreDb.Items.OrderByDescending(i => i.OrderDetails.Count()).Take(count).ToList();
        }

        public ActionResult Index()
        {
            var items = GetTopSellingItems(5);

            return View(items);
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