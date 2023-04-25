﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CategoriesModel
    {
        [DisplayName("Categories Id")]
        public int Id { get; set; }
        [DisplayName("Categories Name")]
        [Required(ErrorMessage = "Categories name is requered")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Categories name must be between 3 and 50 characters")]

        public string Name { get; set; }
        [DisplayName("Categories Observation")]
        [Required(ErrorMessage = "Categories observation is requered")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Categories observation must be between 3 and 200 characters")]
        public string Observation { get; set; }
    }
}
