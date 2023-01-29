using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TechStore.DAL;
using TechStore.Models;

namespace TechStore.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ColorController : Controller
    {
        private readonly AppDbContext _context;
        public ColorController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            IEnumerable<Color> colors = await _context.Colors
                .Include(t => t.ProductColors)
                .Where(c=>c.IsDeleted==false)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();
            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)colors.Count() / 5);

            return View(colors.Skip((page - 1) * 5).Take(5));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Color color)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (string.IsNullOrWhiteSpace(color.Name))
            {
                ModelState.AddModelError("Name", "Bosluq Olmamalidir");
                return View();
            }

            if (!Regex.IsMatch(color.Name, @"^[a-zA-Z /&-]+$"))
            {
                ModelState.AddModelError("Name", "Yalniz herif ola biler");
                return View();
            }

            if (await _context.Colors.AnyAsync(s => s.Name.ToLower() == color.Name.ToLower()))
            {
                ModelState.AddModelError("Name", "Alreade Exists");
                return View();
            }

            color.CreatedAt = DateTime.UtcNow.AddHours(4);

            await _context.Colors.AddAsync(color);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return BadRequest();
            Color colour = await _context.Colors.FirstOrDefaultAsync(s => s.Id == id);
            if (colour == null) return NotFound();
            return View(colour);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Color color, int page = 1)
        {
            if (!ModelState.IsValid)
            {
                return View(color);
            }

            if (id == null) return BadRequest();

            if (id != color.Id) return NotFound();

            Color dbcolour = await _context.Colors.FirstOrDefaultAsync(s => s.Id == id);

            if (dbcolour == null) return NotFound();

            if (string.IsNullOrWhiteSpace(color.Name))
            {
                ModelState.AddModelError("Name", "Bosluq Olmamalidir");
                return View();
            }

            if (!Regex.IsMatch(color.Name, @"^[a-zA-Z /&-]+$"))
            {
                ModelState.AddModelError("Name", "Yalniz herif ola biler");
                return View();
            }

            if (await _context.Colors.AnyAsync(s => s.Name.ToLower() == color.Name.ToLower() && s.Id != color.Id))
            {
                ModelState.AddModelError("Name", "Alreade Exists");
                return View();
            }

            dbcolour.Name = color.Name;
            dbcolour.UpdatedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { page });
        }

        public async Task<IActionResult> Delete(int? id, int page = 1)
        {
            if (id == null) return BadRequest();

            Color dbcolour = await _context.Colors.FirstOrDefaultAsync(t => t.Id == id);

            if (dbcolour == null) return NotFound();

            dbcolour.IsDeleted = true;
            dbcolour.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();

            IEnumerable<Color> colours = await _context.Colors
                .Include(t => t.ProductColors)
                .Where(c=>c.IsDeleted==false)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)colours.Count() / 5);

            return PartialView("_ColorPartial", colours.Skip((page - 1) * 5).Take(5));
        }

        public async Task<IActionResult> Restore(int? id, int page = 1)
        {
            if (id == null) return BadRequest();

            Color dbcolour = await _context.Colors.FirstOrDefaultAsync(t => t.Id == id);

            if (dbcolour == null) return NotFound();

            dbcolour.IsDeleted = false;
            dbcolour.DeletedAt = null;

            await _context.SaveChangesAsync();

            IEnumerable<Color> colours = await _context.Colors
                .Include(c => c.ProductColors)
                .Where(c=>c.IsDeleted ==false)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)colours.Count() / 5);

            return PartialView("_ColorPartial", colours.Skip((page - 1) * 5).Take(5));
        }
    }
}
