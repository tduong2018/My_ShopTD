using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MyShop.Views.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly DB_ShopTDContext _context;
        public MenuViewComponent(DB_ShopTDContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Menu.ToListAsync());
        }
    }
}
