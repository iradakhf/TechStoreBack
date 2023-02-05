using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.DAL;
using TechStore.Models;
using TechStore.ViewModels.Basket;

namespace TechStore.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;
        public BasketController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> AddToBasket(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            string basket = HttpContext.Request.Cookies["basket"];

            List<BasketVM> basketVMs = null;

            if (basket != null)
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }

            if (basketVMs.Exists(b => b.ProductId == id))
            {
                basketVMs.Find(b => b.ProductId == id).Count++;
            }
            else
            {
                BasketVM basketVM = new BasketVM
                {
                    ProductId = product.Id,
                    Count = 1,
                    Image = product.MainImage,
                    Title = product.Name,
                    Price = product.DiscountedPrice > 0 ? product.DiscountedPrice : product.Price
                };

                basketVMs.Add(basketVM);
            }


            basket = JsonConvert.SerializeObject(basketVMs);

            HttpContext.Response.Cookies.Append("basket", basket);

            return PartialView("_BasketCartPartial", basketVMs);
        }
        public async Task<IActionResult> DeleteFromBasket(int? id)
        {
            if (id == null) return BadRequest();

            if (!await _context.Products.AnyAsync(p => p.Id == id)) return NotFound();

            string basket = HttpContext.Request.Cookies["basket"];

            if (string.IsNullOrWhiteSpace(basket)) return BadRequest();

            List<BasketVM> basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);

            BasketVM basketVM = basketVMs.Find(b => b.ProductId == id);

            if (basketVM == null) return NotFound();

            basketVMs.Remove(basketVM);

            basket = JsonConvert.SerializeObject(basketVMs);
            HttpContext.Response.Cookies.Append("basket", basket);

            return PartialView("_BasketCartPartial", await _getBasketItemAsync(basketVMs));
        }
        private async Task<List<BasketVM>> _getBasketItemAsync(List<BasketVM> basketVMs)
        {
            foreach (BasketVM item in basketVMs)
            {
                Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == item.ProductId);

                item.Title = dbProduct.Name;
                item.Price = dbProduct.Price > 0 ? dbProduct.Price : dbProduct.DiscountedPrice;
                item.Image = dbProduct.MainImage;
            }

            return basketVMs;
        }
        
    }
}
