using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MyShop.ViewComponents
{
    public class subMenuViewComponent : ViewComponent
    {
        private readonly DB_ShopTDContext _context;

        public subMenuViewComponent (DB_ShopTDContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int menu_ID)
        {
            return View(await _context.Menu.Where(n => n.ParentId == menu_ID).ToListAsync());
        }
    }
}
