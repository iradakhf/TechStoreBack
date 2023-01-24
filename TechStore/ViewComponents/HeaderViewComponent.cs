using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.DAL;
using TechStore.ViewComponentModels.HeaderV;

namespace TechnoStore.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
      
        public async Task<IViewComponentResult> InvokeAsync(HeaderVM headerVM)
        {
            return View(await Task.FromResult(headerVM));
        }
    }
}
