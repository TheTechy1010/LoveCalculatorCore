using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoveCalculatorCore.Models
{
    public class LoveViewModel
    {
        [Required(ErrorMessage ="Can't leave it empty")]
        [MinLength(3,ErrorMessage ="Should have a minimum length of 3")]
        [MaxLength(40, ErrorMessage = "Should have a maximum length of 40")]
        public string Lover1 { get; set; }

        [Required(ErrorMessage = "Can't leave it empty")]
        [MinLength(3, ErrorMessage = "Should have a minimum length of 3")]
        [MaxLength(40, ErrorMessage = "Should have a maximum length of 40")]
        public string Lover2 { get; set; }
    }
}
