﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TechStore.Models
{
    public class Category : BaseEntity
    {
        [StringLength(255)]
        [Required(ErrorMessage = "this is required")]
        public string Name { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        public bool IsMain { get; set; }
        public Nullable<int> ParentId { get; set; }
       
        public Category Parent { get; set; }
        public IEnumerable<Category> Children { get; set; }
        public IEnumerable<Product> Products { get; set; }


    }
}
