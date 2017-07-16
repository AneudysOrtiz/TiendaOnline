using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shoppingStore.Models;

namespace shoppingStore.Controllers
{
    public class StoreController : Controller
    {

        ShoppingStoreEntities storeDB = new ShoppingStoreEntities();
        // GET: Stores
        public ActionResult Index()
        {

            var categories = storeDB.Categories.ToList();
            return View(categories);
        }

        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var categories = storeDB.Categories.ToList();
            return PartialView(categories);

        }

        public ActionResult Details(int id)
        {
            var item = storeDB.Items.Find(id);
            return View(item);
        }

        public ActionResult Browse(string category)
        {
            var categoryModel = storeDB.Categories.Include("Items").Single(c => c.Name == category);
            return View(categoryModel);
        }
    }
}