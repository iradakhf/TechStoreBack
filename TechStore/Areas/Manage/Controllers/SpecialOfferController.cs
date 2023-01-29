using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Areas.Manage.Controllers
{
    public class SpecialOfferController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
