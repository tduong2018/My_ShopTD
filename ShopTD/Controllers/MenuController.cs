using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopTD.Models;

namespace ShopTD.Controllers
{
    public class MenuController : Controller
    {
        DB_ShopTDEntities db = new DB_ShopTDEntities();
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Parents_menu_Partial()
        {
            var list_Parents_Menu = db.Menus.ToList();
            return PartialView(list_Parents_Menu);
        }
        public PartialViewResult Childrens_menu_Partial(int parent_id)
        {
            var list_Childrens_Menu = db.Menus.Where(n => n.Parent_ID == parent_id).ToList();
            return PartialView(list_Childrens_Menu);
        }
    }
}