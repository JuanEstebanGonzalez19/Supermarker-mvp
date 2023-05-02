﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarker_mvp.Models
{
    internal class ProvidersModel
    {
        [DisplayName("Providers Id")]
        public int Id { get; set; }

        [DisplayName("Providers Name")]
        [Required(ErrorMessage = "Pay mode name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Providers name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Providers observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Providers observation must be between B and 200 characters")]
        public string Observation { get; set; }
    }
}