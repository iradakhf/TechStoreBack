using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.DAL;
using TechStore.Models;
using TechStore.ViewModels.WishlistV;
using TechStore.ViewModels.Basket;

namespace TechStore.Controllers
{
    public class WishlistController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public WishlistController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            string basket = HttpContext.Request.Cookies["basket"];

            List<WishlistVM> wishlistVMs = null;

            if (!string.IsNullOrWhiteSpace(basket))
            {
                wishlistVMs = JsonConvert.DeserializeObject<List<WishlistVM>>(basket);
            }
            else
            {
                wishlistVMs = new List<WishlistVM>();
            }

            return View(await _getBasketItemAsync(wishlistVMs));
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

            List<WishlistVM> WishlistVMs = null;

            if (!string.IsNullOrWhiteSpace(basket))
            {
                WishlistVMs = JsonConvert.DeserializeObject<List<WishlistVM>>(basket);
            }
            else
            {
                WishlistVMs = new List<WishlistVM>();
            }

            if (WishlistVMs.Exists(b => b.ProductId == id))
            {
                WishlistVMs.Find(b => b.ProductId == id).Count++;
            }
            else
            {
                WishlistVM WishlistVM = new WishlistVM
                {
                    ProductId = product.Id,
                    Count = 1
                };

                WishlistVMs.Add(WishlistVM);
            }

            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.Users.Include(u => u.Wishlists).FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);

                if (appUser.Wishlists != null && appUser.Wishlists.Count() > 0)
                {
                    Wishlist dbBasket = appUser.Wishlists.FirstOrDefault(b => b.ProductId == id);

                    if (dbBasket != null)
                    {
                        dbBasket.Count += 1;
                    }
                    else
                    {
                        Wishlist newBasket = new Wishlist
                        {
                            ProductId = (int)id,
                            Count = 1
                        };

                        appUser.Wishlists.Add(newBasket);
                    }
                }
                else
                {
                    List<Wishlist> Wishlists = new List<Wishlist>
                    {
                        new Wishlist{ProductId = (int)id, Count = 1}
                    };

                    appUser.Wishlists = Wishlists;
                }

                await _context.SaveChangesAsync();
            }

            basket = JsonConvert.SerializeObject(WishlistVMs);

            HttpContext.Response.Cookies.Append("basket", basket);

            return PartialView("_WishlistPartial", await _getBasketItemAsync(WishlistVMs));
        }

        public async Task<IActionResult> GetBasket()
        {
            string basket = Request.Cookies["basket"];

            List<WishlistVM> WishlistVMs = null;

            if (!string.IsNullOrWhiteSpace(basket))
            {
                WishlistVMs = JsonConvert.DeserializeObject<List<WishlistVM>>(basket);
            }
            else
            {
                WishlistVMs = new List<WishlistVM>();
            }

            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.Users.Include(u => u.Wishlists).FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);

                if (appUser.Wishlists != null && appUser.Wishlists.Count() > 0)
                {
                    foreach (var item in appUser.Wishlists)
                    {
                        if (!WishlistVMs.Any(b => b.ProductId == item.ProductId))
                        {
                            WishlistVM WishlistVM = new WishlistVM
                            {
                                ProductId = item.ProductId,
                                Count = item.Count
                            };

                            WishlistVMs.Add(WishlistVM);
                        }
                    }

                    basket = JsonConvert.SerializeObject(WishlistVMs);

                    Response.Cookies.Append("basket", basket);
                }
            }

            return PartialView("_WishlistPartial", await _getBasketItemAsync(WishlistVMs));
        }

        public async Task<IActionResult> DeleteFromCart(int? id)
        {
            if (id == null) return BadRequest();

            if (!await _context.Products.AnyAsync(p => p.Id == id)) return NotFound();

            string basket = HttpContext.Request.Cookies["basket"];

            if (string.IsNullOrWhiteSpace(basket)) return BadRequest();

            List<WishlistVM> WishlistVMs = JsonConvert.DeserializeObject<List<WishlistVM>>(basket);

            WishlistVM WishlistVM = WishlistVMs.Find(b => b.ProductId == id);

            if (WishlistVM == null) return NotFound();

            WishlistVMs.Remove(WishlistVM);

            basket = JsonConvert.SerializeObject(WishlistVMs);
            HttpContext.Response.Cookies.Append("basket", basket);

            return PartialView("_WishlistPartial", await _getBasketItemAsync(WishlistVMs));
        }
        private async Task<List<WishlistVM>> _getBasketItemAsync(List<WishlistVM> WishlistVMs)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.Users.Include(u => u.Wishlists).FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);


            }


            foreach (WishlistVM item in WishlistVMs)
            {
                Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == item.ProductId);

                item.Title = dbProduct.Name;
                item.Price = dbProduct.DiscountedPrice > 0 ? dbProduct.DiscountedPrice : dbProduct.Price;
                item.Image = dbProduct.MainImage;
            }

            return WishlistVMs;
        }

    }
}
