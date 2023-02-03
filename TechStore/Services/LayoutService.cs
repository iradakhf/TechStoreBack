using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Interfaces;
using TechStore.DAL;
using Microsoft.AspNetCore.Http;
using TechStore.Models;
using TechStore.ViewModels.Basket;
using Newtonsoft.Json;

namespace TechStore.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LayoutService(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }


        public async Task<Dictionary<string, string>> GetSettingsAsync()
        {
            return await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
        }


        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.Include(c => c.Children)
                .Where(c => c.IsDeleted == false && c.IsMain).ToListAsync();

        }

        public async Task<IEnumerable<BasketVM>> GetBasketVMsAsync()
        {
            string basket = _httpContextAccessor.HttpContext.Request.Cookies["basket"];
            List<BasketVM> basketVMs = null;
            if (!string.IsNullOrWhiteSpace(basket))
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }
            foreach (BasketVM item in basketVMs)
            {
                Product product = await _context.Products.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == item.Id);
                item.Title = product.Name;
                item.Image = product.MainImage;
                item.Price = product.DiscountedPrice > 0 ? product.DiscountedPrice : product.Price;
            }
            return basketVMs;

        }

        public async Task<IEnumerable<Product>> GetProductAsync()
        {
            return await _context.Products.Where(c => c.IsDeleted == false).ToListAsync();
        }
    }
}
