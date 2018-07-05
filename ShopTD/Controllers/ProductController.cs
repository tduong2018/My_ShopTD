using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopTD.Models;

namespace ShopTD.Controllers
{
    public class ProductController : Controller
    {
        DB_ShopTDEntities db = new DB_ShopTDEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Products_Partial()
        {
            return PartialView(db.Products.ToList());
        }
    }
}