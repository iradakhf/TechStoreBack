using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Models;
using TechStore.ViewModels.Basket;

namespace TechStore.ViewComponentModels.HeaderV
{
    public class HeaderVM
    {
        public Dictionary<string, string> Settings { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BasketVM> BasketVMs { get; set; }
    }
}
