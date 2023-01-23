
using System.ComponentModel.DataAnnotations;

namespace TechStore.Models
{
    public class SpecialOffer : BaseEntity
    {
        [StringLength(500)]
        [Required]
        public string Description { get; set; }

        [StringLength(500)]
        [Required]
        public string Image { get; set; }
        public double Discount { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
