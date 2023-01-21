using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Setting : BaseEntity
    {
        [StringLength(4000)]
        [Required]
        public string Key { get; set; }
        [StringLength(4000)]
        [Required]
        public string Value { get; set; }

    }
}
