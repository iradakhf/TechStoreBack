using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.DAL;
using TechStore.Extension;
using TechStore.Models;

namespace TechStore.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SettingController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            Dictionary<string, string> setting = await _context.Settings.ToDictionaryAsync(k => k.Key, v => v.Value);

            return View(setting);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return BadRequest();
            Setting setting = await _context.Settings.FirstOrDefaultAsync(k => k.Id == id);
            if (setting == null) return NotFound();
            return View(setting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Setting setting)
        {
            if (!ModelState.IsValid)
            {
                return View(setting);
            }

            if (id == null) return BadRequest();
            if (id != setting.Id) return NotFound();

            Setting dbSetting = await _context.Settings.FirstOrDefaultAsync(k => k.Id == id);

            if (dbSetting == null) return NotFound();

            if (setting.Value.Contains(".png"))
            {
                if (setting != null)
                {
                    if (setting.FooterImg == null)
                    {
                        ModelState.AddModelError("FooterImg", "Sekil Mutleq Olmalidi");
                        return View(dbSetting);
                    }
                    if (setting.FooterImg.ContentType != "image/png")
                    {
                        ModelState.AddModelError("FooterImg", "FooterImg type should be png");
                        return View();
                    }
                    if (setting.FooterImg.Length > 20000)
                    {
                        ModelState.AddModelError("FooterImg", "FooterImg length should be less than 20k");
                        return View();
                    }

                    Helper.DeleteFile(_env, dbSetting.Value, "assets", "images", "payment");
                    dbSetting.Value = setting.LogoImg.CreateFile(_env, "assets", "images", "payment");
                }

            }
            else
            {
                dbSetting.Value = setting.Value;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
