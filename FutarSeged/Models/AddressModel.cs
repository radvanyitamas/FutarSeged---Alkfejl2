using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutarSeged.Models
{
    public class AddressModel
    {
        [Key]
        public int AddressId { get; set; }

        [Required]
        [Display(Name = "Irányítószám")]
        public String AddressPostCode { get; set; }

        [Required]
        [Display(Name = "Város")]
        public String AddressCity { get; set; }

        [Required]
        [Display(Name = "Utca")]
        public String AddressStreetName { get; set; }

        [Required]
        [Display(Name = "Házszám")]
        public int AddressHouseNumber { get; set; }

        [Required]
        [Display(Name = "Egyéd (emelet/ajó)")]
        public String AddressDescription { get; set; }
    }
}
