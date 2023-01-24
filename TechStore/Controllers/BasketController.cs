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
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> AddToBasket(int? id)
        {
            if (id == null)
            {
                return BadRequest("id null ola bilmez");
            }
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);

            if (!await _context.Products.AnyAsync(p => p.IsDeleted == false && p.Id == id))
            {
                return NotFound("Id Yanlisdir");
            }

            string basket = HttpContext.Request.Cookies["basket"];
            List<BasketVM> products = null;
            if (!string.IsNullOrWhiteSpace(basket))
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                BasketVM basketVM = products.Find(p => p.Id == id);
                if (basketVM != null)
                {
                    basketVM.Count += 1;
                }
                else
                {
                    basketVM = new BasketVM
                    {
                        Id = (int)id,
                        Count = 1
                    };
                    products.Add(basketVM);
                }
            }
            else
            {
                products = new List<BasketVM>();
                BasketVM basketVM = new BasketVM
                {
                    Id = (int)id,
                    Count = 1
                };
                products.Add(basketVM);


            }
            basket = JsonConvert.SerializeObject(products);
            HttpContext.Response.Cookies.Append("basket", basket);
            foreach (BasketVM item in products)
            {
                product = await _context.Products.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == item.Id);
                item.Title = product.Name;
                item.Image = product.MainImage;
                item.Price = product.Price > 0 ? product.Price : product.DiscountedPrice;
          
            }
            return PartialView("_BasketCartPartial", products);
        }
       public async Task<IActionResult> DeleteFromBasket(int? id)
        {

            if (id == null) return BadRequest();

            if (!await _context.Products.AnyAsync(p => p.Id == id)) return NotFound();

            List<BasketVM> basketVMs = null;

            string coockie = HttpContext.Request.Cookies["basket"];

            if (coockie != null)
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(coockie);

                if (!basketVMs.Any(b => b.Id == id)) return NotFound();

                BasketVM basketVM = basketVMs.FirstOrDefault(b => b.Id == id);

                basketVMs.Remove(basketVM);
            }
            else
            {
                basketVMs = new List<BasketVM>();
            }

            coockie = JsonConvert.SerializeObject(basketVMs);

            HttpContext.Response.Cookies.Append("basket", coockie);

            foreach (BasketVM basketVM in basketVMs)
            {
                basketVM.Title = _context.Products.FirstOrDefault(p => p.Id == basketVM.Id).Name;
                basketVM.Image = _context.Products.FirstOrDefault(p => p.Id == basketVM.Id).MainImage;
                basketVM.Price = _context.Products.FirstOrDefault(p => p.Id == basketVM.Id).Price;
            }


            return PartialView("_BasketCartPartial", basketVMs);
        }
        public async Task<IActionResult> GetBasketContent()
        {
            string pro = HttpContext.Request.Cookies["basket"];
            List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(pro);
            return Json(products);

        }
    }
}
