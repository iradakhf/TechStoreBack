using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Product : BaseEntity
    {
        [StringLength(500)]
        [Required]
        public string Name { get; set; }

        [StringLength(500)]
        [Required]
        public string infoText { get; set; }

        [Column(TypeName = "money")]
        [Required]
        public double Price { get; set; }

        [Required]
        public double DiscountedPrice { get; set; }

        [StringLength(3)]
        public string Seria { get; set; }

        public int Code { get; set; }

        public int Count { get; set; }

        [StringLength(1000)]
        [Required]
        public string MainImage { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }



        public bool IsNewArrival { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsFeatured { get; set; }
    }
}
