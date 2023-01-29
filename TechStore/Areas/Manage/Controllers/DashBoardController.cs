using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.DAL;

namespace TechStore.Areas.Manage.Controllers
{
    [Area("Manage")]

    public class DashBoardController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public DashBoardController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {

            return View();
        }

    }
}
