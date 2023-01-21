using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Banner : BaseEntity
    {
        [StringLength(2550)]
        [Required]
        public string Link { get; set; }

        [StringLength(2550)]
        [Required]
        public string Image { get; set; }
    }
}
