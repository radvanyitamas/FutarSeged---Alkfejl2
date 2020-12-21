using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutarSeged.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [Required]
        [Display(Name = "Név")]
        public String FoodName { get; set; }

        [Required]
        [Display(Name = "Ár")]
        public int FoodPrice { get; set; }

        [Required]
        [Display(Name = "Leírás")]
        public String FoodDescription { get; set; }
    }
}
