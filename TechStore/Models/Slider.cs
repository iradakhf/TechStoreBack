using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Slider : BaseEntity
    {
        [StringLength(2000)]
        [Required]
        public string Name { get; set; }

        [StringLength(2000)]
        [Required]
        public string Title { get; set; }

        [StringLength(2000)]
        [Required]
        public string Description { get; set; }

        [StringLength(2000)]
        public string Image { get; set; }

        [StringLength(2000)]
        [Required]
        public string Link { get; set; }

        [Required]
        public double RegularPrice { get; set; }

        [Required]
        public double SalePrice { get; set; }
    }
}
