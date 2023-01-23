using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class ShopBanner : BaseEntity
    {
        [StringLength(1000)]
        [Required]
        public string Image { get; set; }

        [StringLength(1000)]
        [Required]
        public string Link { get; set; }
    }
}
