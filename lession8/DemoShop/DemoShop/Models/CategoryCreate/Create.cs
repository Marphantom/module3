﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShop.Models.CategoryCreate
{
    public class Create
    {
        [Required]
        [StringLength(200)]
        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [StringLength(500)]
        public string Picture { get; set; }
        public bool Status { get; set; }
    }
}
