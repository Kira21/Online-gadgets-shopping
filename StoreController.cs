using AcKyGadgets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcKyGadgets.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        AckyGadgetsEntities storeDB = new AckyGadgetsEntities();
        public ActionResult Index()
        {
            var category = storeDB.Categories.ToList();

            return View(category);
        }
        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var categories = storeDB.Categories.ToList();
            return PartialView("categories");
        }
        public ActionResult Browse(string category)
        {
            var categorymodel = storeDB.Categories.Include("Items").Single(c => c.CategoryName == category);
            return View(categorymodel);
        }
        public ActionResult Details(int id)
        {
            var Item = storeDB.Items.Find(id);

            return View(Item);
        }
    }
}