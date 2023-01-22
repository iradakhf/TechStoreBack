using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.DAL;
using TechStore.Models;
using TechStore.ViewComponentModels.ProductV;

namespace TechStore.ViewComponents
{
    public class ProductTabViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public ProductTabViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ProductVM productVM = new ProductVM
            {
                Products = await _context.Products.Include(p => p.Category).Where(c => c.IsDeleted == false).ToListAsync(),
                Categories = await _context.Categories.Where(c => c.IsDeleted == false && c.ParentId==null).ToListAsync()

            };
            return View(await Task.FromResult(productVM));
        }


    }
}
